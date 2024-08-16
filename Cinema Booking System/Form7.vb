Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form7
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent
        Label5.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent
        Label9.BackColor = System.Drawing.Color.Transparent
        BackBtn.BackColor = System.Drawing.Color.Transparent
        LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Label10.BackColor = System.Drawing.Color.Transparent
        Label11.BackColor = System.Drawing.Color.Transparent
        MaximizeBox = False

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server

        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cinema.movie"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Dim title = READER.GetString("title")
                ComboBox1.Items.Add(title)
            End While

            MysqlConn.Close()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
    Private Sub Form7_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cinema.movie where title = '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                Title.Text = READER.GetString("title")
                Company.Text = READER.GetString("company")
                Producer.Text = READER.GetString("producer")
                Director.Text = READER.GetString("director")
                GenreBox.Text = READER.GetString("genre")
                Casts.Text = READER.GetString("casts")
                DateTimePicker1.Value = READER.GetDateTime("date")
                TextBox1.Text = READER.GetString("picture")
                Tickets.Text = READER.GetInt16("ticket")
                Pricetxt.Text = READER.GetInt16("price")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub UpBtn_Click(sender As Object, e As EventArgs) Handles UpBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server

        Dim READER As MySqlDataReader

        If Title.Text = "" Or Director.Text = "" Or GenreBox.Text = "" Or Company.Text = "" Or Producer.Text = "" Or Casts.Text = "" Or TextBox1.Text = "" Or Tickets.Text = "" Or Pricetxt.Text = "" Then
            MessageBox.Show("Please fill required fields")
            Exit Sub
        ElseIf Title.Text.Trim.Length > 0 And Director.Text.Trim.Length > 0 And GenreBox.Text.Trim.Length > 0 And Company.Text.Trim.Length > 0 And Producer.Text.Trim.Length > 0 And Casts.Text.Trim.Length > 0 And TextBox1.Text.Trim.Length > 0 And Tickets.Text.Trim.Length > 0 Then

        End If

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update cinema.movie set title='" & Title.Text & "',company='" & Company.Text & "',producer='" & Producer.Text & "',director='" & Director.Text & "',genre='" & GenreBox.Text & "', casts='" & Casts.Text & "', date='" + DateTimePicker1.Value.Date.ToString("yyyyMMdd") + "', picture='" & TextBox1.Text & "', ticket='" & Tickets.Text & "', price='" & Pricetxt.Text & "' where title= '" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Movie updated.")
            Me.Controls.Clear()
            InitializeComponent()
            Form7_Load(e, e)
            MysqlConn.Close()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub delBtn_Click(sender As Object, e As EventArgs) Handles delBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server

        Dim READER As MySqlDataReader
        If Title.Text = "" Or Director.Text = "" Or GenreBox.Text = "" Or Company.Text = "" Or Producer.Text = "" Or Casts.Text = "" Or TextBox1.Text = "" Or Tickets.Text = "" Or Pricetxt.Text = "" Then
            MessageBox.Show("Please fill required fields")
            Exit Sub
        ElseIf Title.Text.Trim.Length > 0 And Director.Text.Trim.Length > 0 And GenreBox.Text.Trim.Length > 0 And Company.Text.Trim.Length > 0 And Producer.Text.Trim.Length > 0 And Casts.Text.Trim.Length > 0 And TextBox1.Text.Trim.Length > 0 And Tickets.Text.Trim.Length > 0 Then

        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "Delete from cinema.movie where title='" & ComboBox1.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Movie deleted.")
            ComboBox1.Text = Nothing
            Title.Clear()
            Director.Clear()
            Company.Clear()
            Producer.Clear()
            GenreBox.Clear()
            Casts.Clear()
            Me.Controls.Clear()
            InitializeComponent()
            Form7_Load(e, e)
            MysqlConn.Close()

            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub BackBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BackBtn.LinkClicked
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IO.File.Exists(TextBox1.Text) Then
            PictureBox1.ImageLocation = TextBox1.Text
            PictureBox1.Load()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image(*.jpg;*.png;*.gif)|*.jpg;*.png;*.gif"

        If opf.ShowDialog = DialogResult.OK Then

            PictureBox1.Image = Image.FromFile(opf.FileName)
            opf.FileName.Replace("\\", "\\\\")
            Me.TextBox1.Text = opf.FileName

        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Controls.Clear()
        InitializeComponent()
        Form7_Load(e, e)
        MysqlConn.Close()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel3.LinkClicked
        If TextBox1.Text.Contains("\") Then
            TextBox1.Text = TextBox1.Text.Replace("\", "\\")
        End If
    End Sub
End Class