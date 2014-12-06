Imports System.Data.OleDb

Public Class Form6

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("5:00am")
            ComboBox1.Items.Add("8:00am")
            ComboBox1.Items.Add("11:00am")
            ComboBox1.Items.Add("2:00pm")
            ComboBox1.Items.Add("5:00pm")


        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("5:30am")
            ComboBox1.Items.Add("8:30am")
            ComboBox1.Items.Add("11:30am")
            ComboBox1.Items.Add("2:30pm")
            ComboBox1.Items.Add("5:30pm")
           
        End If
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        'start here 
        Dim conn1 As New OleDbConnection()
        conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"

        Dim stype As String


        TextBox1.Text = TextBox3.Text
        If RadioButton1.Checked Then
            stype = "60"
        Else
            stype = "90"
        End If
        Dim cmd1 As New OleDbCommand
        cmd1.CommandType = CommandType.Text
        cmd1.CommandText = "SELECT * FROM TRAIL_RIDING WHERE ((TR_date = #" + DateTimePicker1.Text + "#) AND (TR_Type = '" + stype + "') AND (TR_time = '" + ComboBox1.SelectedItem.ToString + "'))"
        'cmd1.CommandText = "SELECT TR_time FROM TRAIL_RIDING"

        cmd1.Connection = conn1
        ' Create a SqlParameter for each parameter in the stored procedure.
        ' Dim companyNameParam As New SqlParameter("@companyName", "a%")
        'cmd.Parameters.Add(companyNameParam)

        Dim reservedSpots As Integer
        Dim reader1 As OleDbDataReader
        Dim previousConnectionState As ConnectionState = conn1.State
        Try
            If conn1.State = ConnectionState.Closed Then
                conn1.Open()
            End If
            reader1 = cmd1.ExecuteReader()
            reservedSpots = 0
            While reader1.Read
                ' Process SprocResults datareader here.
                'TextBox4.Text = reader.GetValue(0)
                'TextBox2.Text = reader.GetValue(1)
                'TextBox5.Text = reader.GetValue(2)
                ' DataGridView1.Rows.Clear()
                'MsgBox(" i m in")
                'Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet5.RESERVATION_ROOM, TextBox3.Text)

                reservedSpots = reservedSpots + 1

            End While
            TextBox6.Text = (12 - reservedSpots).ToString

        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn1.Close()
            End If
        End Try

        'end here

    End Sub

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

                    'Me.RESERVATION_ROOMTableAdapter.FillBy(Me.DatabaseIST303DataSet5.RESERVATION_ROOM, TextBox3.Text)

                End While
            End Using
        Finally
            If previousConnectionState = ConnectionState.Closed Then
                conn.Close()
            End If
        End Try


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If TextBox1.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" Then

            If CInt(TextBox7.Text) <= CInt(TextBox5.Text) Then



                If CInt(TextBox6.Text) >= CInt(TextBox7.Text) Then


                    Dim conn1 As New OleDbConnection()
                    conn1.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\DatabaseIST303.accdb"

                    Dim stype As String
                    Dim price As Double


                    TextBox1.Text = TextBox3.Text
                    If RadioButton1.Checked Then
                        stype = "60"
                        price = 30
                    Else
                        stype = "90"
                        price = 40
                    End If
                    Dim cmd1 As New OleDbCommand
                    cmd1.CommandType = CommandType.Text
                    'cmd1.CommandText = "SELECT * FROM TRAIL_RIDING WHERE ((TR_date = #" + DateTimePicker1.Text + "#) AND (TR_Type = '" + stype + "') AND (TR_time = '" + ComboBox1.SelectedItem.ToString + "'))"
                    'cmd1.CommandText = "SELECT TR_time FROM TRAIL_RIDING"
                    Dim rowcount As Integer

                    cmd1.Connection = conn1
                    Dim previousConnectionState As ConnectionState = conn1.State
                    Try
                        If conn1.State = ConnectionState.Closed Then
                            conn1.Open()
                        End If

                        For i = 1 To CInt(TextBox7.Text)
                            cmd1.CommandText = "INSERT INTO TRAIL_RIDING (TR_date,TR_time,TR_Type,Phone_No,TR_Price) VALUES ('" + DateTimePicker1.Text + "','" + ComboBox1.SelectedItem + "','" + stype + "','" + TextBox1.Text + "'," + price.ToString + ");"
                            rowcount = cmd1.ExecuteNonQuery()

                        Next

                    Finally
                        If previousConnectionState = ConnectionState.Closed Then
                            conn1.Close()
                        End If
                    End Try

                    'end here

                    Me.Close()
                Else
                    MsgBox("The number of available spots is less than the number of guests to be scheduled", MsgBoxStyle.Exclamation)
                End If

            Else
                MsgBox("The number of guests to be scheduled is more than the checked in guests", MsgBoxStyle.Exclamation)

            End If

        Else
            MsgBox("Phone number, available spots and number of guests to scedule should not be empty", MsgBoxStyle.Exclamation)
        End If

    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class