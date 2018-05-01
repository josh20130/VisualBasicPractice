Public Class Form1
    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        txtName.Text = "Hello " & txtName.Text

    End Sub

    Private Sub txtMessage_Click(sender As Object, e As EventArgs) Handles txtMessage.Click


        MessageBox.Show("Hello " & txtName.Text, "Hello " & txtName.Text)



    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Me.Close()

    End Sub

    Private Sub lblAddEqual_Click(sender As Object, e As EventArgs) Handles lblAddEqual.Click

    End Sub

    Private Sub btnAddValues_Click(sender As Object, e As EventArgs) Handles btnAddValues.Click

        Try

            Dim firstNum As Integer = CInt(txtAddVal1.Text)
            Dim secondNum As Integer = CInt(txtAddVal2.Text)
            Dim sum = firstNum + secondNum

            txtSumAnswer.Text = CStr(sum)
        Catch ex As System.InvalidCastException
            MessageBox.Show("Please enter numbers to sum", "Error")
            Console.WriteLine("An error occurred")


        Catch ex As Exception

            MessageBox.Show("An unknown error occured", "Error")

        End Try

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles txtDivideValue1.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblDivideEqual.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtDivideValue2.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDivideValues.Click

        Dim firstNum As Decimal = CDec(txtDivideValue1.Text)
        Dim secondNum As Decimal = CDec(txtDivideValue2.Text)
        Dim intSolution As Integer = CType(firstNum / secondNum, Integer)

        txtDivisionAnswer.Text = CStr(intSolution)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtDivisionAnswer.TextChanged

    End Sub
End Class
