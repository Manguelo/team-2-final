Imports System.Data.SqlClient
Public Class frmAdmin
    Dim objSecurities As CSecurities
    Dim secResult As CSecurity
#Region "Toolbar Routines"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'We need to do this only because we are not putting our images in the image property of the toolbra buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'We need to do this only because we are not putting our images in the image property of the toolbra buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        intNextAction = ACTION_EVENT
        Me.Hide()
    End Sub

    Private Sub tsbHelp_Click(sender As Object, e As EventArgs) Handles tsbHelp.Click
        intNextAction = ACTION_HELP
        Me.Hide()
    End Sub

    Private Sub tsbHome_Click(sender As Object, e As EventArgs) Handles tsbHome.Click
        intNextAction = ACTION_HOME
        Me.Hide()
    End Sub

    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        Me.Hide()
    End Sub

    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        intNextAction = ACTION_MEMBER
        Me.Hide()
    End Sub

    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        intNextAction = ACTION_RSVP
        Me.Hide()
    End Sub

    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub
#End Region
    Private Sub frmAdmin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecurities = New CSecurities
        secResult = New CSecurity

        ' Add roles
        cboRole.Items.Add(ADMIN)
        cboRole.Items.Add(OFFICER)
        cboRole.Items.Add(MEMBER)
        cboRole.Items.Add(GUEST)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtUserID, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        'input is valid!
        secResult = objSecurities.GetSecurityForUserID(txtUserID.Text)
        If secResult.PID = "" Then
            ClearScreenControls(Me)
            MessageBox.Show("Unable to find specified User ID", "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        ' we got some good stuff
        txtUpdateUserID.Text = secResult.UserID
        txtUpdatePassword.Text = secResult.Password
        txtPID.Text = secResult.PID
        grpUpdate.Enabled = True
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        ClearScreenControls(Me)
        errP.Clear()
        secResult = New CSecurity
        grpUpdate.Enabled = False
    End Sub

    Private Sub chkNewMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMember.CheckedChanged
        If chkNewMember.Checked = True Then
            btnSearch.Enabled = False
            txtUserID.Enabled = False
            grpUpdate.Enabled = True
            txtPID.Enabled = True
        Else
            btnSearch.Enabled = True
            txtUserID.Enabled = True
            grpUpdate.Enabled = False
            txtPID.Enabled = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtUpdateUserID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtUpdatePassword, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPID, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboRole, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        If objSecurities.CheckPIDExists(txtPID.Text) = 0 Then
            ' the PID is invalid
            MessageBox.Show("Unable to find specified Panther ID", "PID Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' We're good!
        With objSecurities.CurrentObject
            .PID = txtPID.Text
            .SecRole = cboRole.SelectedItem
            .UserID = txtUpdateUserID.Text
            .Password = txtUpdatePassword.Text
        End With
        objSecurities.Save()
        objSecurities.Clear()
        btnCancel.PerformClick()
        MessageBox.Show("Security was successfully updated", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class