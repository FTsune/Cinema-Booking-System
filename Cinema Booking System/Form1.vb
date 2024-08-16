Imports MySql.Data.MySqlClient
Public Class Form1
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub formName_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label6.BackColor = System.Drawing.Color.Transparent
        Label10.BackColor = System.Drawing.Color.Transparent
        PictureBox4.BackColor = System.Drawing.Color.Transparent
        PictureBox5.BackColor = System.Drawing.Color.Transparent
        MaximizeBox = False
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cinema.user where username='" & TextBoxUN.Text & "' and password='" & TextBox2.Text & "'"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            If TextBox2.Text = "" Or TextBoxUN.Text = "" Then
                errormsg.Text = "Please complete required fields"
                Exit Sub
            End If
            While READER.Read
                count = count + 1
            End While
            If count = 1 Then
                Form2.Label2.Text = Me.TextBoxUN.Text
                MessageBox.Show("Login Successfully")
                Form2.Show()
                Me.Controls.Clear()
                InitializeComponent()
                formName_Load(e, e)
                Me.Hide()
            Else
                errormsg.Text = "Incorrect Username/Password"
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub

    Private Sub RegLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegLink.LinkClicked
        Form3.Show()
        Me.Hide()
        TextBoxUN.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Form4.Show()
        Me.Hide()
        TextBoxUN.Clear()
        TextBox2.Clear()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
