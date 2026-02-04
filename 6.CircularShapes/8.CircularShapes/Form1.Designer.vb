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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtRadius = New System.Windows.Forms.TextBox()
        Me.txtHeight = New System.Windows.Forms.TextBox()
        Me.rdoSphere = New System.Windows.Forms.RadioButton()
        Me.rdoCylinder = New System.Windows.Forms.RadioButton()
        Me.rdoCone = New System.Windows.Forms.RadioButton()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lblVolume = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Radius"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Height"
        '
        'txtRadius
        '
        Me.txtRadius.Location = New System.Drawing.Point(87, 9)
        Me.txtRadius.Name = "txtRadius"
        Me.txtRadius.Size = New System.Drawing.Size(100, 20)
        Me.txtRadius.TabIndex = 1
        '
        'txtHeight
        '
        Me.txtHeight.Location = New System.Drawing.Point(87, 40)
        Me.txtHeight.Name = "txtHeight"
        Me.txtHeight.Size = New System.Drawing.Size(100, 20)
        Me.txtHeight.TabIndex = 2
        '
        'rdoSphere
        '
        Me.rdoSphere.AutoSize = True
        Me.rdoSphere.Location = New System.Drawing.Point(31, 75)
        Me.rdoSphere.Name = "rdoSphere"
        Me.rdoSphere.Size = New System.Drawing.Size(59, 17)
        Me.rdoSphere.TabIndex = 3
        Me.rdoSphere.TabStop = True
        Me.rdoSphere.Text = "Sphere"
        Me.rdoSphere.UseVisualStyleBackColor = True
        '
        'rdoCylinder
        '
        Me.rdoCylinder.AutoSize = True
        Me.rdoCylinder.Location = New System.Drawing.Point(103, 75)
        Me.rdoCylinder.Name = "rdoCylinder"
        Me.rdoCylinder.Size = New System.Drawing.Size(62, 17)
        Me.rdoCylinder.TabIndex = 4
        Me.rdoCylinder.TabStop = True
        Me.rdoCylinder.Text = "Cylinder"
        Me.rdoCylinder.UseVisualStyleBackColor = True
        '
        'rdoCone
        '
        Me.rdoCone.AutoSize = True
        Me.rdoCone.Location = New System.Drawing.Point(171, 75)
        Me.rdoCone.Name = "rdoCone"
        Me.rdoCone.Size = New System.Drawing.Size(50, 17)
        Me.rdoCone.TabIndex = 5
        Me.rdoCone.TabStop = True
        Me.rdoCone.Text = "Cone"
        Me.rdoCone.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Volume"
        '
        'lblVolume
        '
        Me.lblVolume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblVolume.Location = New System.Drawing.Point(87, 108)
        Me.lblVolume.Name = "lblVolume"
        Me.lblVolume.Size = New System.Drawing.Size(100, 23)
        Me.lblVolume.TabIndex = 7
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(5, 146)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(75, 23)
        Me.btnCalculate.TabIndex = 8
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(86, 146)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(54, 23)
        Me.btnClear.TabIndex = 9
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(146, 146)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(245, 181)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblVolume)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rdoCone)
        Me.Controls.Add(Me.rdoCylinder)
        Me.Controls.Add(Me.rdoSphere)
        Me.Controls.Add(Me.txtHeight)
        Me.Controls.Add(Me.txtRadius)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtRadius As TextBox
    Friend WithEvents txtHeight As TextBox
    Friend WithEvents rdoSphere As RadioButton
    Friend WithEvents rdoCylinder As RadioButton
    Friend WithEvents rdoCone As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents lblVolume As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnExit As Button
End Class
