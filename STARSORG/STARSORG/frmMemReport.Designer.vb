<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMemReport
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
        Me.STARSDBDataSetMembers = New STARSORG.STARSDBDataSetMembers()
        Me.STARSDBDataSetMembersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FillByToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FillByToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.MEMBERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STARSDBDataSet = New STARSORG.STARSDBDataSet()
        Me.MEMBERTableAdapter = New STARSORG.STARSDBDataSetMembersTableAdapters.MEMBERTableAdapter()
        Me.STARSDBDataSet1 = New STARSORG.STARSDBDataSet()
        Me.SECURITYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECURITYTableAdapter = New STARSORG.STARSDBDataSetMembersTableAdapters.SECURITYTableAdapter()
        Me.MEMBERBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERTableAdapter1 = New STARSORG.STARSDBDataSetMembersTableAdapters.MEMBERTableAdapter()
        Me.SECURITYBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECURITYTableAdapter1 = New STARSORG.STARSDBDataSetMembersTableAdapters.SECURITYTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.MEMBERBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MEMBERBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SECURITYBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SecRoleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.MEMBERBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.STARSDBDataSetMembers, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBDataSetMembersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByToolStrip.SuspendLayout()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECURITYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECURITYBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SECURITYBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MEMBERBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'STARSDBDataSetMembers
        '
        Me.STARSDBDataSetMembers.DataSetName = "STARSDBDataSetMembers"
        Me.STARSDBDataSetMembers.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STARSDBDataSetMembersBindingSource
        '
        Me.STARSDBDataSetMembersBindingSource.DataSource = Me.STARSDBDataSetMembers
        Me.STARSDBDataSetMembersBindingSource.Position = 0
        '
        'FillByToolStrip
        '
        Me.FillByToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FillByToolStripButton})
        Me.FillByToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.FillByToolStrip.Name = "FillByToolStrip"
        Me.FillByToolStrip.Size = New System.Drawing.Size(573, 25)
        Me.FillByToolStrip.TabIndex = 1
        Me.FillByToolStrip.Text = "FillByToolStrip"
        '
        'FillByToolStripButton
        '
        Me.FillByToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByToolStripButton.Name = "FillByToolStripButton"
        Me.FillByToolStripButton.Size = New System.Drawing.Size(39, 22)
        Me.FillByToolStripButton.Text = "FillBy"
        '
        'MEMBERBindingSource
        '
        Me.MEMBERBindingSource.DataMember = "MEMBER"
        Me.MEMBERBindingSource.DataSource = Me.STARSDBDataSet
        '
        'STARSDBDataSet
        '
        Me.STARSDBDataSet.DataSetName = "STARSDBDataSet"
        Me.STARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MEMBERTableAdapter
        '
        Me.MEMBERTableAdapter.ClearBeforeFill = True
        '
        'STARSDBDataSet1
        '
        Me.STARSDBDataSet1.DataSetName = "STARSDBDataSet1"
        Me.STARSDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SECURITYBindingSource
        '
        Me.SECURITYBindingSource.DataMember = "SECURITY"
        Me.SECURITYBindingSource.DataSource = Me.STARSDBDataSet1
        '
        'SECURITYTableAdapter
        '
        Me.SECURITYTableAdapter.ClearBeforeFill = True
        '
        'MEMBERBindingSource1
        '
        Me.MEMBERBindingSource1.DataMember = "MEMBER"
        Me.MEMBERBindingSource1.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'MEMBERTableAdapter1
        '
        Me.MEMBERTableAdapter1.ClearBeforeFill = True
        '
        'SECURITYBindingSource1
        '
        Me.SECURITYBindingSource1.DataMember = "SECURITY"
        Me.SECURITYBindingSource1.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'SECURITYTableAdapter1
        '
        Me.SECURITYTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SecRoleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SECURITYBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(35, 28)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(156, 366)
        Me.DataGridView1.TabIndex = 2
        '
        'MEMBERBindingSource2
        '
        Me.MEMBERBindingSource2.DataMember = "MEMBER"
        Me.MEMBERBindingSource2.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'MEMBERBindingSource3
        '
        Me.MEMBERBindingSource3.DataMember = "MEMBER"
        Me.MEMBERBindingSource3.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'SECURITYBindingSource2
        '
        Me.SECURITYBindingSource2.DataMember = "SECURITY"
        Me.SECURITYBindingSource2.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'SecRoleDataGridViewTextBoxColumn
        '
        Me.SecRoleDataGridViewTextBoxColumn.DataPropertyName = "SecRole"
        Me.SecRoleDataGridViewTextBoxColumn.HeaderText = "SecRole"
        Me.SecRoleDataGridViewTextBoxColumn.Name = "SecRoleDataGridViewTextBoxColumn"
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PIDDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.MEMBERBindingSource4
        Me.DataGridView2.Location = New System.Drawing.Point(210, 28)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(353, 366)
        Me.DataGridView2.TabIndex = 3
        '
        'MEMBERBindingSource4
        '
        Me.MEMBERBindingSource4.DataMember = "MEMBER"
        Me.MEMBERBindingSource4.DataSource = Me.STARSDBDataSetMembersBindingSource
        '
        'PIDDataGridViewTextBoxColumn
        '
        Me.PIDDataGridViewTextBoxColumn.DataPropertyName = "PID"
        Me.PIDDataGridViewTextBoxColumn.HeaderText = "PID"
        Me.PIDDataGridViewTextBoxColumn.Name = "PIDDataGridViewTextBoxColumn"
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FName"
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LName"
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        '
        'frmMemReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 398)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.FillByToolStrip)
        Me.Name = "frmMemReport"
        Me.Text = "Members Report"
        CType(Me.STARSDBDataSetMembers, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBDataSetMembersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByToolStrip.ResumeLayout(False)
        Me.FillByToolStrip.PerformLayout()
        CType(Me.MEMBERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECURITYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECURITYBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SECURITYBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MEMBERBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents STARSDBDataSetMembersBindingSource As BindingSource
    Friend WithEvents STARSDBDataSetMembers As STARSDBDataSetMembers
    Friend WithEvents STARSDBDataSet As STARSDBDataSet
    Friend WithEvents MEMBERBindingSource As BindingSource
    Friend WithEvents MEMBERTableAdapter As STARSDBDataSetMembersTableAdapters.MEMBERTableAdapter
    Friend WithEvents FillByToolStrip As ToolStrip
    Friend WithEvents FillByToolStripButton As ToolStripButton
    Friend WithEvents STARSDBDataSet1 As STARSDBDataSet
    Friend WithEvents SECURITYBindingSource As BindingSource
    Friend WithEvents SECURITYTableAdapter As STARSDBDataSetMembersTableAdapters.SECURITYTableAdapter
    Friend WithEvents MEMBERBindingSource1 As BindingSource
    Friend WithEvents MEMBERTableAdapter1 As STARSDBDataSetMembersTableAdapters.MEMBERTableAdapter
    Friend WithEvents SECURITYBindingSource1 As BindingSource
    Friend WithEvents SECURITYTableAdapter1 As STARSDBDataSetMembersTableAdapters.SECURITYTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents MEMBERBindingSource2 As BindingSource
    Friend WithEvents MEMBERBindingSource3 As BindingSource
    Friend WithEvents SECURITYBindingSource2 As BindingSource
    Friend WithEvents SecRoleDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents MEMBERBindingSource4 As BindingSource
    Friend WithEvents PIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
