Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Public Class Form3
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.BackColor = System.Drawing.Color.Transparent
        Label6.BackColor = System.Drawing.Color.Transparent
        Label7.BackColor = System.Drawing.Color.Transparent
        Label8.BackColor = System.Drawing.Color.Transparent
        Label9.BackColor = System.Drawing.Color.Transparent
        BackBtn.BackColor = System.Drawing.Color.Transparent
        MaximizeBox = False
    End Sub
    Private Sub Form3_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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

        If TextBoxPass.Text = "" Or TextBoxUN.Text = "" Or TextBoxEm.Text = "" Then
            errormsg.Text = "Please complete required fields"
            Exit Sub
        End If

        Try
            MysqlConn.Open()
            Dim Query As String
            Query = "insert into cinema.user (username, password, email) values ('" & TextBoxUN.Text & "', '" & TextBoxPass.Text & "', '" & TextBoxEm.Text & "')"
            COMMAND = New MySqlCommand(Query, MysqlConn)
            READER = COMMAND.ExecuteReader
            Dim count As Integer
            count = 0

            While READER.Read
                count = count + 1
            End While

            If count = 1 Then
                errormsg.Text = "Registration failed. Try again"
            Else
                MessageBox.Show("Registration Complete. Please Log-in")
                TextBoxUN.Clear()
                TextBoxPass.Clear()
                TextBoxEm.Clear()
                errormsg.Hide()
                Me.Hide()
                Form1.Show()
            End If

            MysqlConn.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            MysqlConn.Dispose()
        End Try
    End Sub
End Class