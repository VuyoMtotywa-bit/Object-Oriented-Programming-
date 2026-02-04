Option Explicit On
Option Strict On

'Name:Vuyo
'Surname:Mtotywa
'Date:03/03/2025
'Project:Practical Assessment 



Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click




        'Displaying Necessary Outputs
        lstDisplay.Items.Add("Welcome To Kareems Superette")
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")

        lstDisplay.Items.Add("Customer Name:" & "---------------------------------" & vbTab & vbTab & txtCustomerName.Text)
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")

        lstDisplay.Items.Add("Customer Surname:" & vbTab & txtCustomerSurname.Text)
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")

        lstDisplay.Items.Add("Customer Cell No" & vbTab & txtCustomerNo.Text)
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")

        lstDisplay.Items.Add("Customer Email" & vbTab & txtEmail.Text)
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")


        lstDisplay.Items.Add("Product Quantity" & vbTab & txtQuantity.Text)
        lstDisplay.Items.Add("-----------------------------------------------------------------------------------")






        If cboSelectCategory.SelectedIndex = 1 Then
            If radFizzyDrink.Checked = True Then
                'Instentiation
                Dim objBeverages As New clsBeverage
                objBeverages._strProductName = radFizzyDrink.Text
                objBeverages._decProductPrice = 15D
                objBeverages._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBeverages.CalcSubTotalAmount().ToString("C2"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBeverages.CalcVAT().ToString("C2"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBeverages.CalcDiscount().ToString("C2"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBeverages.CalcFinalAmount().ToString("C2"))










                lstDisplay.Items.Add("Final Total " & vbTab)


            End If


            If radSpringWater.Checked = True Then
                'Instentiation
                Dim objBeverages As New clsBeverage
                objBeverages._strProductName = radSpringWater.Text
                objBeverages._decProductPrice = 12D
                objBeverages._intProductQuantity = CInt(txtQuantity.Text)
                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBeverages.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBeverages.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBeverages.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBeverages.CalcFinalAmount().ToString("C"))







            End If

            If radJuice.Checked = True Then
                'Instentiation
                Dim objBeverages As New clsBeverage
                objBeverages._strProductName = radJuice.Text
                objBeverages._decProductPrice = 20D
                objBeverages._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBeverages.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBeverages.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBeverages.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBeverages.CalcFinalAmount().ToString("C"))


            End If

        End If

        If cboSelectCategory.SelectedIndex = 3 Then
            If radFormula.Checked = True Then
                'Instentiation
                Dim objBabies As New clsBabies
                objBabies._strProductName = radFormula.Text
                objBabies._decProductPrice += 30D
                objBabies._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBabies.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBabies.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBabies.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBabies.CalcFinalAmount().ToString("C"))



            End If
            If radNappies.Checked = True Then
                'Instentiation
                Dim objBabies As New clsBabies
                objBabies._strProductName = radNappies.Text
                objBabies._decProductPrice += 10D
                objBabies._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBabies.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBabies.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBabies.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBabies.CalcFinalAmount().ToString("C"))


            End If
            If radPacifier.Checked = True Then
                'Instentiation
                Dim objBabies As New clsBabies
                objBabies._strProductName = radPacifier.Text
                objBabies._decProductPrice += 40D
                objBabies._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objBabies.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objBabies.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objBabies.decDiscountRate.ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objBabies.CalcFinalAmount().ToString("C"))

            End If
        End If

        If cboSelectCategory.SelectedIndex = 2 Then
            If radApple.Checked = True Then
                'Instentiation
                Dim objFruits As New clsFruits
                objFruits._strProductName = radApple.Text
                objFruits._decProductPrice += 2.5D
                objFruits._intProductQuantity = CInt(txtQuantity.Text)

                'Displaying Required Outputs
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objFruits.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objFruits.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objFruits.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objFruits.CalcFinalAmount().ToString("C"))

            End If
            If radMango.Checked = True Then
                'Instentiation
                Dim objFruits As New clsFruits
                objFruits._strProductName = radMango.Text
                objFruits._decProductPrice += 10D
                objFruits._intProductQuantity = CInt(txtQuantity.Text)


                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objFruits.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objFruits.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objFruits.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objFruits.CalcFinalAmount().ToString("C"))


            End If

            If radOrange.Checked = True Then
                'Instentiation
                Dim objFruits As New clsFruits
                objFruits._strProductName = radOrange.Text
                objFruits._decProductPrice += 3D
                objFruits._intProductQuantity = CInt(txtQuantity.Text)

                'Initialization
                lstDisplay.Items.Add("Subtotal of Product" & vbTab & objFruits.CalcSubTotalAmount().ToString("C"))
                lstDisplay.Items.Add("Product after VAT:" & vbTab & objFruits.CalcVAT().ToString("C"))
                lstDisplay.Items.Add("Discount Gained" & vbTab & objFruits.CalcDiscount().ToString("C"))
                lstDisplay.Items.Add("Final Amount of Product" & vbTab & objFruits.CalcFinalAmount().ToString("C"))



            End If

        End If



    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cboSelectCategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectCategory.SelectedIndexChanged
        'Enabling & disabling of combo box 

        If cboSelectCategory.SelectedIndex = 1 Then
            grpBeverage.Enabled = True
            grpBabies.Enabled = False
            grpFruit.Enabled = False
        ElseIf cboSelectCategory.SelectedIndex = 2 Then
            grpFruit.Enabled = True
            grpBeverage.Enabled = False
            grpBabies.Enabled = False
        Else
            grpBabies.Enabled = True
            grpBeverage.Enabled = False
            grpFruit.Enabled = False


        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clearing necessary controls
        txtCustomerName.Text = ""
        txtCustomerNo.Text = ""
        txtCustomerSurname.Text = ""
        txtEmail.Text= ""
        txtQuantity.Text = ""
        cboSelectCategory.SelectedIndex = 0

        txtCustomerName.Focus()
        grpBabies.Enabled = True
        grpBeverage.Enabled = True
        grpFruit.Enabled = True

        lstDisplay.Items.Clear()

        radApple.Checked = False
        radFizzyDrink.Checked = False
        radFormula.Checked = False
        radJuice.Checked = False
        radMango.Checked = False
        radNappies.Checked = False
        radOrange.Checked = False
        radPacifier.Checked = False
        radSpringWater.Checked = False


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        'Termination of Project
        MessageBox.Show("You are about to abort this Project", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning)

        Close()

    End Sub
End Class
