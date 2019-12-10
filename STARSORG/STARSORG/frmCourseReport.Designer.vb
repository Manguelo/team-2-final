<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCourseReport
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
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.COURSEBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STARSDBDataSet_Course_Table = New STARSORG.STARSDBDataSet_Course_Table()
        Me.STARSDB_Course = New STARSORG.STARSDB_Course()
        Me.STARSDBCourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.STARSDBCourseBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.COURSETableAdapter = New STARSORG.STARSDBDataSet_Course_TableTableAdapters.COURSETableAdapter()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.COURSEBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBDataSet_Course_Table, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDB_Course, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBCourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STARSDBCourseBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.COURSEBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(6, 6)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersWidth = 82
        Me.DataGridView1.RowTemplate.Height = 33
        Me.DataGridView1.Size = New System.Drawing.Size(381, 214)
        Me.DataGridView1.TabIndex = 0
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseIDDataGridViewTextBoxColumn.Width = 200
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.MinimumWidth = 10
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.CourseNameDataGridViewTextBoxColumn.Width = 200
        '
        'COURSEBindingSource
        '
        Me.COURSEBindingSource.DataMember = "COURSE"
        Me.COURSEBindingSource.DataSource = Me.STARSDBDataSet_Course_Table
        '
        'STARSDBDataSet_Course_Table
        '
        Me.STARSDBDataSet_Course_Table.DataSetName = "STARSDBDataSet_Course_Table"
        Me.STARSDBDataSet_Course_Table.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STARSDB_Course
        '
        Me.STARSDB_Course.DataSetName = "STARSDB_Course"
        Me.STARSDB_Course.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'STARSDBCourseBindingSource
        '
        Me.STARSDBCourseBindingSource.DataSource = Me.STARSDB_Course
        Me.STARSDBCourseBindingSource.Position = 0
        '
        'STARSDBCourseBindingSource1
        '
        Me.STARSDBCourseBindingSource1.DataSource = Me.STARSDB_Course
        Me.STARSDBCourseBindingSource1.Position = 0
        '
        'COURSETableAdapter
        '
        Me.COURSETableAdapter.ClearBeforeFill = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(326, 230)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(61, 22)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmCourseReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(395, 258)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.DataGridView1)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "frmCourseReport"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Course Report"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.COURSEBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBDataSet_Course_Table, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDB_Course, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBCourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STARSDBCourseBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents STARSDB_Course As STARSDB_Course
    Friend WithEvents STARSDBCourseBindingSource As BindingSource
    Friend WithEvents STARSDBCourseBindingSource1 As BindingSource
    Friend WithEvents STARSDBDataSet_Course_Table As STARSDBDataSet_Course_Table
    Friend WithEvents COURSEBindingSource As BindingSource
    Friend WithEvents COURSETableAdapter As STARSDBDataSet_Course_TableTableAdapters.COURSETableAdapter
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents btnClose As Button
End Class
