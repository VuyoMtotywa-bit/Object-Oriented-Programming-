Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If radCircleArea.Checked = True Then
            Dim objCircleACircumference As New clsCircleAreaCircumference

            Try
                objCircleACircumference._decRadius = CDec(txtHeight.Text)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try


            lblVolume.Text = objCircleACircumference.CalcCircleArea.ToString("N2")

        End If
        If radCircleCircumference.Checked = True Then
            Dim objCircleACircumference As New clsCircleAreaCircumference


            lblVolume.Text = objCircleACircumference.CalcCircleCurcumference.ToString("N2")

            Try
                objCircleACircumference._decRadius = CDec(txtHeight.Text)
            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
        End If


    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Call ClearControls()
    End Sub

    Sub ClearControls()
        'Clear Controls

        txtHeight.Clear()
        lblVolume.Text = ""
        radCircleArea.Checked = True
        txtRadius.Clear()

        txtRadius.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Call LogOut()
    End Sub
    Sub LogOut()
        Dim intResponse As Integer
        intResponse = MessageBox.Show("Do you want to exit?", "Exit", MessageBoxButtons.YesNo,
                                      MessageBoxIcon.Question)
        If intResponse = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub




End Class
