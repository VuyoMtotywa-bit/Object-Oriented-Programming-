Option Explicit On
Option Strict On

Public Class frmLuxuryCars
    'Examination number

    Private Sub btnCompute_Click(ByVal sender As System.Object, _
                                 ByVal e As System.EventArgs) _
                                 Handles btnCompute.Click

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
