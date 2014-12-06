<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form7
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.DatabaseIST303DataSet3 = New WindowsApplication1.DatabaseIST303DataSet3()
        Me.CUSTOMERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet = New WindowsApplication1.DatabaseIST303DataSet()
        Me.DatabaseIST303DataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter = New WindowsApplication1.DatabaseIST303DataSetTableAdapters.roomTableAdapter()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.DatabaseIST303DataSet1 = New WindowsApplication1.DatabaseIST303DataSet1()
        Me.DatabaseIST303DataSet1BindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter1 = New WindowsApplication1.DatabaseIST303DataSet1TableAdapters.roomTableAdapter()
        Me.CUSTOMERTableAdapter = New WindowsApplication1.DatabaseIST303DataSet3TableAdapters.CUSTOMERTableAdapter()
        Me.RoomBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.RoomNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ROOMBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseIST303DataSet4 = New WindowsApplication1.DatabaseIST303DataSet4()
        Me.ROOMTableAdapter2 = New WindowsApplication1.DatabaseIST303DataSet4TableAdapters.ROOMTableAdapter()
        Me.FillByToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet1BindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.ROOMBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNoDataGridViewTextBoxColumn, Me.RoomTypeDataGridViewTextBoxColumn, Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn, Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn, Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn, Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ROOMBindingSource3
        Me.DataGridView1.Location = New System.Drawing.Point(24, 46)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(458, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'DatabaseIST303DataSet3
        '
        Me.DatabaseIST303DataSet3.DataSetName = "DatabaseIST303DataSet3"
        Me.DatabaseIST303DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CUSTOMERBindingSource
        '
        Me.CUSTOMERBindingSource.DataMember = "CUSTOMER"
        Me.CUSTOMERBindingSource.DataSource = Me.DatabaseIST303DataSet3
        '
        'DatabaseIST303DataSet
        '
        Me.DatabaseIST303DataSet.DataSetName = "DatabaseIST303DataSet"
        Me.DatabaseIST303DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseIST303DataSetBindingSource
        '
        Me.DatabaseIST303DataSetBindingSource.DataSource = Me.DatabaseIST303DataSet
        Me.DatabaseIST303DataSetBindingSource.Position = 0
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "room"
        Me.RoomBindingSource.DataSource = Me.DatabaseIST303DataSetBindingSource
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(0, 0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'DatabaseIST303DataSet1
        '
        Me.DatabaseIST303DataSet1.DataSetName = "DatabaseIST303DataSet1"
        Me.DatabaseIST303DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DatabaseIST303DataSet1BindingSource
        '
        Me.DatabaseIST303DataSet1BindingSource.DataSource = Me.DatabaseIST303DataSet1
        Me.DatabaseIST303DataSet1BindingSource.Position = 0
        '
        'RoomBindingSource1
        '
        Me.RoomBindingSource1.DataMember = "room"
        Me.RoomBindingSource1.DataSource = Me.DatabaseIST303DataSet1BindingSource
        '
        'RoomTableAdapter1
        '
        Me.RoomTableAdapter1.ClearBeforeFill = True
        '
        'CUSTOMERTableAdapter
        '
        Me.CUSTOMERTableAdapter.ClearBeforeFill = True
        '
        'RoomBindingSource2
        '
        Me.RoomBindingSource2.DataMember = "room"
        Me.RoomBindingSource2.DataSource = Me.DatabaseIST303DataSetBindingSource
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(505, 25)
        Me.FillByToolStrip.TabIndex = 2
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'RoomNoDataGridViewTextBoxColumn
        '
        Me.RoomNoDataGridViewTextBoxColumn.DataPropertyName = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.HeaderText = "Room_No"
        Me.RoomNoDataGridViewTextBoxColumn.Name = "RoomNoDataGridViewTextBoxColumn"
        '
        'RoomTypeDataGridViewTextBoxColumn
        '
        Me.RoomTypeDataGridViewTextBoxColumn.DataPropertyName = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.HeaderText = "Room_Type"
        Me.RoomTypeDataGridViewTextBoxColumn.Name = "RoomTypeDataGridViewTextBoxColumn"
        '
        'RoomSessionWeekdayPriceDataGridViewTextBoxColumn
        '
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Session_Weekday_Price"
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.HeaderText = "Room_Session_Weekday_Price"
        Me.RoomSessionWeekdayPriceDataGridViewTextBoxColumn.Name = "RoomSessionWeekdayPriceDataGridViewTextBoxColumn"
        '
        'RoomSessionWeekendPriceDataGridViewTextBoxColumn
        '
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Session_Weekend_Price"
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.HeaderText = "Room_Session_Weekend_Price"
        Me.RoomSessionWeekendPriceDataGridViewTextBoxColumn.Name = "RoomSessionWeekendPriceDataGridViewTextBoxColumn"
        '
        'RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn
        '
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Off_Session_Weekday_Price"
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.HeaderText = "Room_Off_Session_Weekday_Price"
        Me.RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn.Name = "RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn"
        '
        'RoomOffSessionWeekendPriceDataGridViewTextBoxColumn
        '
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.DataPropertyName = "Room_Off_Session_Weekend_Price"
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.HeaderText = "Room_Off_Session_Weekend_Price"
        Me.RoomOffSessionWeekendPriceDataGridViewTextBoxColumn.Name = "RoomOffSessionWeekendPriceDataGridViewTextBoxColumn"
        '
        'ROOMBindingSource3
        '
        Me.ROOMBindingSource3.DataMember = "ROOM"
        Me.ROOMBindingSource3.DataSource = Me.DatabaseIST303DataSet4
        '
        'DatabaseIST303DataSet4
        '
        Me.DatabaseIST303DataSet4.DataSetName = "DatabaseIST303DataSet4"
        Me.DatabaseIST303DataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ROOMTableAdapter2
        '
        Me.ROOMTableAdapter2.ClearBeforeFill = True
        '
        'FillByToolStrip1
        '
        Me.FillByToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton1})
        Me.FillByToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip1.Name = "FillByToolStrip1"
        Me.FillByToolStrip1.Size = New System.Drawing.Size(111, 25)
        Me.FillByToolStrip1.TabIndex = 3
        Me.FillByToolStrip1.Text = "FillByToolStrip1"
        '
        'FillByToolStripButton1
        '
        Me.FillByToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton1.Name = "FillByToolStripButton1"
        Me.FillByToolStripButton1.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton1.Text = "FillBy"
        '
        'Form7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(505, 332)
        Me.Controls.Add(Me.FillByToolStrip1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form7"
        Me.Text = "Form7"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CUSTOMERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet1BindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.ROOMBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseIST303DataSet4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip1.ResumeLayout(False)
        Me.FillByToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents DatabaseIST303DataSetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet As WindowsApplication1.DatabaseIST303DataSet
    Friend WithEvents RoomBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter As WindowsApplication1.DatabaseIST303DataSetTableAdapters.roomTableAdapter
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents DatabaseIST303DataSet1BindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet1 As WindowsApplication1.DatabaseIST303DataSet1
    Friend WithEvents RoomBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RoomTableAdapter1 As WindowsApplication1.DatabaseIST303DataSet1TableAdapters.roomTableAdapter
    Friend WithEvents DatabaseIST303DataSet3 As WindowsApplication1.DatabaseIST303DataSet3
    Friend WithEvents CUSTOMERBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CUSTOMERTableAdapter As WindowsApplication1.DatabaseIST303DataSet3TableAdapters.CUSTOMERTableAdapter
    Friend WithEvents RoomBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents DatabaseIST303DataSet4 As WindowsApplication1.DatabaseIST303DataSet4
    Friend WithEvents ROOMBindingSource3 As System.Windows.Forms.BindingSource
    Friend WithEvents ROOMTableAdapter2 As WindowsApplication1.DatabaseIST303DataSet4TableAdapters.ROOMTableAdapter
    Friend WithEvents RoomNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomSessionWeekdayPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomSessionWeekendPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomOffSessionWeekdayPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RoomOffSessionWeekendPriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents FillByToolStripButton1 As System.Windows.Forms.ToolStripButton
End Class
