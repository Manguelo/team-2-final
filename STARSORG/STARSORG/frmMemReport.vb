Public Class frmMemReport
    Private Sub frmMemReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter1.Fill(Me.STARSDBDataSetMembers.MEMBER)
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.SECURITY' table. You can move, or remove it, as needed.
        Me.SECURITYTableAdapter1.Fill(Me.STARSDBDataSetMembers.SECURITY)
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter1.Fill(Me.STARSDBDataSetMembers.MEMBER)
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter1.Fill(Me.STARSDBDataSetMembers.MEMBER)
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.SECURITY' table. You can move, or remove it, as needed.
        Me.SECURITYTableAdapter1.Fill(Me.STARSDBDataSetMembers.SECURITY)
        'TODO: This line of code loads data into the 'STARSDBDataSetMembers.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter1.Fill(Me.STARSDBDataSetMembers.MEMBER)
        'TODO: This line of code loads data into the 'STARSDBDataSet1.SECURITY' table. You can move, or remove it, as needed.
        Me.SECURITYTableAdapter.Fill(Me.STARSDBDataSet1.SECURITY)
        'TODO: This line of code loads data into the 'STARSDBDataSet.MEMBER' table. You can move, or remove it, as needed.
        Me.MEMBERTableAdapter.Fill(Me.STARSDBDataSet.MEMBER)


    End Sub

    Private Sub FillByToolStripButton_Click(sender As Object, e As EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.MEMBERTableAdapter.FillBy(Me.STARSDBDataSet.MEMBER)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub
End Class