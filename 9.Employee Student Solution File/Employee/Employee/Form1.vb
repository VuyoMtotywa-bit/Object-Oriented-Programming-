Option Explicit On
Option Strict On


'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:Practical Assessment 

Public Class frmEmployee
    Private Sub btnCalcPay_Click(sender As Object, e As EventArgs) Handles btnCalcPay.Click
        If radFullTime.Checked = True Then
            Dim objFullTimeEmployee As New ClsFullTimeEmployee
            objFullTimeEmployee._strEmployeeName = txtEmpName.Text
            objFullTimeEmployee._strEmployeeNO = txtEmpNo.Text
            objFullTimeEmployee._strEmployeeSurname = txtEmpSurname.Text
            objFullTimeEmployee._decAnnualSalary = CDec(txtSalary.Text)

            lblPay.Text = objFullTimeEmployee.CalcNetSalary().ToString("C2")


        End If

        If radCasual.Checked = True Then
            Dim objCasuaLEmployee As New ClsCasualEmployee
            objCasuaLEmployee._strEmployeeName = txtEmpName.Text
            objCasuaLEmployee._strEmployeeNO = txtEmpNo.Text
            objCasuaLEmployee._strEmployeeSurname = txtEmpSurname.Text
            objCasuaLEmployee._intHoursWorked = CInt(txtHoursWorked.Text)
            objCasuaLEmployee._decPayRate = CDec(txtSalary.Text)



            objCasuaLEmployee.CalcNetSalary().ToString("C2")

        End If
    End Sub
End Class
