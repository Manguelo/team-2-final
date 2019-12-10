Public Class frmCourseReport
    Private Sub FrmCourseReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STARSDBDataSet_Course_Table.COURSE' table. You can move, or remove it, as needed.
        Me.COURSETableAdapter.Fill(Me.STARSDBDataSet_Course_Table.COURSE)
        Me.TopMost = True
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class