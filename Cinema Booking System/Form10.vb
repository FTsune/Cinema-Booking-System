Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports System.Data
Imports System.Data.OleDb
Imports System.Data.Odbc
Imports System.Data.DataTable
Imports MySql.Data.MySqlClient
Public Class Form10
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Dim dbDataSet As New DataTable
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label4.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent
        Label9.BackColor = System.Drawing.Color.Transparent
        Director.BackColor = System.Drawing.Color.Transparent
        Producer.BackColor = System.Drawing.Color.Transparent
        Label12.BackColor = System.Drawing.Color.Transparent
        Label13.BackColor = System.Drawing.Color.Transparent
        Label14.BackColor = System.Drawing.Color.Transparent
        Label12.Hide()
        BackBtn.BackColor = System.Drawing.Color.Transparent
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        MaximizeBox = False
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
    Private Sub Form8_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

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

            ComboBox1.Text = row.Cells("title").Value.ToString
            Company.Text = row.Cells("company").Value.ToString
            Producer.Text = row.Cells("producer").Value.ToString
            Director.Text = row.Cells("director").Value.ToString
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
                ComboBox1.Text = READER.GetString("title")
                Company.Text = READER.GetString("company")
                Producer.Text = READER.GetString("producer")
                Director.Text = READER.GetString("director")
                Genre.Text = READER.GetString("genre")
                Casts.Text = READER.GetString("casts")
                datetxt.Text = READER.GetDateTime("date")
                Label12.Text = READER.GetString("picture")
                ticket.Text = READER.GetInt16("ticket")
                Label6.Text = READER.GetInt16("price")
            End While
            MysqlConn.Close()

        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
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

    Private Sub BackBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BackBtn.LinkClicked
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Controls.Clear()
        InitializeComponent()
        Form10_Load(e, e)
    End Sub
End Class