Imports System.Data.OleDb

Public Class CheckOutForm

    Private Sub CheckOutForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet6.RESERVATION_ROOM' table. You can move, or remove it, as needed.
        'Me.RESERVATION_ROOMTableAdapter.Fill(Me.DatabaseIST303DataSet6.RESERVATION_ROOM)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'CustormerGroupBox.Show()
        Dim conn As New OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"


        TextBox1.Text = TextBox3.Text

        Dim cmd, cmd1, cmd2, cmd3, cmd4, cmd5 As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd1.CommandType = CommandType.Text

        cmd.CommandText = "SELECT F_Name, L_Name , Number_Of_Guests,Card_Number,Expiration_Date,CVV,Room_Charges FROM Customer WHERE (Phone_No = '" + TextBox3.Text + "' );"
        cmd1.CommandText = "SELECT Dependant_Name FROM DEPENDANTS WHERE (Phone_No = '" + TextBox3.Text + "' );"

        cmd2.Connection = conn

        cmd.Connection = conn
        cmd1.Connection = conn
        ' Create a SqlParameter for each parameter in the stored procedure.
        ' Dim companyNameParam As New SqlParameter("@companyName", "a%")
        'cmd.Parameters.Add(companyNameParam)


        Dim reader, reader1, reader2, reader3, reader4, reader5 As OleDbDataReader
        Dim previousConnectionState As ConnectionState = conn.State
        Dim TrailRiding_price, Massage_price, Lassoing_price, GuidedHiking_price As Double
        TrailRiding_price = 0
        Massage_price = 0
        Lassoing_price = 0
        GuidedHiking_price = 0

        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            reader1 = cmd1.ExecuteReader()
            While reader1.Read
                ListBox1.Items.Add(reader1.GetValue(0))
            End While

            reader = cmd.ExecuteReader()
            Using reader
                If reader.Read Then
                    ' Process SprocResults datareader here.
                    TextBox4.Text = reader.GetValue(0)
                    TextBox2.Text = reader.GetValue(1)
                    TextBox13.Text = reader.GetValue(3)
                    TextBox12.Text = reader.GetValue(4)
                    TextBox11.Text = reader.GetValue(5)
                    TextBox6.Text = reader.GetValue(6).ToString
                    'TextBox5.Text = reader.GetValue(2)
                    ' DataGridView1.Rows.Clear()

                    'Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet5.RESERVATION_ROOM, TextBox3.Text)
                    Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet6.RESERVATION_ROOM, TextBox3.Text)
                End If
            End Using
            cmd2.CommandText = "SELECT TR_Price FROM TRAIL_RIDING WHERE (Phone_No = '" + TextBox3.Text + "' );"
            cmd2.CommandType = CommandType.Text
            cmd2.Connection = conn
            reader2 = cmd2.ExecuteReader()
            While reader2.Read()
                TrailRiding_price += CDbl(reader2.GetValue(0))
            End While
            TextBox8.Text = TrailRiding_price.ToString

            cmd3.CommandType = CommandType.Text
            cmd3.Connection = conn
            cmd3.CommandText = "SELECT MS_Price FROM MASSAGE WHERE (Phone_No = '" + TextBox3.Text + "' );"
            reader3 = cmd3.ExecuteReader()
            While reader3.Read()
                Massage_price += CDbl(reader3.GetValue(0))
            End While
            TextBox9.Text = Massage_price.ToString

            cmd4.CommandType = CommandType.Text
            cmd4.Connection = conn
            cmd4.CommandText = "SELECT LC_Price FROM LASSOING WHERE (Phone_No = '" + TextBox3.Text + "' );"
            reader4 = cmd4.ExecuteReader()
            While reader4.Read()
                Lassoing_price += CDbl(reader4.GetValue(0))
            End While
            TextBox7.Text = Lassoing_price.ToString

            cmd5.CommandType = CommandType.Text
            cmd5.Connection = conn
            cmd5.CommandText = "SELECT GH_Price FROM GUIDED_HIKING WHERE (Phone_No = '" + TextBox3.Text + "' );"
            reader5 = cmd5.ExecuteReader()
            While reader5.Read()
                GuidedHiking_price += CDbl(reader5.GetValue(0))
            End While
            TextBox5.Text = GuidedHiking_price.ToString
            TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
       
        Dim conn As New OleDbConnection()
        Dim rowcount As Integer


        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"
        Dim previousConnectionState1 As ConnectionState




        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        
        cmd.Connection = conn
        previousConnectionState1 = conn.State
        Try
            If conn.State = ConnectionState.Closed Then
                conn.Open()
            End If
            ' MsgBox(DataGridView1.Rows.Count.ToString)=
            'cmd.CommandText = "UPDATE CUSTOMER SET CUSTOMER.Number_Of_Guests  = " + TextBox5.Text + " WHERE CUSTOMER.Phone_No = '" + TextBox1.Text + "'"
            ' rowcount = cmd.ExecuteNonQuery()

            cmd.CommandText = "DELETE DEPENDANTS.* FROM DEPENDANTS WHERE ((DEPENDANTS.Phone_No ='" + TextBox1.Text + "'));"
            rowcount = cmd.ExecuteNonQuery()




            'For Each r As DataGridViewRow In DataGridView1.Rows
            For i = 0 To DataGridView1.Rows.Count - 2

                cmd.CommandText = "UPDATE RESERVATION_ROOM SET RESERVATION_ROOM.Checked_Out  = True WHERE  ( RESERVATION_ROOM.Phone_No = '" + TextBox1.Text + "' and RESERVATION_ROOM.Room_No = " + DataGridView1.Rows(i).Cells(2).Value.ToString + ")"
                rowcount = cmd.ExecuteNonQuery()



            Next


        Finally
            If previousConnectionState1 = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try
        Me.Close()


    End Sub

    Private Sub PaymentGroupBox_Enter(sender As Object, e As EventArgs) Handles PaymentGroupBox.Enter

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        'Try
        'Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet6.RESERVATION_ROOM, Phone_NoToolStripTextBox.Text)
        'Catch ex As System.Exception
        'System.Windows.Forms.MessageBox.Show(ex.Message)
        'End Try

    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        ' TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged
        ' TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged
        'TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged
        'TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged
        'TextBox10.Text = CDbl(TextBox5.Text) + CDbl(TextBox6.Text) + CDbl(TextBox7.Text) + CDbl(TextBox8.Text) + CDbl(TextBox9.Text)

    End Sub
End Class