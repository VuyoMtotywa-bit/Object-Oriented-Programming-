Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Instantiation

        Dim objCylinderVolume As New clsCylinderVolume

        'Initialization
        objCylinderVolume._dblRadius = CDbl(txtRadius.Text)
        objCylinderVolume._dblHeight = CDbl(txtRadius.Text)

        'Envoke and Call the function and display
        lblVolume.Text = objCylinderVolume.CylinderVolume().ToString("N2")


    End Sub
End Class
