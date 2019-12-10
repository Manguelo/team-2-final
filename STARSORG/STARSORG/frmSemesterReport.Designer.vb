<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSemesterReport
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
        Me.SemesterIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SemesterDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SEMESTERBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STARS_Semster_Data = New STARSORG.STARS_Semster_Data()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SEMESTERTableAdapter = New STARSORG.STARS_Semster_DataTableAdapters.SEMESTERTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SEMESTERBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARS_Semster_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.SemesterIDDataGridViewTextBoxColumn, Me.SemesterDescriptionDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.SEMESTERBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(510, 249)
        Me.DataGridView1.TabIndex = 0
        '
        'SemesterIDDataGridViewTextBoxColumn
        '
        Me.SemesterIDDataGridViewTextBoxColumn.DataPropertyName = "SemesterID"
        Me.SemesterIDDataGridViewTextBoxColumn.HeaderText = "SemesterID"
        Me.SemesterIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SemesterIDDataGridViewTextBoxColumn.Name = "SemesterIDDataGridViewTextBoxColumn"
        Me.SemesterIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.SemesterIDDataGridViewTextBoxColumn.Width = 200
        '
        'SemesterDescriptionDataGridViewTextBoxColumn
        '
        Me.SemesterDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SemesterDescription"
        Me.SemesterDescriptionDataGridViewTextBoxColumn.HeaderText = "SemesterDescription"
        Me.SemesterDescriptionDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.SemesterDescriptionDataGridViewTextBoxColumn.Name = "SemesterDescriptionDataGridViewTextBoxColumn"
        Me.SemesterDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.SemesterDescriptionDataGridViewTextBoxColumn.Width = 200
        '
        'SEMESTERBindingSource
        '
        Me.SEMESTERBindingSource.DataMember = "SEMESTER"
        Me.SEMESTERBindingSource.DataSource = Me.STARS_Semster_Data
        '
        'STARS_Semster_Data
        '
        Me.STARS_Semster_Data.DataSetName = "STARS_Semster_Data"
        Me.STARS_Semster_Data.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(444, 258)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 26)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'SEMESTERTableAdapter
        '
        Me.SEMESTERTableAdapter.ClearBeforeFill = True
        '
        'frmSemesterReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(522, 313)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmSemesterReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semester Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SEMESTERBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARS_Semster_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STARS_Semster_Data As STARS_Semster_Data
    Friend WithEvents SEMESTERBindingSource As BindingSource
    Friend WithEvents SEMESTERTableAdapter As STARS_Semster_DataTableAdapters.SEMESTERTableAdapter
    Friend WithEvents SemesterIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SemesterDescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class
