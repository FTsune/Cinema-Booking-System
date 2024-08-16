<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form9
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Title = New System.Windows.Forms.Label()
        Me.Qtytxt = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Tprice = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.cash = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.change = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.nameBox = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustomInstaller1 = New MySql.Data.MySqlClient.CustomInstaller()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.datetxt = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Sdate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(99, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(287, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "UNCIANOOD CINEMA BOOKING"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 189)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(112, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MOVIE TITLE"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(307, 189)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "QTY"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(405, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "PRICE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 86)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(162, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CUSTOMER NAME:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(-7, 169)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(513, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "---------------------------------------------------------------------------------" &
    "---"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(-7, 209)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(561, 20)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "---------------------------------------------------------------------------------" &
    "-----------"
        '
        'Title
        '
        Me.Title.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Title.Location = New System.Drawing.Point(22, 229)
        Me.Title.Name = "Title"
        Me.Title.Size = New System.Drawing.Size(247, 47)
        Me.Title.TabIndex = 7
        Me.Title.Text = "Title"
        '
        'Qtytxt
        '
        Me.Qtytxt.AutoSize = True
        Me.Qtytxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Qtytxt.Location = New System.Drawing.Point(307, 229)
        Me.Qtytxt.Name = "Qtytxt"
        Me.Qtytxt.Size = New System.Drawing.Size(35, 20)
        Me.Qtytxt.TabIndex = 8
        Me.Qtytxt.Text = "Qty"
        '
        'Price
        '
        Me.Price.AutoSize = True
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(405, 229)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(48, 20)
        Me.Price.TabIndex = 9
        Me.Price.Text = "Price"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(-7, 323)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(543, 20)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "---------------------------------------------------------------------------------" &
    "--------"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(22, 343)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(166, 20)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "TOTAL BALANCE:"
        '
        'Tprice
        '
        Me.Tprice.AutoSize = True
        Me.Tprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Tprice.Location = New System.Drawing.Point(405, 343)
        Me.Tprice.Name = "Tprice"
        Me.Tprice.Size = New System.Drawing.Size(53, 20)
        Me.Tprice.TabIndex = 14
        Me.Tprice.Text = "Price"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(22, 389)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(66, 20)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "CASH:"
        '
        'cash
        '
        Me.cash.AutoSize = True
        Me.cash.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cash.Location = New System.Drawing.Point(405, 389)
        Me.cash.Name = "cash"
        Me.cash.Size = New System.Drawing.Size(49, 20)
        Me.cash.TabIndex = 16
        Me.cash.Text = "cash"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(-7, 409)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(573, 20)
        Me.Label18.TabIndex = 17
        Me.Label18.Text = "---------------------------------------------------------------------------------" &
    "-------------"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(22, 429)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(93, 20)
        Me.Label19.TabIndex = 18
        Me.Label19.Text = "CHANGE:"
        '
        'change
        '
        Me.change.AutoSize = True
        Me.change.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.change.Location = New System.Drawing.Point(405, 429)
        Me.change.Name = "change"
        Me.change.Size = New System.Drawing.Size(72, 20)
        Me.change.TabIndex = 19
        Me.change.Text = "Change"
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(72, 513)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(332, 65)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "THANK YOU FOR TRUSTING UNCIANOOD CINEMA BOOKING!"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'nameBox
        '
        Me.nameBox.AutoSize = True
        Me.nameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nameBox.Location = New System.Drawing.Point(205, 86)
        Me.nameBox.Name = "nameBox"
        Me.nameBox.Size = New System.Drawing.Size(53, 20)
        Me.nameBox.TabIndex = 21
        Me.nameBox.Text = "Name"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(385, 581)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(22, 115)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "DATE:"
        '
        'datetxt
        '
        Me.datetxt.AutoSize = True
        Me.datetxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.datetxt.Location = New System.Drawing.Point(99, 115)
        Me.datetxt.Name = "datetxt"
        Me.datetxt.Size = New System.Drawing.Size(41, 20)
        Me.datetxt.TabIndex = 24
        Me.datetxt.Text = "date"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(22, 473)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 20)
        Me.Label9.TabIndex = 25
        Me.Label9.Text = "VALID ON:"
        '
        'Sdate
        '
        Me.Sdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Sdate.Location = New System.Drawing.Point(311, 473)
        Me.Sdate.Name = "Sdate"
        Me.Sdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Sdate.Size = New System.Drawing.Size(166, 20)
        Me.Sdate.TabIndex = 26
        Me.Sdate.Text = "ShowDate"
        '
        'Form9
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 646)
        Me.Controls.Add(Me.Sdate)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.datetxt)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.nameBox)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.change)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.cash)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Tprice)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Qtytxt)
        Me.Controls.Add(Me.Title)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form9"
        Me.Text = "Form9"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Title As Label
    Friend WithEvents Qtytxt As Label
    Friend WithEvents Price As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Tprice As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents cash As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents change As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents nameBox As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents CustomInstaller1 As MySql.Data.MySqlClient.CustomInstaller
    Friend WithEvents Label8 As Label
    Friend WithEvents datetxt As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Sdate As Label
End Class
