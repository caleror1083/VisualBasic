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
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnMessage = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.txtAddVal1 = New System.Windows.Forms.TextBox()
        Me.btnAddValues = New System.Windows.Forms.Button()
        Me.txtAddVal2 = New System.Windows.Forms.TextBox()
        Me.lblAddEqual = New System.Windows.Forms.Label()
        Me.txtSumAnswer = New System.Windows.Forms.TextBox()
        Me.txtDivisionAnswer = New System.Windows.Forms.TextBox()
        Me.lblDivideEqual = New System.Windows.Forms.Label()
        Me.txtDivideVal2 = New System.Windows.Forms.TextBox()
        Me.btnDivideValues = New System.Windows.Forms.Button()
        Me.txtDivideVal1 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.btnUpdate = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(13, 13)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(35, 13)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(54, 10)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(208, 20)
        Me.txtName.TabIndex = 1
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(16, 43)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "&OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnMessage
        '
        Me.btnMessage.Location = New System.Drawing.Point(101, 43)
        Me.btnMessage.Name = "btnMessage"
        Me.btnMessage.Size = New System.Drawing.Size(75, 23)
        Me.btnMessage.TabIndex = 3
        Me.btnMessage.Text = "&Message"
        Me.btnMessage.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(187, 43)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(75, 23)
        Me.btnExit.TabIndex = 4
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'txtAddVal1
        '
        Me.txtAddVal1.Location = New System.Drawing.Point(16, 75)
        Me.txtAddVal1.Name = "txtAddVal1"
        Me.txtAddVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal1.TabIndex = 5
        '
        'btnAddValues
        '
        Me.btnAddValues.Location = New System.Drawing.Point(77, 73)
        Me.btnAddValues.Name = "btnAddValues"
        Me.btnAddValues.Size = New System.Drawing.Size(23, 23)
        Me.btnAddValues.TabIndex = 6
        Me.btnAddValues.Text = "+"
        Me.btnAddValues.UseVisualStyleBackColor = True
        '
        'txtAddVal2
        '
        Me.txtAddVal2.Location = New System.Drawing.Point(106, 75)
        Me.txtAddVal2.Name = "txtAddVal2"
        Me.txtAddVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtAddVal2.TabIndex = 7
        '
        'lblAddEqual
        '
        Me.lblAddEqual.AutoSize = True
        Me.lblAddEqual.Location = New System.Drawing.Point(167, 78)
        Me.lblAddEqual.Name = "lblAddEqual"
        Me.lblAddEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblAddEqual.TabIndex = 8
        Me.lblAddEqual.Text = "="
        '
        'txtSumAnswer
        '
        Me.txtSumAnswer.Enabled = False
        Me.txtSumAnswer.Location = New System.Drawing.Point(186, 75)
        Me.txtSumAnswer.Name = "txtSumAnswer"
        Me.txtSumAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtSumAnswer.TabIndex = 9
        '
        'txtDivisionAnswer
        '
        Me.txtDivisionAnswer.Enabled = False
        Me.txtDivisionAnswer.Location = New System.Drawing.Point(186, 102)
        Me.txtDivisionAnswer.Name = "txtDivisionAnswer"
        Me.txtDivisionAnswer.Size = New System.Drawing.Size(55, 20)
        Me.txtDivisionAnswer.TabIndex = 14
        '
        'lblDivideEqual
        '
        Me.lblDivideEqual.AutoSize = True
        Me.lblDivideEqual.Location = New System.Drawing.Point(167, 105)
        Me.lblDivideEqual.Name = "lblDivideEqual"
        Me.lblDivideEqual.Size = New System.Drawing.Size(13, 13)
        Me.lblDivideEqual.TabIndex = 13
        Me.lblDivideEqual.Text = "="
        '
        'txtDivideVal2
        '
        Me.txtDivideVal2.Location = New System.Drawing.Point(106, 102)
        Me.txtDivideVal2.Name = "txtDivideVal2"
        Me.txtDivideVal2.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal2.TabIndex = 12
        '
        'btnDivideValues
        '
        Me.btnDivideValues.Location = New System.Drawing.Point(77, 100)
        Me.btnDivideValues.Name = "btnDivideValues"
        Me.btnDivideValues.Size = New System.Drawing.Size(23, 23)
        Me.btnDivideValues.TabIndex = 11
        Me.btnDivideValues.Text = "/"
        Me.btnDivideValues.UseVisualStyleBackColor = True
        '
        'txtDivideVal1
        '
        Me.txtDivideVal1.Location = New System.Drawing.Point(16, 102)
        Me.txtDivideVal1.Name = "txtDivideVal1"
        Me.txtDivideVal1.Size = New System.Drawing.Size(55, 20)
        Me.txtDivideVal1.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(16, 129)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(246, 162)
        Me.TextBox1.TabIndex = 15
        '
        'btnUpdate
        '
        Me.btnUpdate.Location = New System.Drawing.Point(16, 297)
        Me.btnUpdate.Name = "btnUpdate"
        Me.btnUpdate.Size = New System.Drawing.Size(75, 23)
        Me.btnUpdate.TabIndex = 0
        Me.btnUpdate.Text = "Update"
        Me.btnUpdate.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(274, 327)
        Me.Controls.Add(Me.btnUpdate)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.txtDivisionAnswer)
        Me.Controls.Add(Me.lblDivideEqual)
        Me.Controls.Add(Me.txtDivideVal2)
        Me.Controls.Add(Me.btnDivideValues)
        Me.Controls.Add(Me.txtDivideVal1)
        Me.Controls.Add(Me.txtSumAnswer)
        Me.Controls.Add(Me.lblAddEqual)
        Me.Controls.Add(Me.txtAddVal2)
        Me.Controls.Add(Me.btnAddValues)
        Me.Controls.Add(Me.txtAddVal1)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnMessage)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Name = "Form1"
        Me.Text = "VB Tutorial"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents btnOK As Button
    Friend WithEvents btnMessage As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents txtAddVal1 As TextBox
    Friend WithEvents btnAddValues As Button
    Friend WithEvents txtAddVal2 As TextBox
    Friend WithEvents lblAddEqual As Label
    Friend WithEvents txtSumAnswer As TextBox
    Friend WithEvents txtDivisionAnswer As TextBox
    Friend WithEvents lblDivideEqual As Label
    Friend WithEvents txtDivideVal2 As TextBox
    Friend WithEvents btnDivideValues As Button
    Friend WithEvents txtDivideVal1 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btnUpdate As Button
End Class
