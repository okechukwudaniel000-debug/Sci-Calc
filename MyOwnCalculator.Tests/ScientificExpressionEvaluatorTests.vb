Imports Microsoft.VisualStudio.TestTools.UnitTesting

Namespace MyOwnCalculator.Tests

    <TestClass>
    Public Class ScientificExpressionEvaluatorTests

#Region "Order of Operations (BODMAS / PEMDAS)"

        <TestMethod>
        Public Sub OrderOfOperations_AdditionAndMultiplication_EvaluatesCorrectly()
            ' Multiplication before addition: 2 + 3 * 4 = 14
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("2 + 3 * 4")
            Assert.AreEqual(14.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub OrderOfOperations_SubstractionAndDivision_EvaluatesCorrectly()
            ' Division before subtraction: 20 - 10 / 2 = 15
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("20 - 10 / 2")
            Assert.AreEqual(15.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub OrderOfOperations_ComplexArithmeticMix_EvaluatesCorrectly()
            ' 10 + 20 * 3 - 50 / 2 = 10 + 60 - 25 = 45
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("10 + 20 * 3 - 50 / 2")
            Assert.AreEqual(45.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub OrderOfOperations_ParenthesesOverride_EvaluatesCorrectly()
            ' (2 + 3) * 4 = 20
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("(2 + 3) * 4")
            Assert.AreEqual(20.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub OrderOfOperations_PercentageAndFactorial_EvaluatesCorrectly()
            ' 50% = 0.5, 4! = 24 -> 4! + 50% = 24.5
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("4! + 50%")
            Assert.AreEqual(24.5, result, 0.000001)
        End Sub

#End Region

#Region "DEG vs RAD Trigonometric Calculations"

        <TestMethod>
        Public Sub Trig_Sin30_InDegrees_ReturnsHalf()
            ' sin(30°) = 0.5
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("sin(30)", AngleMode.Degrees)
            Assert.AreEqual(0.5, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Trig_CosPi_InRadians_ReturnsMinusOne()
            ' cos(π) = -1
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("cos(π)", AngleMode.Radians)
            Assert.AreEqual(-1.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Trig_Cos90_InDegrees_ReturnsZero()
            ' cos(90°) = 0
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("cos(90)", AngleMode.Degrees)
            Assert.AreEqual(0.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Trig_SinPiOver2_InRadians_ReturnsOne()
            ' sin(π / 2) = 1
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("sin(π / 2)", AngleMode.Radians)
            Assert.AreEqual(1.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Trig_Tan45_InDegrees_ReturnsOne()
            ' tan(45°) = 1
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("tan(45)", AngleMode.Degrees)
            Assert.AreEqual(1.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Trig_Tan90_InDegrees_ThrowsException()
            ' tan(90°) is undefined
            Dim thrown As Boolean = False
            Try
                ScientificExpressionEvaluator.Evaluate("tan(90)", AngleMode.Degrees)
            Catch ex As InvalidOperationException
                thrown = True
            End Try
            Assert.IsTrue(thrown, "Expected InvalidOperationException for tan(90) in degrees.")
        End Sub

#End Region

#Region "Power and Nested Parentheses Combinations"

        <TestMethod>
        Public Sub Power_RightAssociativity_Evaluates2Pow3Pow2()
            ' 2^3^2 = 2^(3^2) = 2^9 = 512
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("2^3^2")
            Assert.AreEqual(512.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub NestedParentheses_MultiplicationOfSums_EvaluatesCorrectly()
            ' (2 + 3) * (4 - 1) = 5 * 3 = 15
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("(2 + 3) * (4 - 1)")
            Assert.AreEqual(15.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub NestedParentheses_DeepNesting_EvaluatesCorrectly()
            ' ((2 + 3) * (4 - 1)) / (5 - 2) = 15 / 3 = 5
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("((2 + 3) * (4 - 1)) / (5 - 2)")
            Assert.AreEqual(5.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub Power_WithParentheses_EvaluatesCorrectly()
            ' (2^3)^2 = 8^2 = 64
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("(2^3)^2")
            Assert.AreEqual(64.0, result, 0.000001)
        End Sub

        <TestMethod>
        Public Sub ScientificFunctions_CombinedWithPowersAndBrackets_EvaluatesCorrectly()
            ' sqrt((3^2) + (4^2)) = sqrt(9 + 16) = sqrt(25) = 5
            Dim result As Double = ScientificExpressionEvaluator.Evaluate("sqrt((3^2) + (4^2))")
            Assert.AreEqual(5.0, result, 0.000001)
        End Sub

#End Region

#Region "Boundary and Error Checks"

        <TestMethod>
        Public Sub DivisionByZero_ThrowsDivideByZeroException()
            Dim thrown As Boolean = False
            Try
                ScientificExpressionEvaluator.Evaluate("10 / 0")
            Catch ex As DivideByZeroException
                thrown = True
            End Try
            Assert.IsTrue(thrown, "Expected DivideByZeroException for division by 0.")
        End Sub

        <TestMethod>
        Public Sub NegativeSquareRoot_ThrowsInvalidOperationException()
            Dim thrown As Boolean = False
            Try
                ScientificExpressionEvaluator.Evaluate("sqrt(-4)")
            Catch ex As InvalidOperationException
                thrown = True
            End Try
            Assert.IsTrue(thrown, "Expected InvalidOperationException for sqrt(-4).")
        End Sub

        <TestMethod>
        Public Sub NonPositiveLogarithm_LogZero_ThrowsInvalidOperationException()
            Dim thrown As Boolean = False
            Try
                ScientificExpressionEvaluator.Evaluate("log(0)")
            Catch ex As InvalidOperationException
                thrown = True
            End Try
            Assert.IsTrue(thrown, "Expected InvalidOperationException for log(0).")
        End Sub

        <TestMethod>
        Public Sub NonPositiveLogarithm_LnNegative_ThrowsInvalidOperationException()
            Dim thrown As Boolean = False
            Try
                ScientificExpressionEvaluator.Evaluate("ln(-1)")
            Catch ex As InvalidOperationException
                thrown = True
            End Try
            Assert.IsTrue(thrown, "Expected InvalidOperationException for ln(-1).")
        End Sub

#End Region

    End Class

End Namespace
