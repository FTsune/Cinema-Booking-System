<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BackBtn = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(278, 103)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(155, 56)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Search Movies"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(278, 191)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 56)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "Add Movies"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(278, 274)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(155, 56)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "Edit Movies"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic UI", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(82, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(534, 56)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "What would you like to do?"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'BackBtn
        '
        Me.BackBtn.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.BackBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.BackBtn.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BackBtn.ForeColor = System.Drawing.Color.Red
        Me.BackBtn.LinkColor = System.Drawing.Color.White
        Me.BackBtn.Location = New System.Drawing.Point(278, 355)
        Me.BackBtn.Name = "BackBtn"
        Me.BackBtn.Size = New System.Drawing.Size(155, 28)
        Me.BackBtn.TabIndex = 44
        Me.BackBtn.TabStop = True
        Me.BackBtn.Text = "Log out"
        Me.BackBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cinema_Booking_System.My.Resources.Resources.moviewall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(711, 431)
        Me.Controls.Add(Me.BackBtn)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form5"
        Me.Text = "Hello"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents BackBtn As LinkLabel
End Class
