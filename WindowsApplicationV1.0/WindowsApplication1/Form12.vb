Imports System.Data.OleDb

Public Class Form12


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        CustormerGroupBox.Show()
        Dim conn As New OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"


        TextBox1.Text = TextBox3.Text

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT F_Name, L_Name , Number_Of_Guests FROM Customer WHERE Phone_No = '" + TextBox3.Text + "'"

        cmd.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        ' Dim companyNameParam As New SqlParameter("@companyName", "a%")
        'cmd.Parameters.Add(companyNameParam)


        Dim reader As OleDbDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader = cmd.ExecuteReader()
            Using reader
                While reader.Read
                    ' Process SprocResults datareader here.
                    TextBox4.Text = reader.GetValue(0)
                    TextBox2.Text = reader.GetValue(1)
                    TextBox5.Text = reader.GetValue(2)
                    ' DataGridView1.Rows.Clear()

                    Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet5.RESERVATION_ROOM, TextBox3.Text)

                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox("The customer checked in correctly...")
        'Hide()
        'Label4.Text = "The room number is " + "304"
        Dim conn As New OleDbConnection()
        Dim rowcount As Integer


        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"
        Dim previousConnectionState1 As ConnectionState


        'TextBox1.Text = TextBox3.Text

        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        'cmd.CommandText = "UPDATE CUSTOMER SET RESERVATCUSTOMER CUSTOMER.Number_Of_Guests  = " + TextBox5.Text

        cmd.Connection = conn
        previousConnectionState1 = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            ' MsgBox(DataGridView1.Rows.Count.ToString)=
            cmd.CommandText = "DELETE RESERVATION_ROOM.* FROM RESERVATION_ROOM WHERE ((RESERVATION_ROOM.Phone_No ='" + TextBox1.Text + "'));"
            rowcount = cmd.ExecuteNonQuery()



            'For Each r As DataGridViewRow In DataGridView1.Rows
           


        Finally
            If previousConnectionState1 = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        Me.Close()

    End Sub

    Private Sub CheckInForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet5.RESERVATION_ROOM' table. You can move, or remove it, as needed.
        ' Me.RESERVATION_ROOMTableAdapter.Fill(Me.DatabaseIST303DataSet5.RESERVATION_ROOM)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub
End Class