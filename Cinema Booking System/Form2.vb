Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports MySql.Data.MySqlClient
Public Class Form2
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Const server As String = "server=localhost;userid=root;database=cinema"

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label8.BackColor = System.Drawing.Color.Transparent
        Label1.BackColor = System.Drawing.Color.Transparent
        Title.BackColor = System.Drawing.Color.Transparent
        Company.BackColor = System.Drawing.Color.Transparent
        Genre.BackColor = System.Drawing.Color.Transparent
        datetxt.BackColor = System.Drawing.Color.Transparent
        Casts.BackColor = System.Drawing.Color.Transparent
        Label12.BackColor = System.Drawing.Color.Transparent
        Label13.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        ticket.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label12.Hide()
        load_data()
        DataGridView1.BorderStyle = BorderStyle.None
        DataGridView1.BackgroundColor = Color.Black
        DataGridView1.DefaultCellStyle.SelectionForeColor = Color.White
        textboxUN.ReadOnly = True
        passs.ReadOnly = True
        email.ReadOnly = True
        'editbtn.Visible = False
        savebtn.Visible = False
        cancelbtn.Visible = False
        delacc.Visible = False
        MaximizeBox = False
    End Sub
    Private Sub Form2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        textboxUN.ReadOnly = True
        passs.ReadOnly = True
        email.ReadOnly = True
        savebtn.Visible = False
        cancelbtn.Visible = False
        delacc.Visible = False
        textboxUN.Clear()
        passs.Clear()
        email.Clear()
        Form1.Show()
        Me.Hide()
        Exit Sub
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub
    Private Sub load_data()
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim SDA As New MySqlDataAdapter
        Dim bSource As New BindingSource
        Dim cnn As OleDbConnection = New OleDbConnection

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select title, company, producer, director, genre, casts, date, picture, ticket, price from cinema.movie"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            SDA.SelectCommand = COMMAND
            SDA.Fill(dbDataSet)
            bSource.DataSource = dbDataSet
            DataGridView1.DataSource = bSource
            SDA.Update(dbDataSet)

            MysqlConn.Close()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow
            row = Me.DataGridView1.Rows(e.RowIndex)

            Title.Text = row.Cells("title").Value.ToString
            Company.Text = row.Cells("company").Value.ToString
            'Producer.Text = row.Cells("producer").Value.ToString
            'Director.Text = row.Cells("director").Value.ToString
            Genre.Text = row.Cells("genre").Value.ToString
            Casts.Text = row.Cells("casts").Value.ToString
            datetxt.Text = row.Cells("date").Value.ToString
            Label12.Text = row.Cells("picture").Value.ToString
            ticket.Text = row.Cells("ticket").Value.ToString
            Label6.Text = row.Cells("price").Value.ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If IO.File.Exists(Label12.Text) Then
            PictureBox1.ImageLocation = Label12.Text
            PictureBox1.Load()
        End If
    End Sub
    Private Sub buybtn_Click(sender As Object, e As EventArgs) Handles buybtn.Click
        If ticket.Text = "" Then
            MessageBox.Show("Please choose a movie first :3", "Notice")
        Else
            Dim dt1 As DateTime = DateTime.Now
            Dim dt2 As DateTime = DateTime.Parse(datetxt.Text)

            If dt1 >= dt2 Then
                MsgBox("Oh no, '" & Title.Text & "' already showed!. Please wait for further announcement :)")
                Exit Sub
            End If
            If ticket.Text = 0 Then
                MessageBox.Show("Sorry, tickets are already sold out!")
                Exit Sub
            Else
                Form8.Show()
                Form8.Title.Text = Me.Title.Text
                Form8.ticket.Text = Me.ticket.Text
                Form8.price.Text = Me.Label6.Text
                'Me.Controls.Clear()
                'InitializeComponent()
                'Form2_Load(e, e)
                Me.Hide()
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles savebtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server

        Dim READER As MySqlDataReader

        If textboxUN.Text = "" Or passs.Text = "" Or email.Text = "" Then
            MessageBox.Show("Please fill up blank spaces.")
            Exit Sub
        End If
        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "update cinema.user set username='" & textboxUN.Text & "',password='" & passs.Text & "',email='" & email.Text & "' where username= '" & Label2.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader

            MessageBox.Show("Account Updated. Please Log-in again.")
            Me.Controls.Clear()
            InitializeComponent()
            Form2_Load(e, e)
            Me.Hide()
            Form1.Show()
            MysqlConn.Close()

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ShowBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ShowBtn.LinkClicked
        textboxUN.ReadOnly = False
        passs.ReadOnly = False
        email.ReadOnly = False
        'editbtn.Visible = True
        savebtn.Visible = True
        cancelbtn.Visible = True
        delacc.Visible = True

        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cinema.user where username  = '" & Label2.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            While READER.Read
                textboxUN.Text = READER.GetString("username")
                passs.Text = READER.GetString("password")
                email.Text = READER.GetString("email")
            End While

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
        Exit Sub
    End Sub

    Private Sub cancelbtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles cancelbtn.LinkClicked
        textboxUN.ReadOnly = True
        passs.ReadOnly = True
        email.ReadOnly = True
        'editbtn.Visible = False
        savebtn.Visible = False
        cancelbtn.Visible = False
        delacc.Visible = False
        textboxUN.Clear()
        passs.Clear()
        email.Clear()
        Exit Sub
    End Sub

    Private Sub delacc_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles delacc.LinkClicked
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader
        Dim result As DialogResult = MessageBox.Show("You cannot retrieve deleted account. Continue?", "Notice", MessageBoxButtons.YesNo)
        If result = DialogResult.No Then
            'MessageBox.Show("Cancelled")
            Exit Sub

        ElseIf result = DialogResult.Yes Then
            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "Delete from cinema.user where username='" & Label2.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                MessageBox.Show("Account Deleted")
                Me.Controls.Clear()
                InitializeComponent()
                Form2_Load(e, e)
                Form1.Show()
                Me.Hide()
                MysqlConn.Close()


            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class