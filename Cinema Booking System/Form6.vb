Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form6
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Dim filename As String
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent
        Label5.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent
        Label9.BackColor = System.Drawing.Color.Transparent
        Label10.BackColor = System.Drawing.Color.Transparent
        errormsg.BackColor = System.Drawing.Color.Transparent
        MaximizeBox = False
        errormsg.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)
            Me.TextBox1.Text = opf.FileName
        End If
        opf.FileName.Replace("\\", "\\\\")
    End Sub
    Private Sub Form6_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub SaveBtn_Click(sender As Object, e As EventArgs) Handles SaveBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader

        If Title.Text = "" Or Director.Text = "" Or GenreBox.Text = "" Or Company.Text = "" Or Producer.Text = "" Or Casts.Text = "" Or TextBox1.Text = "" Or Tickets.Text = "" Or Pricetxt.Text = "" Then
            errormsg.Show()
            Exit Sub
        ElseIf Title.Text.Trim.Length > 0 And Director.Text.Trim.Length > 0 And GenreBox.Text.Trim.Length > 0 And Company.Text.Trim.Length > 0 And Producer.Text.Trim.Length > 0 And Casts.Text.Trim.Length > 0 And TextBox1.Text.Trim.Length > 0 And Tickets.Text.Trim.Length > 0 Then
            errormsg.Hide()
        Else
            errormsg.Text = "Please complete required fields"
            errormsg.Visible = True
        End If

        Try
            MysqlConn.Open()
            Dim opf As New OpenFileDialog
            Dim Query As String
            Query = "insert into cinema.movie (title, company, producer, director, genre, casts, date, picture, ticket, price) values ('" & Title.Text & "', '" & Company.Text & "', '" & Producer.Text & "', '" & Director.Text & "', '" & GenreBox.Text & "', '" & Casts.Text & "', '" + DateTimePicker1.Value.Date.ToString("yyyyMMdd") + "', '" + TextBox1.Text.Replace("\\", "\\\\") + "', '" & Tickets.Text & "', '" & Pricetxt.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0
            If count = 1 Then
                errormsg.Text = "Failed to add movie. Please try again."
            Else
                'TextBox1.Text.Replace("\\", "\\\\")
                MessageBox.Show("Movie added successfully!")
                Me.Controls.Clear()
                InitializeComponent()
                Form6_Load(e, e)
                MysqlConn.Close()
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If TextBox1.Text.Contains("\") Then
            TextBox1.Text = TextBox1.Text.Replace("\", "\\")
        End If
    End Sub
End Class