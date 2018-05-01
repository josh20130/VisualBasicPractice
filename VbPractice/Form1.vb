Public Class Form1
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click


        Dim txtOutput As String = ""

        Dim intVal As Integer = 10


        ChangeVal(intVal)

        txtOutput &= "1 + 2 + 3 + 4 =" & GetSumMore(1, 2, 3, 4) & Environment.NewLine


        TextBox1.Text = txtOutput
    End Sub

    Private Sub ChangeVal(ByRef intVal As Integer)
        intVal = 30
        MessageBox.Show("intVal in func 1 = " & intVal & Environment.NewLine)
    End Sub

    Private Function GetSumMore(ByVal ParamArray Numbers() As Integer)

        Dim sum As Integer = 0

        For i As Integer = 0 To Numbers.Length
            sum += i

        Next
        Return sum
    End Function
End Class
