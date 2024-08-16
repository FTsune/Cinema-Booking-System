<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form4
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.errormsg = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.loginBtn = New System.Windows.Forms.Button()
        Me.TextBoxUN = New System.Windows.Forms.TextBox()
        Me.BackBtn = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'errormsg
        '
        Me.errormsg.AutoSize = True
        Me.errormsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.errormsg.Font = New System.Drawing.Font("Comic Sans MS", 7.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errormsg.ForeColor = System.Drawing.Color.Red
        Me.errormsg.Location = New System.Drawing.Point(77, 293)
        Me.errormsg.Name = "errormsg"
        Me.errormsg.Size = New System.Drawing.Size(0, 17)
        Me.errormsg.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(86, 45)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(187, 100)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "ADMIN PORTAL"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label3.Location = New System.Drawing.Point(78, 243)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label2.Location = New System.Drawing.Point(78, 172)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Username"
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox2.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.White
        Me.TextBox2.Location = New System.Drawing.Point(77, 265)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TextBox2.Size = New System.Drawing.Size(196, 25)
        Me.TextBox2.TabIndex = 33
        '
        'loginBtn
        '
        Me.loginBtn.BackColor = System.Drawing.Color.White
        Me.loginBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.loginBtn.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginBtn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.loginBtn.Location = New System.Drawing.Point(186, 316)
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Size = New System.Drawing.Size(87, 28)
        Me.loginBtn.TabIndex = 32
        Me.loginBtn.Text = "Log-in"
        Me.loginBtn.UseVisualStyleBackColor = False
        '
        'TextBoxUN
        '
        Me.TextBoxUN.BackColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.TextBoxUN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBoxUN.Font = New System.Drawing.Font("Ebrima", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBoxUN.ForeColor = System.Drawing.Color.White
        Me.TextBoxUN.Location = New System.Drawing.Point(77, 194)
        Me.TextBoxUN.Name = "TextBoxUN"
        Me.TextBoxUN.Size = New System.Drawing.Size(196, 25)
        Me.TextBoxUN.TabIndex = 30
        '
        'BackBtn
        '
        Me.BackBtn.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BackBtn.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.Red
        Me.BackBtn.LinkColor = System.Drawing.Color.Red
        Me.BackBtn.Location = New System.Drawing.Point(206, 442)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(121, 28)
        Me.BackBtn.TabIndex = 43
        Me.BackBtn.TabStop = True
        Me.BackBtn.Text = "Go Back"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cinema_Booking_System.My.Resources.Resources.foradmin
        Me.ClientSize = New System.Drawing.Size(339, 526)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.errormsg)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.TextBoxUN)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.Text = "Admin Portal"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents errormsg As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents loginBtn As Button
    Friend WithEvents TextBoxUN As TextBox
    Friend WithEvents BackBtn As LinkLabel
End Class
