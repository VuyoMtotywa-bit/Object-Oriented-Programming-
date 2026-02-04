'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:no7


Public Class Form1
    Private Sub btnCalc_Installment_Click(sender As Object, e As EventArgs) Handles btnCalc_Installment.Click
        If radLaptop.Checked = True Then
            'Instantiation
            Dim objLaptop As New clsLaptop
            'Initialisation
            objLaptop._strProductNumber = txtProductNum.Text
            objLaptop._strColor = txtColor.Text
            objLaptop._strDiskSize = txtDiskSize.Text

            'Envoke Methods
            lblMonthInstallment.Text = objLaptop.CalcMonthlyInstallment().ToString("C")

        End If

        If radPersonalComputer.Checked = True Then
            'Instantiation
            Dim objPC As New clsPC
            'Initialisation
            objPC._strProductNumber = txtProductNum.Text
            objPC._strColor = txtColor.Text
            objPC._strDiskSize = txtDiskSize.Text

            'Envoke Methods
            lblMonthInstallment.Text = objPC.CalcMonthlyInstallment().ToString("C")

        End If

        If radMainFrame.Checked = True Then
            'Instantiation
            Dim objMainFrame As New clsMainFrame
            'Initialisation
            objMainFrame._strProductNumber = txtProductNum.Text
            objMainFrame._strColor = txtColor.Text
            objMainFrame._strDiskSize = txtDiskSize.Text

            'Envoke Methods
            lblMonthInstallment.Text = objMainFrame.CalcMonthlyInstallment().ToString("C")

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
