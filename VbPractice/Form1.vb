Public Class Form1
    Private Sub ButtonUpdate_Click(sender As Object, e As EventArgs) Handles ButtonUpdate.Click


        Dim txtOutput As String = ""

        Dim randStr As String = "This is a string"

        txtOutput &= "randStr length = " & randStr.Length & Environment.NewLine


        txtOutput &= "1st 3  = " & randStr.Substring(0, 3) & Environment.NewLine

        randStr = randStr.Replace("string", "sentence")
        txtOutput &= "Changed String = " & randStr & Environment.NewLine

        Dim decRandNum As Decimal = 3123.14159

        txtOutput &= "Value = " & String.Format("{0:n3}", decRandNum) & Environment.NewLine

        txtOutput &= "Currency = " & String.Format("{0:c}", decRandNum) & Environment.NewLine

        txtOutput &= "Random = " & String.Format("{0:00000.0}", decRandNum) & Environment.NewLine


        txtOutput &= "is in String = " & InStr(1, randStr, "i", CompareMethod.Text) & Environment.NewLine

        Dim arrayEmployees(0 To 2)
        arrayEmployees(0) = "Bob"
        arrayEmployees(1) = "Sally"
        arrayEmployees(2) = "Josh"

        Dim strEmployees As String = Join(arrayEmployees, ", ")
        txtOutput &= "Employees = " & strEmployees & Environment.NewLine

        arrayEmployees = Split(strEmployees, ", ")

        For i As Integer = 0 To arrayEmployees.Length - 1
            txtOutput &= "Employee = " & arrayEmployees(i) & Environment.NewLine

        Next

        txtOutput &= "left 3 = " & Strings.Left(randStr, 3) & Environment.NewLine

        txtOutput &= "right 3 = " & Strings.Right(randStr, 3) & Environment.NewLine

        txtOutput &= "Uppercase = " & Strings.UCase(randStr) & Environment.NewLine

        txtOutput &= "Lowercase = " & Strings.LCase(randStr) & Environment.NewLine

        txtOutput &= "Reverse= " & StrReverse(randStr) & Environment.NewLine


        txtOutput &= "Dog Compared to Cat= " & StrComp("Dog", "Cat", CompareMethod.Text) & Environment.NewLine


        txtOutput &= "Trim = " & Trim("       String      ") & Environment.NewLine


        TextBox1.Text = txtOutput
    End Sub
End Class
