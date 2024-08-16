Imports MySql.Data.MySqlClient
Public Class Form4
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label5.BackColor = System.Drawing.Color.Transparent
        Label2.BackColor = System.Drawing.Color.Transparent
        Label3.BackColor = System.Drawing.Color.Transparent
        BackBtn.BackColor = System.Drawing.Color.Transparent
        errormsg.BackColor = System.Drawing.Color.Transparent
        MaximizeBox = False
    End Sub
    Private Sub Form4_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dim dialog As DialogResult
        dialog = MessageBox.Show("Close the Application?", "Exit", MessageBoxButtons.YesNo)
        If dialog = DialogResult.No Then
            e.Cancel = True
        Else
            Application.ExitThread()
        End If

    End Sub

    Private Sub BackBtn_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles BackBtn.LinkClicked
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "select * from cinema.admin where username='" & TextBoxUN.Text & "' and password='" & TextBox2.Text & "'"
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
                MessageBox.Show("Welcome back Admin!")
                Me.Controls.Clear()
                InitializeComponent()
                Form4_Load(e, e)
                Form5.Show()
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
End Class