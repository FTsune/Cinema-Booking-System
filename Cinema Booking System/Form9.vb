Public Class Form9

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MaximizeBox = False
        Dim total As String
        total = Form8.myticket.Text * Form8.price.Text
        Tprice.Text = total
        change.Text = Form8.cashBox.Text - (Form8.myticket.Text * Form8.price.Text)
        MessageBox.Show("Enjoy! :)")
        Application.ExitThread()

    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        datetxt.Text = DateAndTime.Now
    End Sub

    Private Sub Tprice_Click(sender As Object, e As EventArgs) Handles Tprice.Click

    End Sub
    'Private change2 As Integer = Form1.change
End Class