<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewReservationForm
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PaymentGroupBox = New System.Windows.Forms.GroupBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.ROOMBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet2 = New WindowsApplication1.DatabaseIST303DataSet2()
        Me.RoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet1 = New WindowsApplication1.DatabaseIST303DataSet1()
        Me.DatabaseIST303DataSet = New WindowsApplication1.DatabaseIST303DataSet()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter = New WindowsApplication1.DatabaseIST303DataSetTableAdapters.roomTableAdapter()
        Me.RoomTableAdapter1 = New WindowsApplication1.DatabaseIST303DataSet1TableAdapters.roomTableAdapter()
        Me.ROOMTableAdapter2 = New WindowsApplication1.DatabaseIST303DataSet2TableAdapters.ROOMTableAdapter()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.PaymentGroupBox.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ROOMBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker2)
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(341, 83)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Booking Information"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(248, 39)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(84, 20)
        Me.TextBox3.TabIndex = 3
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker2.Location = New System.Drawing.Point(10, 39)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker2.TabIndex = 1
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(128, 39)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(98, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(125, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(83, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Check Out Date"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(7, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Check In Date"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(245, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Number of Guests"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Controls.Add(Me.TextBox1)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.TextBox4)
        Me.GroupBox2.Controls.Add(Me.TextBox2)
        Me.GroupBox2.Location = New System.Drawing.Point(359, 13)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(379, 83)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer Information"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(327, 38)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(49, 23)
        Me.Button3.TabIndex = 19
        Me.Button3.Text = "Search"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(224, 40)
        Me.TextBox1.MaxLength = 10
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 6
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(219, 24)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(77, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Phone Number"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "First Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(115, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Last Name"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(10, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 4
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(116, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(741, 19)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 77)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Check Availability"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'PaymentGroupBox
        '
        Me.PaymentGroupBox.Controls.Add(Me.RadioButton2)
        Me.PaymentGroupBox.Controls.Add(Me.RadioButton1)
        Me.PaymentGroupBox.Controls.Add(Me.Button2)
        Me.PaymentGroupBox.Controls.Add(Me.TextBox6)
        Me.PaymentGroupBox.Controls.Add(Me.Label9)
        Me.PaymentGroupBox.Controls.Add(Me.TextBox5)
        Me.PaymentGroupBox.Controls.Add(Me.Label8)
        Me.PaymentGroupBox.Controls.Add(Me.Label3)
        Me.PaymentGroupBox.Controls.Add(Me.TextBox7)
        Me.PaymentGroupBox.Location = New System.Drawing.Point(205, 183)
        Me.PaymentGroupBox.Name = "PaymentGroupBox"
        Me.PaymentGroupBox.Size = New System.Drawing.Size(612, 86)
        Me.PaymentGroupBox.TabIndex = 15
        Me.PaymentGroupBox.TabStop = False
        Me.PaymentGroupBox.Text = "Credit Card Information"
        Me.PaymentGroupBox.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Checked = True
        Me.RadioButton2.Location = New System.Drawing.Point(513, 19)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(54, 17)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "Credit"
        Me.RadioButton2.UseVisualStyleBackColor = True
        Me.RadioButton2.Visible = False
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(518, 52)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(49, 17)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.Text = "Cash"
        Me.RadioButton1.UseVisualStyleBackColor = True
        Me.RadioButton1.Visible = False
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(362, 52)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Book Now"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(292, 52)
        Me.TextBox6.MaxLength = 3
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(64, 20)
        Me.TextBox6.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(289, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 14
        Me.Label9.Text = "CVC Code"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(170, 52)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(107, 20)
        Me.TextBox5.TabIndex = 11
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(167, 36)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Expiration (MM/YYYY)"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 36)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Credit Card Number"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(28, 52)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(123, 20)
        Me.TextBox7.TabIndex = 10
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.PaymentGroupBox)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.DataGridView1)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 102)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(827, 275)
        Me.GroupBox3.TabIndex = 16
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Available Rooms"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(128, 213)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(32, 19)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "0.0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 213)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(115, 19)
        Me.Label10.TabIndex = 2
        Me.Label10.Text = "Your total is: $"
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNoDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn, Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn, Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn, Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn, Me.Price, Me.Column2})
        Me.DataGridView1.DataSource = Me.ROOMBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(8, 27)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(809, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "Room No"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        Me.RoomNoDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomNoDataGridViewTextBoxColumn.Width = 69
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room Type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        Me.RoomTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomTypeDataGridViewTextBoxColumn.Width = 79
        '
        'RoomSessionWeekdayPriceDataGridViewTextBoxColumn
        '
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Session_Weekday_Price"
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.HeaderText = "Season Weekday Price"
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.Name = "RoomSessionWeekdayPriceDataGridViewTextBoxColumn"
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.Width = 108
        '
        'RoomSessionWeekendPriceDataGridViewTextBoxColumn
        '
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Session_Weekend_Price"
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.HeaderText = "Season Weekend Price"
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.Name = "RoomSessionWeekendPriceDataGridViewTextBoxColumn"
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.Width = 108
        '
        'RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn
        '
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Off_Session_Weekday_Price"
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.HeaderText = "Off-Season Weekday Price"
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.Name = "RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn"
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.Width = 126
        '
        'RoomOffSessionWeekendPriceDataGridViewTextBoxColumn
        '
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Off_Session_Weekend_Price"
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.HeaderText = "Off-Season Weekend Price"
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.Name = "RoomOffSessionWeekendPriceDataGridViewTextBoxColumn"
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.ReadOnly = True
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.Width = 126
        '
        'Price
        '
        Me.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Price.HeaderText = "Total"
        Me.Price.Name = "Price"
        Me.Price.ReadOnly = True
        Me.Price.Width = 56
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column2.HeaderText = "Select"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 42
        '
        'ROOMBindingSource2
        '
        Me.ROOMBindingSource2.DataMember = "ROOM"
        Me.ROOMBindingSource2.DataSource = Me.DatabaseIST303DataSet2
        '
        'DatabaseIST303DataSet2
        '
        Me.DatabaseIST303DataSet2.DataSetName = "DatabaseIST303DataSet2"
        Me.DatabaseIST303DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource1
        '
        Me.RoomBindingSource1.DataMember = "room"
        Me.RoomBindingSource1.DataSource = Me.DatabaseIST303DataSet1
        '
        'DatabaseIST303DataSet1
        '
        Me.DatabaseIST303DataSet1.DataSetName = "DatabaseIST303DataSet1"
        Me.DatabaseIST303DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseIST303DataSet
        '
        Me.DatabaseIST303DataSet.DataSetName = "DatabaseIST303DataSet"
        Me.DatabaseIST303DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.DatabaseIST303DataSet
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'ROOMTableAdapter2
        '
        Me.ROOMTableAdapter2.ClearBeforeFill = True
        '
        'NewReservationForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(852, 388)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "NewReservationForm"
        Me.Text = "New Reservation"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.PaymentGroupBox.ResumeLayout(False)
        Me.PaymentGroupBox.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ROOMBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents DateTimePicker2 As System.Windows.Forms.DateTimePicker
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PaymentGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox7 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents DatabaseIST303DataSet As WindowsApplication1.DatabaseIST303DataSet
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As WindowsApplication1.DatabaseIST303DataSetTableAdapters.roomTableAdapter
    Friend WithEvents DatabaseIST303DataSet1 As WindowsApplication1.DatabaseIST303DataSet1
    Friend WithEvents RoomBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.DatabaseIST303DataSet1TableAdapters.roomTableAdapter
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseIST303DataSet2 As WindowsApplication1.DatabaseIST303DataSet2
    Friend WithEvents ROOMBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents ROOMTableAdapter2 As WindowsApplication1.DatabaseIST303DataSet2TableAdapters.ROOMTableAdapter
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomSessionWeekdayPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomSessionWeekendPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomOffSessionWeekendPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Price As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class
