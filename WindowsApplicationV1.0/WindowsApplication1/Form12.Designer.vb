<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form12
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DatabaseIST303DataSet4 = New WindowsApplication1.DatabaseIST303DataSet4()
        Me.DatabaseIST303DataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RESERVATION_ROOMTableAdapter = New WindowsApplication1.DatabaseIST303DataSet5TableAdapters.RESERVATION_ROOMTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PhoneNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckInDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOutDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckedInDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.CheckedOutDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.RESERVATIONROOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet5 = New WindowsApplication1.DatabaseIST303DataSet5()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CustormerGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustormerGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(12, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 17
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(191, 6)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(156, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Numbre of Guests Checking In:"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(172, 79)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(60, 20)
        Me.TextBox5.TabIndex = 20
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(248, 77)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 23)
        Me.Button2.TabIndex = 19
        Me.Button2.Text = "Cancel Reservation"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(248, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(125, 20)
        Me.TextBox1.TabIndex = 18
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(245, 24)
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
        'DatabaseIST303DataSet4
        '
        Me.DatabaseIST303DataSet4.DataSetName = "DatabaseIST303DataSet4"
        Me.DatabaseIST303DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseIST303DataSet4BindingSource
        '
        Me.DatabaseIST303DataSet4BindingSource.DataSource = Me.DatabaseIST303DataSet4
        Me.DatabaseIST303DataSet4BindingSource.Position = 0
        '
        'RESERVATION_ROOMTableAdapter
        '
        Me.RESERVATION_ROOMTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ReservationIdDataGridViewTextBoxColumn, Me.PhoneNoDataGridViewTextBoxColumn, Me.RoomNoDataGridViewTextBoxColumn, Me.CheckInDataGridViewTextBoxColumn, Me.CheckOutDataGridViewTextBoxColumn, Me.CheckedInDataGridViewCheckBoxColumn, Me.CheckedOutDataGridViewCheckBoxColumn})
        Me.DataGridView1.DataSource = Me.RESERVATIONROOMBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(364, 146)
        Me.DataGridView1.TabIndex = 23
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
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "Room No"
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
        Me.RESERVATIONROOMBindingSource.DataSource = Me.DatabaseIST303DataSet5
        '
        'DatabaseIST303DataSet5
        '
        Me.DatabaseIST303DataSet5.DataSetName = "DatabaseIST303DataSet5"
        Me.DatabaseIST303DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 20)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "Search..."
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 24)
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
        Me.TextBox2.Location = New System.Drawing.Point(132, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Enter Custormer Phone Number:"
        '
        'CustormerGroupBox
        '
        Me.CustormerGroupBox.Controls.Add(Me.DataGridView1)
        Me.CustormerGroupBox.Controls.Add(Me.Label2)
        Me.CustormerGroupBox.Controls.Add(Me.TextBox5)
        Me.CustormerGroupBox.Controls.Add(Me.Button2)
        Me.CustormerGroupBox.Controls.Add(Me.TextBox1)
        Me.CustormerGroupBox.Controls.Add(Me.Label7)
        Me.CustormerGroupBox.Controls.Add(Me.Label6)
        Me.CustormerGroupBox.Controls.Add(Me.Label5)
        Me.CustormerGroupBox.Controls.Add(Me.TextBox4)
        Me.CustormerGroupBox.Controls.Add(Me.TextBox2)
        Me.CustormerGroupBox.Location = New System.Drawing.Point(12, 32)
        Me.CustormerGroupBox.Name = "CustormerGroupBox"
        Me.CustormerGroupBox.Size = New System.Drawing.Size(389, 266)
        Me.CustormerGroupBox.TabIndex = 13
        Me.CustormerGroupBox.TabStop = False
        Me.CustormerGroupBox.Text = "Customer Information"
        '
        'Form12
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(410, 306)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustormerGroupBox)
        Me.Name = "Form12"
        Me.Text = "Form12"
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustormerGroupBox.ResumeLayout(False)
        Me.CustormerGroupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents DatabaseIST303DataSet4 As WindowsApplication1.DatabaseIST303DataSet4
    Friend WithEvents DatabaseIST303DataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RESERVATION_ROOMTableAdapter As WindowsApplication1.DatabaseIST303DataSet5TableAdapters.RESERVATION_ROOMTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ReservationIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PhoneNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckInDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckOutDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CheckedInDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents CheckedOutDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents RESERVATIONROOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet5 As WindowsApplication1.DatabaseIST303DataSet5
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CustormerGroupBox As System.Windows.Forms.GroupBox
End Class
