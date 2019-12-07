<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.UkidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EVENTRSVPBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STARSDBDataSet = New STARSORG.STARSDBDataSet()
        Me.EVENT_RSVPTableAdapter = New STARSORG.STARSDBDataSetTableAdapters.EVENT_RSVPTableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EVENTRSVPBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UkidDataGridViewTextBoxColumn, Me.EventIDDataGridViewTextBoxColumn, Me.FNameDataGridViewTextBoxColumn, Me.LNameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EVENTRSVPBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(12, 12)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(679, 426)
        Me.DataGridView1.TabIndex = 0
        '
        'UkidDataGridViewTextBoxColumn
        '
        Me.UkidDataGridViewTextBoxColumn.DataPropertyName = "ukid"
        Me.UkidDataGridViewTextBoxColumn.HeaderText = "ukid"
        Me.UkidDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.UkidDataGridViewTextBoxColumn.Name = "UkidDataGridViewTextBoxColumn"
        Me.UkidDataGridViewTextBoxColumn.ReadOnly = True
        Me.UkidDataGridViewTextBoxColumn.Width = 125
        '
        'EventIDDataGridViewTextBoxColumn
        '
        Me.EventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID"
        Me.EventIDDataGridViewTextBoxColumn.HeaderText = "EventID"
        Me.EventIDDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EventIDDataGridViewTextBoxColumn.Name = "EventIDDataGridViewTextBoxColumn"
        Me.EventIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.EventIDDataGridViewTextBoxColumn.Width = 125
        '
        'FNameDataGridViewTextBoxColumn
        '
        Me.FNameDataGridViewTextBoxColumn.DataPropertyName = "FName"
        Me.FNameDataGridViewTextBoxColumn.HeaderText = "FName"
        Me.FNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.FNameDataGridViewTextBoxColumn.Name = "FNameDataGridViewTextBoxColumn"
        Me.FNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.FNameDataGridViewTextBoxColumn.Width = 125
        '
        'LNameDataGridViewTextBoxColumn
        '
        Me.LNameDataGridViewTextBoxColumn.DataPropertyName = "LName"
        Me.LNameDataGridViewTextBoxColumn.HeaderText = "LName"
        Me.LNameDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.LNameDataGridViewTextBoxColumn.Name = "LNameDataGridViewTextBoxColumn"
        Me.LNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.LNameDataGridViewTextBoxColumn.Width = 125
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.MinimumWidth = 6
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        Me.EmailDataGridViewTextBoxColumn.ReadOnly = True
        Me.EmailDataGridViewTextBoxColumn.Width = 125
        '
        'EVENTRSVPBindingSource
        '
        Me.EVENTRSVPBindingSource.DataMember = "EVENT_RSVP"
        Me.EVENTRSVPBindingSource.DataSource = Me.STARSDBDataSet
        '
        'STARSDBDataSet
        '
        Me.STARSDBDataSet.DataSetName = "STARSDBDataSet"
        Me.STARSDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EVENT_RSVPTableAdapter
        '
        Me.EVENT_RSVPTableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(522, 444)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(169, 45)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(706, 500)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "frmReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EVENTRSVPBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STARSDBDataSet As STARSDBDataSet
    Friend WithEvents EVENTRSVPBindingSource As BindingSource
    Friend WithEvents EVENT_RSVPTableAdapter As STARSDBDataSetTableAdapters.EVENT_RSVPTableAdapter
    Friend WithEvents UkidDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EventIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class
