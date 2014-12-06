<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedInDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckedOutDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RESERVATIONROOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet6 = New WindowsApplication1.DatabaseIST303DataSet6()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.RESERVATION_ROOMTableAdapter = New WindowsApplication1.DatabaseIST303DataSet6TableAdapters.RESERVATION_ROOMTableAdapter()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.PaymentGroupBox.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 53)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 76)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(256, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(253, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(14, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Last Name"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(17, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 14
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(208, 19)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(314, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 20)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Search..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox4)
        Me.GroupBox1.Controls.Add(Me.GroupBox3)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.TextBox10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TextBox9)
        Me.GroupBox1.Controls.Add(Me.TextBox8)
        Me.GroupBox1.Controls.Add(Me.TextBox5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox6)
        Me.GroupBox1.Controls.Add(Me.TextBox7)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 239)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(379, 177)
        Me.GroupBox1.TabIndex = 12
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Guest Charges"
        '
        'GroupBox4
        '
        Me.GroupBox4.Location = New System.Drawing.Point(9, 126)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(364, 12)
        Me.GroupBox4.TabIndex = 28
        Me.GroupBox4.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Location = New System.Drawing.Point(9, 81)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 12)
        Me.GroupBox3.TabIndex = 27
        Me.GroupBox3.TabStop = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(298, 146)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 26
        Me.Button2.Text = "Check Out"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(9, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(87, 13)
        Me.Label10.TabIndex = 25
        Me.Label10.Text = "Total Charges: $"
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(95, 148)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.ReadOnly = True
        Me.TextBox10.Size = New System.Drawing.Size(100, 20)
        Me.TextBox10.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(213, 25)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(54, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "Massages"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 25)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(87, 13)
        Me.Label8.TabIndex = 21
        Me.Label8.Text = "Lassoing Classes"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(273, 22)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.ReadOnly = True
        Me.TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.TextBox9.TabIndex = 20
        Me.TextBox9.Text = "0.0"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(273, 55)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.ReadOnly = True
        Me.TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.TextBox8.TabIndex = 19
        Me.TextBox8.Text = "0.0"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(95, 55)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 18
        Me.TextBox5.Text = "0.0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 17
        Me.Label2.Text = "Guided Hiking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(9, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Room Charges"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(213, 58)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 13)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Trail Riding "
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(95, 102)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.ReadOnly = True
        Me.TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.TextBox6.TabIndex = 14
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(95, 22)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.ReadOnly = True
        Me.TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.TextBox7.TabIndex = 13
        Me.TextBox7.Text = "0.0"
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.Controls.Add(Me.TextBox11)
        Me.PaymentGroupBox.Controls.Add(Me.Label11)
        Me.PaymentGroupBox.Controls.Add(Me.TextBox12)
        Me.PaymentGroupBox.Controls.Add(Me.Label12)
        Me.PaymentGroupBox.Controls.Add(Me.Label13)
        Me.PaymentGroupBox.Controls.Add(Me.TextBox13)
        Me.PaymentGroupBox.Location = New System.Drawing.Point(12, 141)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(379, 84)
        Me.PaymentGroupBox.TabIndex = 27
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Credit Card Information"
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(281, 48)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(64, 20)
        Me.TextBox11.TabIndex = 15
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(278, 32)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(54, 13)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "CVV Code"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(159, 48)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(107, 20)
        Me.TextBox12.TabIndex = 13
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(156, 32)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(110, 13)
        Me.Label12.TabIndex = 12
        Me.Label12.Text = "Expiration (MM/YYYY)"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(14, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(102, 13)
        Me.Label13.TabIndex = 11
        Me.Label13.Text = "Credit Card Number"
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(17, 48)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(123, 20)
        Me.TextBox13.TabIndex = 10
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Enter Custormer Phone Number:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.DataGridView1)
        Me.GroupBox5.Location = New System.Drawing.Point(397, 22)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(442, 186)
        Me.GroupBox5.TabIndex = 29
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "GroupBox5"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIdDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.RoomNoDataGridViewTextBoxColumn, Me.CheckInDataGridViewTextBoxColumn, Me.CheckOutDataGridViewTextBoxColumn, Me.CheckedInDataGridViewCheckBoxColumn, Me.CheckedOutDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.RESERVATIONROOMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(3, 16)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(375, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'ReservationIdDataGridViewTextBoxColumn
        '
        Me.ReservationIdDataGridViewTextBoxColumn.DataPropertyName = "Reservation_Id"
        Me.ReservationIdDataGridViewTextBoxColumn.HeaderText = "Reservation_Id"
        Me.ReservationIdDataGridViewTextBoxColumn.Name = "ReservationIdDataGridViewTextBoxColumn"
        Me.ReservationIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.ReservationIdDataGridViewTextBoxColumn.Visible = False
        '
        'PhoneNoDataGridViewTextBoxColumn
        '
        Me.PhoneNoDataGridViewTextBoxColumn.DataPropertyName = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.HeaderText = "Phone_No"
        Me.PhoneNoDataGridViewTextBoxColumn.Name = "PhoneNoDataGridViewTextBoxColumn"
        Me.PhoneNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.PhoneNoDataGridViewTextBoxColumn.Visible = False
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        Me.RoomNoDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckInDataGridViewTextBoxColumn
        '
        Me.CheckInDataGridViewTextBoxColumn.DataPropertyName = "Check_In"
        Me.CheckInDataGridViewTextBoxColumn.HeaderText = "Check_In"
        Me.CheckInDataGridViewTextBoxColumn.Name = "CheckInDataGridViewTextBoxColumn"
        Me.CheckInDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckOutDataGridViewTextBoxColumn
        '
        Me.CheckOutDataGridViewTextBoxColumn.DataPropertyName = "Check_Out"
        Me.CheckOutDataGridViewTextBoxColumn.HeaderText = "Check_Out"
        Me.CheckOutDataGridViewTextBoxColumn.Name = "CheckOutDataGridViewTextBoxColumn"
        Me.CheckOutDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CheckedInDataGridViewCheckBoxColumn
        '
        Me.CheckedInDataGridViewCheckBoxColumn.DataPropertyName = "Checked_In"
        Me.CheckedInDataGridViewCheckBoxColumn.HeaderText = "Checked_In"
        Me.CheckedInDataGridViewCheckBoxColumn.Name = "CheckedInDataGridViewCheckBoxColumn"
        Me.CheckedInDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CheckedInDataGridViewCheckBoxColumn.Visible = False
        '
        'CheckedOutDataGridViewCheckBoxColumn
        '
        Me.CheckedOutDataGridViewCheckBoxColumn.DataPropertyName = "Checked_Out"
        Me.CheckedOutDataGridViewCheckBoxColumn.HeaderText = "Checked_Out"
        Me.CheckedOutDataGridViewCheckBoxColumn.Name = "CheckedOutDataGridViewCheckBoxColumn"
        Me.CheckedOutDataGridViewCheckBoxColumn.ReadOnly = True
        Me.CheckedOutDataGridViewCheckBoxColumn.Visible = False
        '
        'RESERVATIONROOMBindingSource
        '
        Me.RESERVATIONROOMBindingSource.DataMember = "RESERVATION_ROOM"
        Me.RESERVATIONROOMBindingSource.DataSource = Me.DatabaseIST303DataSet6
        '
        'DatabaseIST303DataSet6
        '
        Me.DatabaseIST303DataSet6.DataSetName = "DatabaseIST303DataSet6"
        Me.DatabaseIST303DataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.ListBox1)
        Me.GroupBox6.Location = New System.Drawing.Point(415, 224)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(166, 200)
        Me.GroupBox6.TabIndex = 30
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Customer Guests"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(6, 18)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(140, 160)
        Me.ListBox1.TabIndex = 0
        '
        'RESERVATION_ROOMTableAdapter
        '
        Me.RESERVATION_ROOMTableAdapter.ClearBeforeFill = True
        '
        'CheckOutForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(876, 428)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PaymentGroupBox)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "CheckOutForm"
        Me.Text = "Check Out"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox6.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox8 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox10 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PaymentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox11 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents TextBox12 As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents TextBox13 As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseIST303DataSet6 As WindowsApplication1.DatabaseIST303DataSet6
    Friend WithEvents RESERVATIONROOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESERVATION_ROOMTableAdapter As WindowsApplication1.DatabaseIST303DataSet6TableAdapters.RESERVATION_ROOMTableAdapter
    Friend WithEvents ReservationIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckedInDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckedOutDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
End Class
