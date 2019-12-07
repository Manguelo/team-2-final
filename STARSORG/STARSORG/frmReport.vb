Public Class frmReport
    Private Sub FrmReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STARSDBDataSet.EVENT_RSVP' table. You can move, or remove it, as needed.
        Me.EVENT_RSVPTableAdapter.Fill(Me.STARSDBDataSet.EVENT_RSVP)

    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs)
        Try
            Me.EVENT_RSVPTableAdapter.FillBy(Me.STARSDBDataSet.EVENT_RSVP)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class