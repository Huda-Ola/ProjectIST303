Public Class Form7

    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet4.ROOM' table. You can move, or remove it, as needed.
        Me.ROOMTableAdapter2.Fill(Me.DatabaseIST303DataSet4.ROOM)
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet3.CUSTOMER' table. You can move, or remove it, as needed.
        'Me.CUSTOMERTableAdapter.Fill(Me.DatabaseIST303DataSet3.CUSTOMER)
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet1.room' table. You can move, or remove it, as needed.
        ' Me.RoomTableAdapter1.Fill(Me.DatabaseIST303DataSet1.room)
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet.room' table. You can move, or remove it, as needed.
        'Me.RoomTableAdapter.Fill(Me.DatabaseIST303DataSet.room)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'RoomTableAdapter.Adapter.
        CUSTOMERTableAdapter.Update(DatabaseIST303DataSet3)




    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
       

    End Sub

    Private Sub FillByToolStripButton1_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton1.Click
       

    End Sub
End Class