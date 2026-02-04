Option Explicit On
Option Strict On

Public Class frmLoans

    Private ConnectionPath As String = "Provider=Microsoft.Jet.OLEDB.4.0;" & _
                                       "Data Source=" & Application.StartupPath & _
                                       "\Loans.mdb"



    Private Sub btnView_Click(sender As Object, e As EventArgs) Handles btnView.Click

    End Sub
End Class
