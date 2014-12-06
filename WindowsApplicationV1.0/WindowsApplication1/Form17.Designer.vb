<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form17
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TRAIL_RIDINGTableAdapter = New WindowsApplication1.DatabaseIST303DataSet7TableAdapters.TRAIL_RIDINGTableAdapter()
        Me.RESERVATIONROOMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet5 = New WindowsApplication1.DatabaseIST303DataSet5()
        Me.MASSAGETableAdapter = New WindowsApplication1.DatabaseIST303DataSet9TableAdapters.MASSAGETableAdapter()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.GUIDED_HIKINGTableAdapter = New WindowsApplication1.DatabaseIST303DataSet8TableAdapters.GUIDED_HIKINGTableAdapter()
        Me.GUIDEDHIKINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet8 = New WindowsApplication1.DatabaseIST303DataSet8()
        Me.DatabaseIST303DataSet7BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet7 = New WindowsApplication1.DatabaseIST303DataSet7()
        Me.TRAILRIDINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CustormerGroupBox = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.LASSOINGBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet10 = New WindowsApplication1.DatabaseIST303DataSet10()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.MASSAGEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet9 = New WindowsApplication1.DatabaseIST303DataSet9()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.RESERVATION_ROOMTableAdapter = New WindowsApplication1.DatabaseIST303DataSet5TableAdapters.RESERVATION_ROOMTableAdapter()
        Me.DatabaseIST303DataSet4 = New WindowsApplication1.DatabaseIST303DataSet4()
        Me.DatabaseIST303DataSet4BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LASSOINGTableAdapter = New WindowsApplication1.DatabaseIST303DataSet10TableAdapters.LASSOINGTableAdapter()
        Me.LC_ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LC_date = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LC_time = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LC_Type = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Phone_No = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GUIDEDHIKINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet7BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TRAILRIDINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CustormerGroupBox.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LASSOINGBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MASSAGEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet4BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(163, 13)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "Enter Custormer Phone Number:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(191, 6)
        Me.TextBox3.MaxLength = 10
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.TextBox3.TabIndex = 38
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
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(129, 24)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(57, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Last Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(132, 40)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 13
        '
        'TRAIL_RIDINGTableAdapter
        '
        Me.TRAIL_RIDINGTableAdapter.ClearBeforeFill = True
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
        'MASSAGETableAdapter
        '
        Me.MASSAGETableAdapter.ClearBeforeFill = True
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(17, 40)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.ReadOnly = True
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 14
        '
        'GUIDED_HIKINGTableAdapter
        '
        Me.GUIDED_HIKINGTableAdapter.ClearBeforeFill = True
        '
        'GUIDEDHIKINGBindingSource
        '
        Me.GUIDEDHIKINGBindingSource.DataMember = "GUIDED_HIKING"
        Me.GUIDEDHIKINGBindingSource.DataSource = Me.DatabaseIST303DataSet8
        '
        'DatabaseIST303DataSet8
        '
        Me.DatabaseIST303DataSet8.DataSetName = "DatabaseIST303DataSet8"
        Me.DatabaseIST303DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseIST303DataSet7BindingSource
        '
        Me.DatabaseIST303DataSet7BindingSource.DataSource = Me.DatabaseIST303DataSet7
        Me.DatabaseIST303DataSet7BindingSource.Position = 0
        '
        'DatabaseIST303DataSet7
        '
        Me.DatabaseIST303DataSet7.DataSetName = "DatabaseIST303DataSet7"
        Me.DatabaseIST303DataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TRAILRIDINGBindingSource
        '
        Me.TRAILRIDINGBindingSource.DataMember = "TRAIL_RIDING"
        Me.TRAILRIDINGBindingSource.DataSource = Me.DatabaseIST303DataSet7
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
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Location = New System.Drawing.Point(297, 6)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 20)
        Me.Button1.TabIndex = 39
        Me.Button1.Text = "Search..."
        Me.Button1.UseVisualStyleBackColor = False
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
        Me.CustormerGroupBox.Size = New System.Drawing.Size(383, 266)
        Me.CustormerGroupBox.TabIndex = 36
        Me.CustormerGroupBox.TabStop = False
        Me.CustormerGroupBox.Text = "Customer Information"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.LC_ID, Me.LC_date, Me.LC_time, Me.LC_Type, Me.Column1, Me.Phone_No})
        Me.DataGridView1.DataSource = Me.LASSOINGBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(17, 114)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(356, 146)
        Me.DataGridView1.TabIndex = 23
        '
        'LASSOINGBindingSource
        '
        Me.LASSOINGBindingSource.DataMember = "LASSOING"
        Me.LASSOINGBindingSource.DataSource = Me.DatabaseIST303DataSet10
        '
        'DatabaseIST303DataSet10
        '
        Me.DatabaseIST303DataSet10.DataSetName = "DatabaseIST303DataSet10"
        Me.DatabaseIST303DataSet10.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(172, 79)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.ReadOnly = True
        Me.TextBox5.Size = New System.Drawing.Size(60, 20)
        Me.TextBox5.TabIndex = 20
        '
        'MASSAGEBindingSource
        '
        Me.MASSAGEBindingSource.DataMember = "MASSAGE"
        Me.MASSAGEBindingSource.DataSource = Me.DatabaseIST303DataSet9
        '
        'DatabaseIST303DataSet9
        '
        Me.DatabaseIST303DataSet9.DataSetName = "DatabaseIST303DataSet9"
        Me.DatabaseIST303DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Green
        Me.Label4.Location = New System.Drawing.Point(12, 186)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 25)
        Me.Label4.TabIndex = 40
        '
        'RESERVATION_ROOMTableAdapter
        '
        Me.RESERVATION_ROOMTableAdapter.ClearBeforeFill = True
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
        'LASSOINGTableAdapter
        '
        Me.LASSOINGTableAdapter.ClearBeforeFill = True
        '
        'LC_ID
        '
        Me.LC_ID.DataPropertyName = "LC_ID"
        Me.LC_ID.HeaderText = "LC_ID"
        Me.LC_ID.Name = "LC_ID"
        Me.LC_ID.Visible = False
        '
        'LC_date
        '
        Me.LC_date.DataPropertyName = "LC_date"
        Me.LC_date.HeaderText = "Date"
        Me.LC_date.Name = "LC_date"
        '
        'LC_time
        '
        Me.LC_time.DataPropertyName = "LC_time"
        Me.LC_time.HeaderText = "Time"
        Me.LC_time.Name = "LC_time"
        '
        'LC_Type
        '
        Me.LC_Type.DataPropertyName = "LC_Type"
        Me.LC_Type.HeaderText = "Type"
        Me.LC_Type.Name = "LC_Type"
        Me.LC_Type.Width = 50
        '
        'Column1
        '
        Me.Column1.HeaderText = "Select"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.Width = 40
        '
        'Phone_No
        '
        Me.Phone_No.DataPropertyName = "Phone_No"
        Me.Phone_No.HeaderText = "Phone_No"
        Me.Phone_No.Name = "Phone_No"
        Me.Phone_No.Visible = False
        '
        'Form17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightPink
        Me.ClientSize = New System.Drawing.Size(409, 305)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CustormerGroupBox)
        Me.Controls.Add(Me.Label4)
        Me.Name = "Form17"
        Me.Text = "Form17"
        CType(Me.RESERVATIONROOMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GUIDEDHIKINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet7BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TRAILRIDINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CustormerGroupBox.ResumeLayout(False)
        Me.CustormerGroupBox.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LASSOINGBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MASSAGEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet4BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TRAIL_RIDINGTableAdapter As WindowsApplication1.DatabaseIST303DataSet7TableAdapters.TRAIL_RIDINGTableAdapter
    Friend WithEvents RESERVATIONROOMBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet5 As WindowsApplication1.DatabaseIST303DataSet5
    Friend WithEvents MASSAGETableAdapter As WindowsApplication1.DatabaseIST303DataSet9TableAdapters.MASSAGETableAdapter
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents GUIDED_HIKINGTableAdapter As WindowsApplication1.DatabaseIST303DataSet8TableAdapters.GUIDED_HIKINGTableAdapter
    Friend WithEvents GUIDEDHIKINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet8 As WindowsApplication1.DatabaseIST303DataSet8
    Friend WithEvents DatabaseIST303DataSet7BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet7 As WindowsApplication1.DatabaseIST303DataSet7
    Friend WithEvents TRAILRIDINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents CustormerGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents MASSAGEBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet9 As WindowsApplication1.DatabaseIST303DataSet9
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents RESERVATION_ROOMTableAdapter As WindowsApplication1.DatabaseIST303DataSet5TableAdapters.RESERVATION_ROOMTableAdapter
    Friend WithEvents DatabaseIST303DataSet4 As WindowsApplication1.DatabaseIST303DataSet4
    Friend WithEvents DatabaseIST303DataSet4BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet10 As WindowsApplication1.DatabaseIST303DataSet10
    Friend WithEvents LASSOINGBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LASSOINGTableAdapter As WindowsApplication1.DatabaseIST303DataSet10TableAdapters.LASSOINGTableAdapter
    Friend WithEvents LC_ID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LC_date As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LC_time As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LC_Type As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents Phone_No As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
