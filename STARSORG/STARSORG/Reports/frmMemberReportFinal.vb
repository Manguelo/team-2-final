Imports System.Data.SqlClient
Imports Microsoft.Reporting.WinForms
Public Class frmMemberReportFinal
    Private ds As DataSet
    Private da As SqlDataAdapter
    Private Member As CMember

    Private Sub frmMemberReportFinal_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.ReportViewer1.RefreshReport()
    End Sub

    Public Sub Display()
        Member = New CMember
        ReportViewer1.LocalReport.ReportPath = AppDomain.CurrentDomain.BaseDirectory & "Reports\rptMembers.rdlc"
        ds = New DataSet
        da = Member.GetReportData
        da.Fill(ds)
        ReportViewer1.LocalReport.DataSources.Add(New ReportDataSource("dsMemberAndSecRole", ds.Tables(0)))
        ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout)
        ReportViewer1.RefreshReport()
        Me.Cursor = Cursors.Default
        Me.ShowDialog()
    End Sub

End Class