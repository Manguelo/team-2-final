Public Class frmSemesterReport
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub FrmSemesterReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STARS_Semster_Data.SEMESTER' table. You can move, or remove it, as needed.
        Me.SEMESTERTableAdapter.Fill(Me.STARS_Semster_Data.SEMESTER)
        Me.TopMost = True
    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.SEMESTERTableAdapter.FillBy(Me.STARS_Semster_Data.SEMESTER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class