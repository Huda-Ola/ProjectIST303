Public Class Form1

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)
        'open("Test")
   
        'Form2.Text = "hgfd"

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        NewReservationForm.Show()
       
        'Button1.Text = "ola"

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CheckInForm.Show()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        RanchServicesForm.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CheckOutForm.Show()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form7.Show()

    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Form13.Show()

    End Sub
End Class
