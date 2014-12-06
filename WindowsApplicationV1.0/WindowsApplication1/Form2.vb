Imports System.Data.SqlClient
Imports System.Data.OleDb

Public Class NewReservationForm

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet2.ROOM' table. You can move, or remove it, as needed.
        Me.ROOMTableAdapter2.Fill(Me.DatabaseIST303DataSet2.ROOM)
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet1.room' table. You can move, or remove it, as needed.
        ' Me.RoomTableAdapter1.Fill(Me.DatabaseIST303DataSet1.room)
        'TODO: This line of code loads data into the 'DatabaseIST303DataSet.room' table. You can move, or remove it, as needed.
        'Me.RoomTableAdapter.Fill(Me.DatabaseIST303DataSet.room)

    End Sub

    Private Function Calculate_rates(startDate As Date, endDate As Date, seasonWeekDay As Single, seasonWeekend As Single, offSeasonWeekDay As Single, offSeasonWeekend As Single) As Single
        Dim season, currentdate As Date
        Dim numberOfdays As TimeSpan
        Dim i As Integer
        Dim total_price = 0.0


        numberOfdays = endDate - startDate
        'season.("05/15/" + startDate.Year)
        i = numberOfdays.Days
        currentdate = startDate
        'season = CDate("05/15/2014")
        'MsgBox(season.ToString)
        For index = 1 To i
            If ((currentdate.Month = 5 And currentdate.Day >= 15) Or (currentdate.Month = 6) Or (currentdate.Month = 7) Or (currentdate.Month = 8 And currentdate.Day <= 15)) Then
                'MsgBox("in season======" + currentdate.DayOfWeek.ToString)
                If currentdate.DayOfWeek = DayOfWeek.Monday Or currentdate.DayOfWeek = DayOfWeek.Tuesday Or currentdate.DayOfWeek = DayOfWeek.Wednesday Or _
                    currentdate.DayOfWeek = DayOfWeek.Thursday Or currentdate.DayOfWeek = DayOfWeek.Friday Then
                    total_price += seasonWeekDay
                Else ' this is for weekends
                    total_price += seasonWeekend
                End If
            Else
                If currentdate.DayOfWeek = DayOfWeek.Monday Or currentdate.DayOfWeek = DayOfWeek.Tuesday Or currentdate.DayOfWeek = DayOfWeek.Wednesday Or _
                                    currentdate.DayOfWeek = DayOfWeek.Thursday Or currentdate.DayOfWeek = DayOfWeek.Friday Then
                    total_price += offSeasonWeekDay
                Else ' this is for weekends
                    total_price += offSeasonWeekend
                End If
            End If
            currentdate = currentdate.AddDays(1)
            'MsgBox(currentdate.ToString)
        Next



        'MsgBox(startDate.Date + "------" + numberOfdays.Days.ToString)
        Return total_price
    End Function

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'MsgBox("There is avialability")
        PaymentGroupBox.Show()

        MsgBox("The number of available rooms: " + Me.ROOMTableAdapter2.FillBy(Me.DatabaseIST303DataSet2.ROOM, DateTimePicker2.Value, DateTimePicker2.Value, DateTimePicker1.Value, DateTimePicker1.Value, DateTimePicker2.Value, DateTimePicker1.Value).ToString)
        'MsgBox (DataGridView1.Rows.Count)
        For Each r As DataGridViewRow In DataGridView1.Rows


            r.Cells(6).Value = "$" + Calculate_rates(DateTimePicker2.Value, DateTimePicker1.Value, _
                                                r.Cells(2).Value, r.Cells(3).Value, r.Cells(4).Value, r.Cells(5).Value).ToString


        Next




        'Calculate_rates(DateTimePicker2.Value, DateTimePicker1.Value)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'MsgBox("The room has been booked correctly...")
        'Hide()

        Dim conn As New OleDbConnection()
        Dim cmd, cmd1, cmd2 As New OleDbCommand
        Dim rowCount As Integer
        Dim previousConnectionState1 As ConnectionState
        Dim customer_Pnone_No As String

        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"


        If TextBox1.Text <> "" And TextBox4.Text <> "" And TextBox2.Text <> "" And TextBox3.Text <> "" Then


            customer_Pnone_No = TextBox1.Text
            cmd.CommandType = CommandType.Text
            cmd1.CommandType = CommandType.Text
            cmd2.CommandType = CommandType.Text
            cmd.CommandText = "SELECT F_Name, L_Name,Room_Charges FROM Customer WHERE Phone_No = '" + TextBox1.Text + "'"


            cmd.Connection = conn
            cmd1.Connection = conn
            cmd2.Connection = conn

            Dim reader As OleDbDataReader
            Dim previousConnectionState As ConnectionState = conn.State
            Try
                If conn.State = ConnectionState.Closed Then
                    conn.Open()
                End If
                reader = cmd.ExecuteReader()

                If reader.Read Then
                    ' Process SprocResults datareader here.
                    'TextBox4.Text = reader.GetValue(0)
                    'TextBox2.Text = reader.GetValue(1)
                    'MsgBox("returning Customer")
                    cmd1.CommandText = "UPDATE CUSTOMER SET Card_Number = '" + TextBox7.Text + "' ,Expiration_Date = '" + TextBox5.Text + "' ,CVV = '" + TextBox6.Text + "' ,Number_Of_Guests = " + TextBox3.Text + " ,Room_Charges = " + CStr(CSng(Label11.Text) + CSng(reader.GetValue(2))) + " WHERE Phone_No = '" + TextBox1.Text + "'"
                    rowCount = cmd1.ExecuteNonQuery()
                Else
                    previousConnectionState1 = conn.State
                    Try
                        If conn.State = ConnectionState.Closed Then
                            conn.Open()
                        End If
                        cmd1.CommandText = "INSERT INTO CUSTOMER (F_Name,L_Name,Phone_No,Card_Number,Expiration_Date,CVV,Number_Of_Guests,Room_Charges) VALUES ('" + TextBox4.Text + "','" + TextBox2.Text + "','" + TextBox1.Text + "','" + TextBox7.Text + "','" + TextBox5.Text + "','" + TextBox6.Text + "'," + TextBox3.Text + "," + Label11.Text + ");"
                        rowCount = cmd1.ExecuteNonQuery()

                        'MsgBox("Customer added" + rowCount.ToString)



                    Finally
                        If previousConnectionState1 = ConnectionState.Closed Then
                            conn.Close()
                        End If
                    End Try
                End If
                For Each r As DataGridViewRow In DataGridView1.Rows

                    If r.Cells(7).Value = True Then

                        'MsgBox("in checked")
                        Try
                            If conn.State = ConnectionState.Closed Then
                                conn.Open()
                            End If


                            cmd2.CommandText = "INSERT INTO RESERVATION_ROOM (Phone_No,Room_No,Check_In,Check_Out) VALUES ('" + customer_Pnone_No _
                              + "'," + r.Cells(0).Value.ToString + ",'" + DateTimePicker2.Text + "','" + DateTimePicker1.Text + "');"

                            rowCount = cmd2.ExecuteNonQuery()

                            'MsgBox("Customer added" + rowCount.ToString)



                        Finally
                            If previousConnectionState1 = ConnectionState.Closed Then
                                conn.Close()
                            End If
                        End Try



                    End If

                Next

            Finally
                If previousConnectionState = ConnectionState.Closed Then
                    conn.Close()
                End If
            End Try


            Me.Close()
        Else
            MsgBox("Try to input correct values, nothing has been made...!", MsgBoxStyle.Exclamation, "Invalid Input")
        End If


    End Sub

    Private Sub RoomBindingSource_CurrentChanged(sender As Object, e As EventArgs) Handles RoomBindingSource.CurrentChanged

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        'MsgBox(DirectCast(sender, Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue)
        If e.ColumnIndex = 7 Then
            'If DataGridView1.Rows(e.RowIndex).Cells(7).Selected = True Then
            'MsgBox("Checked")
            'Else
            '   MsgBox("unchecked")
            'End If
            If (DirectCast(sender, Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue) = True Then
                Label11.Text = CStr(CSng(Label11.Text) + DataGridView1.Rows(e.RowIndex).Cells(6).Value)
            End If
            If (DirectCast(sender, Windows.Forms.DataGridView).Rows(e.RowIndex).Cells(e.ColumnIndex).EditedFormattedValue) = False Then

                Label11.Text = CStr(CSng(Label11.Text) - DataGridView1.Rows(e.RowIndex).Cells(6).Value)
            End If

        End If

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim conn As New OleDbConnection()
        conn.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"



        Dim cmd As New OleDbCommand
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "SELECT F_Name, L_Name FROM Customer WHERE Phone_No = '" + TextBox1.Text + "'"

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

                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub

    Private Sub ROOMBindingSource2_CurrentChanged(sender As Object, e As EventArgs) Handles ROOMBindingSource2.CurrentChanged

    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub


    Private Sub PaymentGroupBox_Enter(sender As Object, e As EventArgs) Handles PaymentGroupBox.Enter

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            TextBox5.Enabled = True
            TextBox6.Enabled = True
            TextBox7.Enabled = True
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            TextBox5.Enabled = False
            TextBox6.Enabled = False
            TextBox7.Enabled = False
        End If
    End Sub
End Class