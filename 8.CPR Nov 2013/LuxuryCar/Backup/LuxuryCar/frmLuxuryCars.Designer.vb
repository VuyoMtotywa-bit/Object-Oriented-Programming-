<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLuxuryCars
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpDetails = New System.Windows.Forms.GroupBox
        Me.txtContact = New System.Windows.Forms.TextBox
        Me.txtSurname = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.txtName = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.grpCarHire = New System.Windows.Forms.GroupBox
        Me.txtNoDays = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.radMiniBus = New System.Windows.Forms.RadioButton
        Me.radPrivateCar = New System.Windows.Forms.RadioButton
        Me.btnCompute = New System.Windows.Forms.Button
        Me.btnClear = New System.Windows.Forms.Button
        Me.btnExit = New System.Windows.Forms.Button
        Me.Label6 = New System.Windows.Forms.Label
        Me.lblAmountPayable = New System.Windows.Forms.Label
        Me.grpDetails.SuspendLayout()
        Me.grpCarHire.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(296, 31)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LUXURY LIFE STYLE CAR HIRE"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpDetails
        '
        Me.grpDetails.Controls.Add(Me.txtContact)
        Me.grpDetails.Controls.Add(Me.txtSurname)
        Me.grpDetails.Controls.Add(Me.Label4)
        Me.grpDetails.Controls.Add(Me.txtName)
        Me.grpDetails.Controls.Add(Me.Label3)
        Me.grpDetails.Controls.Add(Me.Label2)
        Me.grpDetails.Location = New System.Drawing.Point(12, 43)
        Me.grpDetails.Name = "grpDetails"
        Me.grpDetails.Size = New System.Drawing.Size(297, 124)
        Me.grpDetails.TabIndex = 1
        Me.grpDetails.TabStop = False
        Me.grpDetails.Text = "Client Details:"
        '
        'txtContact
        '
        Me.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtContact.Location = New System.Drawing.Point(90, 85)
        Me.txtContact.Name = "txtContact"
        Me.txtContact.Size = New System.Drawing.Size(192, 26)
        Me.txtContact.TabIndex = 2
        '
        'txtSurname
        '
        Me.txtSurname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtSurname.Location = New System.Drawing.Point(90, 53)
        Me.txtSurname.Name = "txtSurname"
        Me.txtSurname.Size = New System.Drawing.Size(192, 26)
        Me.txtSurname.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 18)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Contact No:"
        '
        'txtName
        '
        Me.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtName.Location = New System.Drawing.Point(90, 21)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(192, 26)
        Me.txtName.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 55)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Surname:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 18)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Name:"
        '
        'grpCarHire
        '
        Me.grpCarHire.Controls.Add(Me.txtNoDays)
        Me.grpCarHire.Controls.Add(Me.Label5)
        Me.grpCarHire.Controls.Add(Me.radMiniBus)
        Me.grpCarHire.Controls.Add(Me.radPrivateCar)
        Me.grpCarHire.Location = New System.Drawing.Point(12, 169)
        Me.grpCarHire.Name = "grpCarHire"
        Me.grpCarHire.Size = New System.Drawing.Size(297, 85)
        Me.grpCarHire.TabIndex = 2
        Me.grpCarHire.TabStop = False
        Me.grpCarHire.Text = "Car Hire:"
        '
        'txtNoDays
        '
        Me.txtNoDays.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtNoDays.Location = New System.Drawing.Point(120, 46)
        Me.txtNoDays.Name = "txtNoDays"
        Me.txtNoDays.Size = New System.Drawing.Size(100, 26)
        Me.txtNoDays.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(109, 18)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Number of days:"
        '
        'radMiniBus
        '
        Me.radMiniBus.AutoSize = True
        Me.radMiniBus.Location = New System.Drawing.Point(107, 18)
        Me.radMiniBus.Name = "radMiniBus"
        Me.radMiniBus.Size = New System.Drawing.Size(78, 22)
        Me.radMiniBus.TabIndex = 1
        Me.radMiniBus.TabStop = True
        Me.radMiniBus.Text = "Mini-Bus"
        Me.radMiniBus.UseVisualStyleBackColor = True
        '
        'radPrivateCar
        '
        Me.radPrivateCar.AutoSize = True
        Me.radPrivateCar.Location = New System.Drawing.Point(8, 18)
        Me.radPrivateCar.Name = "radPrivateCar"
        Me.radPrivateCar.Size = New System.Drawing.Size(93, 22)
        Me.radPrivateCar.TabIndex = 0
        Me.radPrivateCar.TabStop = True
        Me.radPrivateCar.Text = "Private Car"
        Me.radPrivateCar.UseVisualStyleBackColor = True
        '
        'btnCompute
        '
        Me.btnCompute.Location = New System.Drawing.Point(12, 298)
        Me.btnCompute.Name = "btnCompute"
        Me.btnCompute.Size = New System.Drawing.Size(85, 26)
        Me.btnCompute.TabIndex = 3
        Me.btnCompute.Text = "C&ompute"
        Me.btnCompute.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(118, 298)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(85, 26)
        Me.btnClear.TabIndex = 4
        Me.btnClear.Text = "&Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExit.Location = New System.Drawing.Point(224, 298)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 26)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(90, 266)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(107, 18)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Amount Payable:"
        '
        'lblAmountPayable
        '
        Me.lblAmountPayable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblAmountPayable.Location = New System.Drawing.Point(209, 263)
        Me.lblAmountPayable.Name = "lblAmountPayable"
        Me.lblAmountPayable.Size = New System.Drawing.Size(100, 26)
        Me.lblAmountPayable.TabIndex = 9
        Me.lblAmountPayable.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmLuxuryCars
        '
        Me.AcceptButton = Me.btnCompute
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btnExit
        Me.ClientSize = New System.Drawing.Size(322, 335)
        Me.Controls.Add(Me.lblAmountPayable)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCompute)
        Me.Controls.Add(Me.grpCarHire)
        Me.Controls.Add(Me.grpDetails)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmLuxuryCars"
        Me.Text = "Luxury Cars"
        Me.grpDetails.ResumeLayout(False)
        Me.grpDetails.PerformLayout()
        Me.grpCarHire.ResumeLayout(False)
        Me.grpCarHire.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpDetails As System.Windows.Forms.GroupBox
    Friend WithEvents txtContact As System.Windows.Forms.TextBox
    Friend WithEvents txtSurname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents grpCarHire As System.Windows.Forms.GroupBox
    Friend WithEvents radMiniBus As System.Windows.Forms.RadioButton
    Friend WithEvents radPrivateCar As System.Windows.Forms.RadioButton
    Friend WithEvents btnCompute As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents lblAmountPayable As System.Windows.Forms.Label
    Friend WithEvents txtNoDays As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
