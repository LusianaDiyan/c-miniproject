Public Class Form1

    Private Enum OperatorAritmatika
        ADD
        SUBTRACT
        MULTIPLY
        DIVIDE
    End Enum

    Private operators As New List(Of OperatorAritmatika)
    Private numbers As New List(Of Integer)

    Private Sub DisplayNumber(ByVal number As String)
        Dim result_string As String

        result_string = TextBoxResult.Text
        result_string &= number

        TextBoxResult.Clear()
        TextBoxResult.Text = result_string
    End Sub

    Private Sub Button_0_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_0.Click
        DisplayNumber(CStr(0))
    End Sub

    Private Sub Button_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_1.Click
        DisplayNumber(CStr(1))
    End Sub

    Private Sub Button_2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_2.Click
        DisplayNumber(CStr(2))
    End Sub

    Private Sub Button_3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_3.Click
        DisplayNumber(CStr(3))
    End Sub

    Private Sub Button_4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_4.Click
        DisplayNumber(CStr(4))
    End Sub

    Private Sub Button_5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_5.Click
        DisplayNumber(CStr(5))
    End Sub

    Private Sub Button_6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_6.Click
        DisplayNumber(CStr(6))
    End Sub

    Private Sub Button_7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_7.Click
        DisplayNumber(CStr(7))
    End Sub

    Private Sub Button_8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_8.Click
        DisplayNumber(CStr(8))
    End Sub

    Private Sub Button_9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_9.Click
        DisplayNumber(CStr(9))
    End Sub

    Private Sub PushOperator(ByVal number As Integer, ByVal operator_aritmatika As OperatorAritmatika)
        numbers.Add(number)
        operators.Add(operator_aritmatika)
        TextBoxResult.Clear()
    End Sub

    Private Sub ButtonAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonAdd.Click
        PushOperator(CInt(TextBoxResult.Text), OperatorAritmatika.ADD)
    End Sub

    Private Sub ButtonSubtract_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSubtract.Click
        PushOperator(CInt(TextBoxResult.Text), OperatorAritmatika.SUBTRACT)
    End Sub

    Private Sub ButtonMultiply_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMultiply.Click
        PushOperator(CInt(TextBoxResult.Text), OperatorAritmatika.MULTIPLY)
    End Sub

    Private Sub ButtonDivision_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonDivision.Click
        PushOperator(CInt(TextBoxResult.Text), OperatorAritmatika.DIVIDE)
    End Sub

    Private Sub ButtonEqual_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonEqual.Click
        numbers.Add(CInt(TextBoxResult.Text))

        Dim operand_1 As Integer
        Dim operand_2 As Integer
        Dim operator_aritmatika As OperatorAritmatika

        operand_1 = numbers(0)
        operand_2 = numbers(1)
        operator_aritmatika = operators(0)
        Dim result As Integer = 0
        Select Case operator_aritmatika
            Case OperatorAritmatika.ADD
                result = operand_1 + operand_2
            Case OperatorAritmatika.SUBTRACT
                result = operand_1 - operand_2
            Case OperatorAritmatika.MULTIPLY
                result = operand_1 * operand_2
            Case OperatorAritmatika.DIVIDE
                result = operand_1 / operand_2
        End Select

        ClearAll()
        TextBoxResult.Text = result
    End Sub

    Private Sub ClearAll()
        TextBoxResult.Clear()
        numbers.Clear()
        operators.Clear()
    End Sub

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        ClearAll()
    End Sub
End Class
