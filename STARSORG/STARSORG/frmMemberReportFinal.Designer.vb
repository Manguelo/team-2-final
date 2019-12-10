<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMemberReportFinal
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.rpvMemberReport = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.CMemberBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.CMemberBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rpvMemberReport
        '
        Me.rpvMemberReport.AutoSize = True
        ReportDataSource1.Name = "dsMemberAndSecRole"
        ReportDataSource1.Value = Me.CMemberBindingSource
        Me.rpvMemberReport.LocalReport.DataSources.Add(ReportDataSource1)
        Me.rpvMemberReport.LocalReport.ReportEmbeddedResource = "STARSORG.rptMembers.rdlc"
        Me.rpvMemberReport.Location = New System.Drawing.Point(12, 12)
        Me.rpvMemberReport.Name = "rpvMemberReport"
        'Me.rpvMemberReport.ServerReport.BearerToken = Nothing
        Me.rpvMemberReport.Size = New System.Drawing.Size(1242, 427)
        Me.rpvMemberReport.TabIndex = 0
        '
        'CMemberBindingSource
        '
        Me.CMemberBindingSource.DataMember = "CMember"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(518, 456)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(112, 32)
        Me.btnClose.TabIndex = 1
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'frmMemberReportFinal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1266, 500)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.rpvMemberReport)
        Me.Name = "frmMemberReportFinal"
        Me.Text = "Member Report"
        CType(Me.CMemberBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents rpvMemberReport As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents CMemberBindingSource As BindingSource
    Friend WithEvents btnClose As Button
End Class
