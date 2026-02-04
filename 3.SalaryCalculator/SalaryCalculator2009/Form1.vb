Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Intsentiation
        Dim objSalraryCalculator As New ClsSalaryCalculator

        'Initialiasation
        objSalraryCalculator._decSalary = CDec(txtSalary.Text)
        objSalraryCalculator._strWorkerRank = txtRank.Text
        objSalraryCalculator._decIncresePercentage = CDec(txtSalaryIncrease.Text)

        'Envoke/Call the function
        lblAnswer.Text = objSalraryCalculator.CalcSalary().ToString()



    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
