Imports System.Management
Imports System.Windows.Forms.VisualStyles.VisualStyleElement
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class Form8
    Dim MysqlConn As MySqlConnection
    Dim COMMAND As MySqlCommand
    Private Const server As String = "server=localhost;userid=root;database=cinema"
    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.Enabled = False
        errormsg.Hide()
        MaximizeBox = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        myticket.Text = myticket.Text + 1
        If myticket.Text <> 1 Then
            Button1.Enabled = True
        End If
        If myticket.Text = ticket.Text Then
            Button2.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        myticket.Text = myticket.Text - 1
        If myticket.Text = 1 Then
            Button1.Enabled = False
        End If
        If myticket.Text <> ticket.Text Then
            Button2.Enabled = True
        End If
        If myticket.Text <= ticket.Text Then
            errormsg.Hide()
        End If
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        errormsg.Hide()
        If myticket.Text <> 1 Then
            myticket.Text = 1
        End If
        If cashBox.Text.Trim.Length > 0 Then
            cashBox.Text = ""
        End If
        Me.Hide()
        Form2.Show()
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

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub ticket_Click(sender As Object, e As EventArgs) Handles ticket.Click

    End Sub

    Private Sub Title_Click(sender As Object, e As EventArgs) Handles Title.Click

    End Sub

    Private Sub myticket_TextChanged(sender As Object, e As EventArgs) Handles myticket.TextChanged

    End Sub

    'Private change As Integer = CInt(cashBox.Text) - CInt(price.Text * myticket.Text)
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MysqlConn = New MySqlConnection
        MysqlConn.ConnectionString = server
        Dim READER As MySqlDataReader
        Dim result As DialogResult = MessageBox.Show("Do you want to purchase this movie ticket?", "Purchase", MessageBoxButtons.YesNo)

        If result = DialogResult.No Then
            MessageBox.Show(" Purchasing cancelled.")
        ElseIf result = DialogResult.Yes Then
            If cashBox.Text = "" Then
                MessageBox.Show("Please enter cash amount.")
                Exit Sub
            End If
            Dim change As String
            change = CInt(cashBox.Text) - CInt(price.Text * myticket.Text)
            If change < 0 Then
                MessageBox.Show("Insufficient amount of cash.", "Bro is broke")
                Exit Sub
            End If
            If CInt(myticket.Text) > CInt(ticket.Text) Then
                MessageBox.Show("Cannot purchase ticket. Please try again.")
                Exit Sub
            End If
            If CInt(cashBox.Text) > CInt(price.Text) Then

            ElseIf CInt(cashBox.Text) < CInt(price.Text) Then
                MessageBox.Show("Insufficient amount of cash.")
                Exit Sub
            End If


            Try
                MysqlConn.Open()
                Dim Query As String
                Query = "update cinema.movie set ticket = ticket - '" & myticket.Text & "' where title = '" & Title.Text & "'"
                COMMAND = New MySqlCommand(Query, MysqlConn)
                READER = COMMAND.ExecuteReader

                Form9.Title.Text = Me.Title.Text
                Form9.nameBox.Text = Form2.Label2.Text
                Form9.Qtytxt.Text = Me.myticket.Text
                Form9.Price.Text = Me.price.Text
                Form9.Tprice.Text = Me.price.Text
                Form9.cash.Text = Me.cashBox.Text
                Form9.change.Text = CInt(Me.cashBox.Text) - CInt(Me.price.Text * Me.myticket.Text)
                Form9.Sdate.Text = Form2.datetxt.Text
                ' Dim change As String
                'change = cashBox.Text - (price.Text * myticket.Text)
                'Form9.change.Text = change
                MessageBox.Show("Purchase Completed!")
                Form9.Tprice.Text = myticket.Text * price.Text
                Form9.Show()
                Me.Hide()
                MysqlConn.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message)
            Finally
                MysqlConn.Dispose()
            End Try
        End If

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub
End Class