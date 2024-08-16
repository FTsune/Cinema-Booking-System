<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Title = New System.Windows.Forms.TextBox()
        Me.Director = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SaveBtn = New System.Windows.Forms.Button()
        Me.errormsg = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Company = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Producer = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Casts = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GenreBox = New System.Windows.Forms.ComboBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Tickets = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Pricetxt = New System.Windows.Forms.TextBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Yu Gothic Medium", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(171, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(376, 36)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Enter Movie Details"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Title
        '
        Me.Title.Location = New System.Drawing.Point(64, 117)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(244, 22)
        Me.Title.TabIndex = 18
        '
        'Director
        '
        Me.Director.Location = New System.Drawing.Point(64, 314)
        Me.Director.Name = "Director"
        Me.Director.Size = New System.Drawing.Size(244, 22)
        Me.Director.TabIndex = 19
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(60, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 23)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Title"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label3.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(60, 288)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 23)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Director/s"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label4.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(60, 490)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(116, 23)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Date Showing"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label5.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(60, 353)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 23)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "Genre"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(64, 516)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(244, 22)
        Me.DateTimePicker1.TabIndex = 26
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(414, 117)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(235, 354)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 27
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(529, 505)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 31)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Add Picture"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SaveBtn
        '
        Me.SaveBtn.Location = New System.Drawing.Point(203, 577)
        Me.SaveBtn.Name = "SaveBtn"
        Me.SaveBtn.Size = New System.Drawing.Size(105, 33)
        Me.SaveBtn.TabIndex = 29
        Me.SaveBtn.Text = "Save Movie"
        Me.SaveBtn.UseVisualStyleBackColor = True
        '
        'errormsg
        '
        Me.errormsg.AutoSize = True
        Me.errormsg.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(39, Byte), Integer), CType(CType(46, Byte), Integer))
        Me.errormsg.Font = New System.Drawing.Font("Comic Sans MS", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.errormsg.ForeColor = System.Drawing.Color.Red
        Me.errormsg.Location = New System.Drawing.Point(60, 541)
        Me.errormsg.Name = "errormsg"
        Me.errormsg.Size = New System.Drawing.Size(215, 19)
        Me.errormsg.TabIndex = 40
        Me.errormsg.Text = "Please complete required fields"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label6.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(60, 156)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(83, 23)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "Company"
        '
        'Company
        '
        Me.Company.Location = New System.Drawing.Point(64, 182)
        Me.Company.Name = "Company"
        Me.Company.Size = New System.Drawing.Size(244, 22)
        Me.Company.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label7.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(60, 222)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 23)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "Producer/s"
        '
        'Producer
        '
        Me.Producer.Location = New System.Drawing.Point(64, 248)
        Me.Producer.Name = "Producer"
        Me.Producer.Size = New System.Drawing.Size(244, 22)
        Me.Producer.TabIndex = 44
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label8.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(60, 422)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(122, 23)
        Me.Label8.TabIndex = 45
        Me.Label8.Text = "Starring Cast/s"
        '
        'Casts
        '
        Me.Casts.Location = New System.Drawing.Point(64, 448)
        Me.Casts.Name = "Casts"
        Me.Casts.Size = New System.Drawing.Size(244, 22)
        Me.Casts.TabIndex = 46
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(64, 577)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(79, 33)
        Me.Button2.TabIndex = 47
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GenreBox
        '
        Me.GenreBox.FormattingEnabled = True
        Me.GenreBox.Items.AddRange(New Object() {"Horror", "Action", "Comedy", "Sci-fi", "Drama", "Romance", "Animation", "Adventure"})
        Me.GenreBox.Location = New System.Drawing.Point(64, 379)
        Me.GenreBox.Name = "GenreBox"
        Me.GenreBox.Size = New System.Drawing.Size(244, 24)
        Me.GenreBox.TabIndex = 48
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(414, 477)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(235, 22)
        Me.TextBox1.TabIndex = 49
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label9.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(410, 554)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(138, 23)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Tickets Available:"
        '
        'Tickets
        '
        Me.Tickets.Location = New System.Drawing.Point(563, 555)
        Me.Tickets.Name = "Tickets"
        Me.Tickets.Size = New System.Drawing.Size(86, 22)
        Me.Tickets.TabIndex = 51
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label10.Font = New System.Drawing.Font("Yu Gothic UI", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.White
        Me.Label10.Location = New System.Drawing.Point(410, 587)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(145, 23)
        Me.Label10.TabIndex = 52
        Me.Label10.Text = "Tickets Price:     ₱"
        '
        'Pricetxt
        '
        Me.Pricetxt.Location = New System.Drawing.Point(563, 589)
        Me.Pricetxt.Name = "Pricetxt"
        Me.Pricetxt.Size = New System.Drawing.Size(86, 22)
        Me.Pricetxt.TabIndex = 53
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Yu Gothic UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.ForeColor = System.Drawing.Color.Red
        Me.LinkLabel2.LinkColor = System.Drawing.Color.White
        Me.LinkLabel2.Location = New System.Drawing.Point(64, 646)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(244, 28)
        Me.LinkLabel2.TabIndex = 82
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Return to Login"
        Me.LinkLabel2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(CType(CType(245, Byte), Integer), CType(CType(59, Byte), Integer), CType(CType(87, Byte), Integer))
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Yu Gothic UI", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.Red
        Me.LinkLabel1.LinkColor = System.Drawing.Color.White
        Me.LinkLabel1.Location = New System.Drawing.Point(410, 511)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(81, 19)
        Me.LinkLabel1.TabIndex = 83
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Fix File Path"
        Me.LinkLabel1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Cinema_Booking_System.My.Resources.Resources.redblue
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(692, 695)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.Pricetxt)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Tickets)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GenreBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Casts)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Producer)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Company)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.errormsg)
        Me.Controls.Add(Me.SaveBtn)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Director)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form6"
        Me.Text = "Add Movie"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Title As TextBox
    Friend WithEvents Director As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Button1 As Button
    Friend WithEvents SaveBtn As Button
    Friend WithEvents errormsg As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Company As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Producer As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Casts As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents GenreBox As ComboBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Tickets As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Pricetxt As TextBox
    Friend WithEvents LinkLabel2 As LinkLabel
    Friend WithEvents LinkLabel1 As LinkLabel
End Class
