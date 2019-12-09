Imports System.Data.SqlClient
Public Class frmMember
    'Represents a single record in the MEMBER table
    Private _mstrPID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrMI As String
    Private _mstrEmail As String
    Private _mstrPhone As String
    Private _mstrPhotoPath As String

    Private report As frmMemReport
    Private MembersReport As frmMemberReportFinal
    Private objMembers As CMembers
    Private blnClearing As Boolean
    Private blnReloading As Boolean

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
        'NOTHING TO DO HERE
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



    Private Sub SearchMembers()
        lstMembers.Items.Clear()
        Dim objDR As SqlDataReader
        Try
            objDR = objMembers.GetAllMembers()
            Do While objDR.Read
                lstMembers.Items.Add(objDR.Item("PID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CDB throw the error and track it here
        End Try
        If objMembers.CurrentObject.PID <> "" Then
            lstMembers.SelectedIndex = lstMembers.FindStringExact(objMembers.CurrentObject.PID)
        End If
        blnReloading = False
        ' objDR.Close()
    End Sub

    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        objMembers = New CMembers
    End Sub

    Private Sub frmMember_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        SearchMembers()
        grpEditMembers.Enabled = False
    End Sub

    Private Sub lstMembers_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstMembers.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstMembers.SelectedIndex = -1 Then
            Exit Sub
        End If

        chkNewMember.Checked = False
        LoadSelectedRecord()
        grpEditMembers.Enabled = True
    End Sub

    Private Sub LoadSelectedRecord()
        ClearScreenControls(Me)
        Try
            objMembers.GetMemberByPID(lstMembers.SelectedItem.ToString)
            With objMembers.CurrentObject
                txtPID.Text = .PID
                txtFName.Text = .FName
                txtLName.Text = .LName
                txtMI.Text = .MI
                txtEmail.Text = .Email
                txtPhone.Text = .Phone
                txtPhoto.Text = .PhotoPath
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Member Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    'Private Sub SearchRecord()
    '    Dim params As New ArrayList
    '    Dim objDR As SqlDataReader
    '    params.Add(New SqlParameter("lname", _mstrLName))
    '    objDR = myDB.GetDataReaderBySP("sp_getMemberByLName", params)
    '    ClearScreenControls(Me)
    '    Try
    '        objMembers.GetMemberByLName(lstMembers.SelectedItem.ToString)
    '        With objMembers.CurrentObject
    '            txtPID.Text = .PID
    '            txtFName.Text = .FName
    '            txtLName.Text = .LName
    '            txtMI.Text = .MI
    '            txtEmail.Text = .Email
    '            txtPhone.Text = .Phone
    '            txtPhoto.Text = .PhotoPath
    '        End With
    '    Catch ex As Exception
    '        MessageBox.Show("Error searching Member Values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '    End Try
    'End Sub

    Private Sub chkNewMember_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewMember.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewMember.Checked Then
            tslStatus.Text = ""
            txtPID.Clear()
            txtFName.Clear()
            txtLName.Clear()
            txtMI.Clear()
            txtEmail.Clear()
            txtPhone.Clear()
            txtPhoto.Clear()
            lstMembers.SelectedIndex = -1
            grpMembers.Enabled = False
            grpEditMembers.Enabled = True
            txtPID.Focus()
            objMembers.CreateNewMember()
        Else
            grpMembers.Enabled = True
            grpEditMembers.Enabled = False
            objMembers.CurrentObject.isNewMember = False
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResults As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""
        '--- add your validation code here-----
        If Not ValidateTextBoxLength(txtPID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtFName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtMI, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPhone, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPhoto, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objMembers.CurrentObject
            .PID = txtPID.Text
            .FName = txtFName.Text
            .LName = txtLName.Text
            .MI = txtMI.Text
            .Email = txtEmail.Text
            .Phone = txtPhone.Text
            .PhotoPath = txtPhoto.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResults = objMembers.Save
            If intResults = 1 Then
                tslStatus.Text = "Member Record Saved"
                Me.Cursor = Cursors.Default
                SearchMembers()
            End If
            If intResults = -1 Then
                MessageBox.Show("PID must be unique, unable to save record", "Database error")
            End If
        Catch ex As Exception

        End Try

    End Sub

    Private Sub btnSave_ContextMenuStripChanged(sender As Object, e As EventArgs) Handles btnSave.ContextMenuStripChanged

    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        report = New frmMemReport
        report.ShowDialog()

        'Dim MembersReport As New frmMemberReportFinal
        'MembersReport.Display()

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        Dim params As New ArrayList
        Dim objDR As SqlDataReader
        lstMembers.Items.Clear()
        params.Add(New SqlParameter("@lname", txtSearch.Text))
        objDR = myDB.GetDataReaderBySP("dbo.sp_getMemberbyLName", params)
        Do While objDR.Read
            lstMembers.Items.Add(objDR.Item("PID") & " " & objDR.Item("Lname") & ", " & objDR.Item("FName"))
        Loop
        objDR.Close()
    End Sub
End Class