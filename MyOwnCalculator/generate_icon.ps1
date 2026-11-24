Add-Type -AssemblyName System.Drawing

function Create-CalculatorBitmap([int]$size) {
    $bmp = New-Object System.Drawing.Bitmap($size, $size)
    $g = [System.Drawing.Graphics]::FromImage($bmp)
    $g.SmoothingMode = [System.Drawing.Drawing2D.SmoothingMode]::AntiAlias
    $g.TextRenderingHint = [System.Drawing.Text.TextRenderingHint]::AntiAliasGridFit

    # Outer background rounded container
    $rect = New-Object System.Drawing.Rectangle(0, 0, $size, $size)
    $brushBg = New-Object System.Drawing.Drawing2D.LinearGradientBrush(
        $rect,
        [System.Drawing.Color]::FromArgb(0, 120, 215),
        [System.Drawing.Color]::FromArgb(0, 70, 170),
        45.0
    )
    $g.FillRectangle($brushBg, $rect)

    # Top display screen representation
    $dispMarginX = [int]($size * 0.12)
    $dispMarginY = [int]($size * 0.12)
    $dispW = [int]($size - ($dispMarginX * 2))
    $dispH = [int]($size * 0.24)
    $dispBrush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(235, 245, 255))
    $g.FillRectangle($dispBrush, $dispMarginX, $dispMarginY, $dispW, $dispH)

    # Mathematical display text inside screen
    if ($size -ge 32) {
        $fontSize = [float]($dispH * 0.5)
        $fontDisp = New-Object System.Drawing.Font('Segoe UI', $fontSize, [System.Drawing.FontStyle]::Bold)
        $brushText = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(0, 80, 160))
        $sf = New-Object System.Drawing.StringFormat
        $sf.Alignment = [System.Drawing.StringAlignment]::Far
        $sf.LineAlignment = [System.Drawing.StringAlignment]::Center
        $rectX = [float]$dispMarginX
        $rectY = [float]$dispMarginY
        $rectW = [float]($dispW - 4)
        $rectH = [float]$dispH
        $dispRect = New-Object System.Drawing.RectangleF($rectX, $rectY, $rectW, $rectH)
        $g.DrawString("0", $fontDisp, $brushText, $dispRect, $sf)
    }

    # Grid of keypad buttons
    $btnRows = 3
    $btnCols = 3
    $gridTop = [int]($size * 0.44)
    $gridBottom = [int]($size * 0.88)
    $gridLeft = $dispMarginX
    $gridRight = [int]($size - $dispMarginX)
    $cellW = [int](($gridRight - $gridLeft) / $btnCols)
    $cellH = [int](($gridBottom - $gridTop) / $btnRows)
    $pad = [Math]::Max(1, [int]($cellW * 0.14))

    $btnBrush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(255, 255, 255))
    $accentBrush = New-Object System.Drawing.SolidBrush([System.Drawing.Color]::FromArgb(255, 159, 10))

    for ($r = 0; $r -lt $btnRows; $r++) {
        for ($c = 0; $c -lt $btnCols; $c++) {
            $bx = $gridLeft + ($c * $cellW) + $pad
            $by = $gridTop + ($r * $cellH) + $pad
            $bw = $cellW - ($pad * 2)
            $bh = $cellH - ($pad * 2)

            $bToUse = if ($r -eq 2 -and $c -eq 2) { $accentBrush } else { $btnBrush }
            $g.FillRectangle($bToUse, $bx, $by, $bw, $bh)
        }
    }

    $g.Dispose()
    return $bmp
}

$sizes = @(16, 32, 48, 64, 128, 256)
$images = @()
foreach ($s in $sizes) {
    $images += Create-CalculatorBitmap $s
}

$ms = New-Object System.IO.MemoryStream
$bw = New-Object System.IO.BinaryWriter($ms)

# ICONDIR
$bw.Write([uint16]0) # Reserved
$bw.Write([uint16]1) # Type (1 = ICO)
$bw.Write([uint16]$images.Count)

# Calculate image data offsets
$offset = 6 + ($images.Count * 16)
$pngStreams = @()

foreach ($img in $images) {
    $pngMs = New-Object System.IO.MemoryStream
    $img.Save($pngMs, [System.Drawing.Imaging.ImageFormat]::Png)
    $pngBytes = $pngMs.ToArray()
    $pngStreams += $pngBytes

    $w = if ($img.Width -ge 256) { [byte]0 } else { [byte]$img.Width }
    $h = if ($img.Height -ge 256) { [byte]0 } else { [byte]$img.Height }

    $bw.Write($w)                         # Width
    $bw.Write($h)                         # Height
    $bw.Write([byte]0)                     # Colors
    $bw.Write([byte]0)                     # Reserved
    $bw.Write([uint16]1)                   # Color planes
    $bw.Write([uint16]32)                  # Bits per pixel
    $bw.Write([uint32]$pngBytes.Length)    # Image size
    $bw.Write([uint32]$offset)             # Image offset

    $offset += $pngBytes.Length
}

foreach ($bytes in $pngStreams) {
    $bw.Write($bytes)
}

$outPath = "C:\Users\USER\Desktop\MyOwnCalculatorSolution1\MyOwnCalculator\app.ico"
[System.IO.File]::WriteAllBytes($outPath, $ms.ToArray())
$ms.Dispose()

Write-Host "Generated clean multi-resolution icon at: $outPath ($((Get-Item $outPath).Length) bytes)"
