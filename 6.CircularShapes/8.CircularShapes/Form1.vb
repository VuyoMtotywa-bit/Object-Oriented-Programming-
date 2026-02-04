Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        If rdoSphere.Checked = True Then
            Dim objSphere As New clsSphere
            objSphere._decRadius = CDec(txtRadius.Text)
            'Calling/Envoke
            lblVolume.Text = objSphere.CalcVolume.ToString("N2")

        End If

        If rdoCylinder.Checked = True Then
            Dim objCylinder As New clsCylinder
            objCylinder._decRadius = CDec(txtRadius.Text)
            objCylinder._decHeight = CDec(txtHeight.Text)
            'Calling/Envoke
            lblVolume.Text = objCylinder.CalcVolume.ToString("N2")
        End If

        If rdoCone.Checked = True Then
            Dim objCone As New clsCone
            objCone._decRadius = CDec(txtRadius.Text)
            objCone._decHeight = CDec(txtHeight.Text)
            'Calling/Envoke
            lblVolume.Text = objCone.CalcVolume.ToString("N2")
        End If
    End Sub
End Class
