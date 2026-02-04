Option Explicit On
Option Strict On

Public Class frmLuxuryCars
    'Examination number

    Private Sub btnCompute_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
                                 Handles btnCompute.Click
        If radPrivateCar.Checked = True Then
            Dim objPrivateCar As New clsPrivateCar
            objPrivateCar._strName = txtName.Text
            objPrivateCar._strSurname = txtSurname.Text
            objPrivateCar._strContact = txtContact.Text
            objPrivateCar._intNoOfDays = CInt(txtNoDays.Text)

        End If

        If radMiniBus.Checked = True Then
            Dim objMiniBus As New ClsMiniBus
            objMiniBus._strName = txtName.Text
            objMiniBus._strSurname = txtSurname.Text
            objMiniBus._strContact = txtContact.Text
            objMiniBus._intNoOfDays = CInt(txtNoDays.Text)

        End If
    End Sub

    Private Sub frmLuxuryCars_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        radPrivateCar.Checked = True

    End Sub

    Private Sub btnClear_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtName.Clear()
        txtSurname.Clear()
        txtContact.Clear()
        txtNoDays.Clear()

        radPrivateCar.Checked = True

        lblAmountPayable.Text = ""

    End Sub

    Private Sub btnExit_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()

    End Sub

End Class
