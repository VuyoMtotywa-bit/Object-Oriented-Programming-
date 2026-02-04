<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.grpBeverage = New System.Windows.Forms.GroupBox()
        Me.txtQuantity = New System.Windows.Forms.TextBox()
        Me.radJuice = New System.Windows.Forms.RadioButton()
        Me.lblQuantity = New System.Windows.Forms.Label()
        Me.radSpringWater = New System.Windows.Forms.RadioButton()
        Me.radFizzyDrink = New System.Windows.Forms.RadioButton()
        Me.grpFruit = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.radMango = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.radOrange = New System.Windows.Forms.RadioButton()
        Me.radApple = New System.Windows.Forms.RadioButton()
        Me.grpBabies = New System.Windows.Forms.GroupBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.radPacifier = New System.Windows.Forms.RadioButton()
        Me.radNappies = New System.Windows.Forms.RadioButton()
        Me.radFormula = New System.Windows.Forms.RadioButton()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lstDisplay = New System.Windows.Forms.ListBox()
        Me.grpCustomerDetails = New System.Windows.Forms.GroupBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtCustomerNo = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCustomerSurname = New System.Windows.Forms.TextBox()
        Me.txtCustomerName = New System.Windows.Forms.TextBox()
        Me.lblCustomerSurname = New System.Windows.Forms.Label()
        Me.lblCustomerDetails = New System.Windows.Forms.Label()
        Me.cboSelectCategory = New System.Windows.Forms.ComboBox()
        Me.lblCategory = New System.Windows.Forms.Label()
        Me.grpBeverage.SuspendLayout()
        Me.grpFruit.SuspendLayout()
        Me.grpBabies.SuspendLayout()
        Me.grpCustomerDetails.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(267, 336)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 0
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(39, 336)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 1
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(495, 336)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "&Exit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'grpBeverage
        '
        Me.grpBeverage.Controls.Add(Me.txtQuantity)
        Me.grpBeverage.Controls.Add(Me.radJuice)
        Me.grpBeverage.Controls.Add(Me.lblQuantity)
        Me.grpBeverage.Controls.Add(Me.radSpringWater)
        Me.grpBeverage.Controls.Add(Me.radFizzyDrink)
        Me.grpBeverage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBeverage.Location = New System.Drawing.Point(32, 166)
        Me.grpBeverage.Name = "grpBeverage"
        Me.grpBeverage.Size = New System.Drawing.Size(198, 154)
        Me.grpBeverage.TabIndex = 3
        Me.grpBeverage.TabStop = False
        Me.grpBeverage.Text = "Beverages"
        '
        'txtQuantity
        '
        Me.txtQuantity.Location = New System.Drawing.Point(108, 128)
        Me.txtQuantity.Name = "txtQuantity"
        Me.txtQuantity.Size = New System.Drawing.Size(79, 20)
        Me.txtQuantity.TabIndex = 15
        '
        'radJuice
        '
        Me.radJuice.AutoSize = True
        Me.radJuice.Location = New System.Drawing.Point(7, 101)
        Me.radJuice.Name = "radJuice"
        Me.radJuice.Size = New System.Drawing.Size(81, 17)
        Me.radJuice.TabIndex = 2
        Me.radJuice.TabStop = True
        Me.radJuice.Text = "Juice (20)"
        Me.radJuice.UseVisualStyleBackColor = True
        '
        'lblQuantity
        '
        Me.lblQuantity.AutoSize = True
        Me.lblQuantity.Location = New System.Drawing.Point(17, 131)
        Me.lblQuantity.Name = "lblQuantity"
        Me.lblQuantity.Size = New System.Drawing.Size(54, 13)
        Me.lblQuantity.TabIndex = 14
        Me.lblQuantity.Text = "Quantity"
        '
        'radSpringWater
        '
        Me.radSpringWater.AutoSize = True
        Me.radSpringWater.Location = New System.Drawing.Point(7, 69)
        Me.radSpringWater.Name = "radSpringWater"
        Me.radSpringWater.Size = New System.Drawing.Size(134, 17)
        Me.radSpringWater.TabIndex = 1
        Me.radSpringWater.TabStop = True
        Me.radSpringWater.Text = "Spring Water (R12)"
        Me.radSpringWater.UseVisualStyleBackColor = True
        '
        'radFizzyDrink
        '
        Me.radFizzyDrink.AutoSize = True
        Me.radFizzyDrink.Location = New System.Drawing.Point(7, 33)
        Me.radFizzyDrink.Name = "radFizzyDrink"
        Me.radFizzyDrink.Size = New System.Drawing.Size(122, 17)
        Me.radFizzyDrink.TabIndex = 0
        Me.radFizzyDrink.TabStop = True
        Me.radFizzyDrink.Text = "Fizzy Drink (R15)"
        Me.radFizzyDrink.UseVisualStyleBackColor = True
        '
        'grpFruit
        '
        Me.grpFruit.Controls.Add(Me.TextBox1)
        Me.grpFruit.Controls.Add(Me.radMango)
        Me.grpFruit.Controls.Add(Me.Label6)
        Me.grpFruit.Controls.Add(Me.radOrange)
        Me.grpFruit.Controls.Add(Me.radApple)
        Me.grpFruit.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpFruit.Location = New System.Drawing.Point(267, 166)
        Me.grpFruit.Name = "grpFruit"
        Me.grpFruit.Size = New System.Drawing.Size(168, 154)
        Me.grpFruit.TabIndex = 4
        Me.grpFruit.TabStop = False
        Me.grpFruit.Text = "Fruit"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(95, 128)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(67, 20)
        Me.TextBox1.TabIndex = 15
        '
        'radMango
        '
        Me.radMango.AutoSize = True
        Me.radMango.Location = New System.Drawing.Point(7, 101)
        Me.radMango.Name = "radMango"
        Me.radMango.Size = New System.Drawing.Size(132, 17)
        Me.radMango.TabIndex = 2
        Me.radMango.TabStop = True
        Me.radMango.Text = "Mango Loose(R10)"
        Me.radMango.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(4, 131)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(54, 13)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Quantity"
        '
        'radOrange
        '
        Me.radOrange.AutoSize = True
        Me.radOrange.Location = New System.Drawing.Point(6, 69)
        Me.radOrange.Name = "radOrange"
        Me.radOrange.Size = New System.Drawing.Size(150, 17)
        Me.radOrange.TabIndex = 1
        Me.radOrange.TabStop = True
        Me.radOrange.Text = "Orange Loose (R3.00)"
        Me.radOrange.UseVisualStyleBackColor = True
        '
        'radApple
        '
        Me.radApple.AutoSize = True
        Me.radApple.Location = New System.Drawing.Point(7, 33)
        Me.radApple.Name = "radApple"
        Me.radApple.Size = New System.Drawing.Size(137, 17)
        Me.radApple.TabIndex = 0
        Me.radApple.TabStop = True
        Me.radApple.Text = "Apple Loose(R2.50)"
        Me.radApple.UseVisualStyleBackColor = True
        '
        'grpBabies
        '
        Me.grpBabies.Controls.Add(Me.TextBox2)
        Me.grpBabies.Controls.Add(Me.radPacifier)
        Me.grpBabies.Controls.Add(Me.radNappies)
        Me.grpBabies.Controls.Add(Me.radFormula)
        Me.grpBabies.Controls.Add(Me.Label7)
        Me.grpBabies.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpBabies.Location = New System.Drawing.Point(488, 166)
        Me.grpBabies.Name = "grpBabies"
        Me.grpBabies.Size = New System.Drawing.Size(163, 154)
        Me.grpBabies.TabIndex = 5
        Me.grpBabies.TabStop = False
        Me.grpBabies.Text = "Babies"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(88, 125)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(69, 20)
        Me.TextBox2.TabIndex = 15
        '
        'radPacifier
        '
        Me.radPacifier.AutoSize = True
        Me.radPacifier.Location = New System.Drawing.Point(7, 101)
        Me.radPacifier.Name = "radPacifier"
        Me.radPacifier.Size = New System.Drawing.Size(103, 17)
        Me.radPacifier.TabIndex = 2
        Me.radPacifier.TabStop = True
        Me.radPacifier.Text = "Pacifier (R40)"
        Me.radPacifier.UseVisualStyleBackColor = True
        '
        'radNappies
        '
        Me.radNappies.AutoSize = True
        Me.radNappies.Location = New System.Drawing.Point(7, 69)
        Me.radNappies.Name = "radNappies"
        Me.radNappies.Size = New System.Drawing.Size(99, 17)
        Me.radNappies.TabIndex = 1
        Me.radNappies.TabStop = True
        Me.radNappies.Text = "Nappies (R5)"
        Me.radNappies.UseVisualStyleBackColor = True
        '
        'radFormula
        '
        Me.radFormula.AutoSize = True
        Me.radFormula.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.radFormula.Location = New System.Drawing.Point(7, 33)
        Me.radFormula.Name = "radFormula"
        Me.radFormula.Size = New System.Drawing.Size(130, 17)
        Me.radFormula.TabIndex = 0
        Me.radFormula.TabStop = True
        Me.radFormula.Text = "Formula 2Kg (R30)"
        Me.radFormula.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 132)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Quantity"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.DimGray
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Poor Richard", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(240, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(242, 35)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Kareems Superette"
        '
        'lstDisplay
        '
        Me.lstDisplay.FormattingEnabled = True
        Me.lstDisplay.Location = New System.Drawing.Point(121, 365)
        Me.lstDisplay.Name = "lstDisplay"
        Me.lstDisplay.Size = New System.Drawing.Size(399, 264)
        Me.lstDisplay.TabIndex = 11
        '
        'grpCustomerDetails
        '
        Me.grpCustomerDetails.Controls.Add(Me.txtEmail)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerNo)
        Me.grpCustomerDetails.Controls.Add(Me.Label3)
        Me.grpCustomerDetails.Controls.Add(Me.Label2)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerSurname)
        Me.grpCustomerDetails.Controls.Add(Me.txtCustomerName)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerSurname)
        Me.grpCustomerDetails.Controls.Add(Me.lblCustomerDetails)
        Me.grpCustomerDetails.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpCustomerDetails.Location = New System.Drawing.Point(39, 36)
        Me.grpCustomerDetails.Name = "grpCustomerDetails"
        Me.grpCustomerDetails.Size = New System.Drawing.Size(600, 92)
        Me.grpCustomerDetails.TabIndex = 12
        Me.grpCustomerDetails.TabStop = False
        Me.grpCustomerDetails.Text = "Customer Details"
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(400, 48)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 15
        '
        'txtCustomerNo
        '
        Me.txtCustomerNo.Location = New System.Drawing.Point(143, 45)
        Me.txtCustomerNo.Name = "txtCustomerNo"
        Me.txtCustomerNo.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerNo.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(275, 52)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Customer Email:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Customer Contact No:"
        '
        'txtCustomerSurname
        '
        Me.txtCustomerSurname.Location = New System.Drawing.Point(381, 16)
        Me.txtCustomerSurname.Name = "txtCustomerSurname"
        Me.txtCustomerSurname.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerSurname.TabIndex = 13
        '
        'txtCustomerName
        '
        Me.txtCustomerName.Location = New System.Drawing.Point(108, 19)
        Me.txtCustomerName.Name = "txtCustomerName"
        Me.txtCustomerName.Size = New System.Drawing.Size(100, 20)
        Me.txtCustomerName.TabIndex = 2
        '
        'lblCustomerSurname
        '
        Me.lblCustomerSurname.AutoSize = True
        Me.lblCustomerSurname.Location = New System.Drawing.Point(251, 19)
        Me.lblCustomerSurname.Name = "lblCustomerSurname"
        Me.lblCustomerSurname.Size = New System.Drawing.Size(116, 13)
        Me.lblCustomerSurname.TabIndex = 1
        Me.lblCustomerSurname.Text = "Customer Surname:"
        '
        'lblCustomerDetails
        '
        Me.lblCustomerDetails.AutoSize = True
        Me.lblCustomerDetails.Location = New System.Drawing.Point(7, 19)
        Me.lblCustomerDetails.Name = "lblCustomerDetails"
        Me.lblCustomerDetails.Size = New System.Drawing.Size(99, 13)
        Me.lblCustomerDetails.TabIndex = 0
        Me.lblCustomerDetails.Text = "Customer Name:"
        '
        'cboSelectCategory
        '
        Me.cboSelectCategory.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.cboSelectCategory.FormattingEnabled = True
        Me.cboSelectCategory.Items.AddRange(New Object() {"Select Category", "Beverages", "Fruits", "Babies"})
        Me.cboSelectCategory.Location = New System.Drawing.Point(251, 133)
        Me.cboSelectCategory.Name = "cboSelectCategory"
        Me.cboSelectCategory.Size = New System.Drawing.Size(121, 21)
        Me.cboSelectCategory.TabIndex = 13
        '
        'lblCategory
        '
        Me.lblCategory.AutoSize = True
        Me.lblCategory.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblCategory.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCategory.Location = New System.Drawing.Point(156, 136)
        Me.lblCategory.Name = "lblCategory"
        Me.lblCategory.Size = New System.Drawing.Size(63, 15)
        Me.lblCategory.TabIndex = 14
        Me.lblCategory.Text = "Category:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(663, 640)
        Me.Controls.Add(Me.lblCategory)
        Me.Controls.Add(Me.cboSelectCategory)
        Me.Controls.Add(Me.grpCustomerDetails)
        Me.Controls.Add(Me.lstDisplay)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.grpBabies)
        Me.Controls.Add(Me.grpFruit)
        Me.Controls.Add(Me.grpBeverage)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.btnClear)
        Me.Name = "Form1"
        Me.Text = "Kareems Superette"
        Me.grpBeverage.ResumeLayout(False)
        Me.grpBeverage.PerformLayout()
        Me.grpFruit.ResumeLayout(False)
        Me.grpFruit.PerformLayout()
        Me.grpBabies.ResumeLayout(False)
        Me.grpBabies.PerformLayout()
        Me.grpCustomerDetails.ResumeLayout(False)
        Me.grpCustomerDetails.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnClear As Button
    Friend WithEvents btnCalculate As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents grpBeverage As GroupBox
    Friend WithEvents grpFruit As GroupBox
    Friend WithEvents grpBabies As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents radJuice As RadioButton
    Friend WithEvents radSpringWater As RadioButton
    Friend WithEvents radFizzyDrink As RadioButton
    Friend WithEvents radMango As RadioButton
    Friend WithEvents radOrange As RadioButton
    Friend WithEvents radApple As RadioButton
    Friend WithEvents radPacifier As RadioButton
    Friend WithEvents radNappies As RadioButton
    Friend WithEvents radFormula As RadioButton
    Friend WithEvents lstDisplay As ListBox
    Friend WithEvents grpCustomerDetails As GroupBox
    Friend WithEvents lblCustomerSurname As Label
    Friend WithEvents lblCustomerDetails As Label
    Friend WithEvents txtCustomerSurname As TextBox
    Friend WithEvents txtCustomerName As TextBox
    Friend WithEvents cboSelectCategory As ComboBox
    Friend WithEvents txtQuantity As TextBox
    Friend WithEvents lblQuantity As Label
    Friend WithEvents lblCategory As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtCustomerNo As TextBox
    Friend WithEvents Label3 As Label
End Class
