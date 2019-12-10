Imports System.Data.SqlClient
Public Class frmEvents
    Private objEvents As CEvents
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private strStartDate As String
    Private strEndDate As String
#Region "Toolbar Stuff"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbRoles.MouseEnter, tsbMember.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter
        'we need to do this because we are not putting out images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbRoles.MouseLeave, tsbMember.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave
        'we need to do this because we are not putting out images in the image property of the toolbar buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub

    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        '
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

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
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
        intNextAction = ACTION_TUTOR
        Me.Hide()
    End Sub
#End Region
#Region "Textboxes"
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtEventID.GotFocus, txtEventDesc.GotFocus, txtLocation.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub

    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtEventID.GotFocus, txtEventDesc.GotFocus, txtLocation.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub
#End Region
#Region "Load Subs"
    Private Sub LoadEvents()
        Dim objDR As SqlDataReader
        lstEvents.Items.Clear()
        Try
            objDR = objEvents.GetAllEvents()
            Do While objDR.Read
                lstEvents.Items.Add(objDR.Item("EventID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CBD throw the error and trap it here
        End Try
        If objEvents.CurrentObject.EventID <> "" Then
            lstEvents.SelectedIndex = lstEvents.FindStringExact(objEvents.CurrentObject.EventID)
        End If
        blnReloading = False
    End Sub
    Private Sub LoadEventTypes()
        Dim objDR As SqlDataReader
        cboEventType.Items.Clear()
        Try
            objDR = objEvents.GetAllEventTypes()
            Do While objDR.Read
                cboEventType.Items.Add(objDR.Item("EventTypeID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CBD throw the error and trap it here
        End Try
        blnReloading = False
    End Sub
    Private Sub LoadSemIDs()
        Dim objDR As SqlDataReader
        cboSemester.Items.Clear()
        Try
            objDR = objEvents.GetAllSemesterID()
            Do While objDR.Read
                cboSemester.Items.Add(objDR.Item("SemesterID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CBD throw the error and trap it here
        End Try
        blnReloading = False
    End Sub

    Private Sub frmEvents_Load(sender As Object, e As EventArgs) Handles Me.Load
        objEvents = New CEvents
    End Sub
#End Region
    Private Sub frmEvents_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Select Case currentSecurity.SecRole
            Case MEMBER_ROLE
            Case GUEST_ROLE
                btnCreate.Enabled = False
                btnModify.Enabled = False
        End Select
        ClearScreenControls(Me)
        LoadEvents()
        LoadEventTypes()
        LoadSemIDs()
        grpSave.Enabled = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        SatusStrip1.Text = ""
        '----- add your validation code here -------
        If Not ValidateTextBoxLength(txtEventID, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEventDesc, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboEventType, errP) Then
            blnErrors = True
        End If
        If Not ValidateCombo(cboSemester, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEventDesc, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLocation, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEventDesc, errP) Then
            blnErrors = True
        End If
        If mclEventRange.SelectionStart <= Today Then
            errP.SetError(mclEventRange, "You must select a future date range")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objEvents.CurrentObject
            .EventID = txtEventID.Text
            .EventDescription = txtEventDesc.Text
            .EventTypeID = cboEventType.SelectedItem.ToString
            .SemesterID = cboSemester.SelectedItem.ToString
            .StartDate = mclEventRange.SelectionStart.ToShortDateString
            .EndDate = mclEventRange.SelectionEnd.ToShortDateString
            .Location = txtLocation.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objEvents.Save
            If intResult = 1 Then
                tslStatusEvent.Text = "Event record saved"
            End If
            If intResult = -1 Then 'EventID was not unique when adding a new record
                MessageBox.Show("Unable to save Event record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatusEvent.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Role record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatusEvent.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadEvents() 'reload so that a newly saved record will appear in the list
        grpSave.Enabled = False
        grpModify.Enabled = True
    End Sub
    Private Sub lstRoles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstEvents.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            'tslStatus.Text = ""
            Exit Sub
        End If
        If lstEvents.SelectedIndex = -1 Then
            Exit Sub
        End If
        grpSave.Enabled = False
        LoadSelectedRecord()
    End Sub
    Private Sub LoadSelectedRecord()
        Try
            objEvents.GetEventByEventID(lstEvents.SelectedItem.ToString)
            With objEvents.CurrentObject
                txtEventID.Text = .EventID
                txtEventDesc.Text = .EventDescription
                cboEventType.SelectedItem = .EventTypeID
                cboSemester.SelectedItem = .SemesterID
                mclEventRange.SelectionStart = .StartDate
                mclEventRange.SelectionEnd = .EndDate
                txtLocation.Text = .Location
            End With
        Catch ex As Exception
            MessageBox.Show("Error loading Event values: " & ex.ToString, "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

#Region "Button Functions"
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        txtEventID.Clear()
        txtEventDesc.Clear()
        mclEventRange.SelectionStart = Today
        mclEventRange.SelectionEnd = Today
        txtLocation.Clear()
        lstEvents.SelectedIndex = -1
        cboEventType.SelectedIndex = -1
        cboSemester.SelectedIndex = -1
        grpModify.Enabled = False
        grpSave.Enabled = True
        enableInputs()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        txtEventID.Clear()
        txtEventDesc.Clear()
        mclEventRange.SelectionStart = Today
        mclEventRange.SelectionEnd = Today
        txtLocation.Clear()
        lstEvents.SelectedIndex = -1
        cboEventType.SelectedIndex = -1
        cboSemester.SelectedIndex = -1
        grpSave.Enabled = False
        grpModify.Enabled = True
    End Sub

    Private Sub btnModify_Click(sender As Object, e As EventArgs) Handles btnModify.Click
        If objEvents.CurrentObject.StartDate < Today Then
            txtEventDesc.Enabled = False
            cboSemester.Enabled = False
            txtLocation.Enabled = False
            mclEventRange.Enabled = False
        Else
            enableInputs()
        End If
        txtEventID.Enabled = False
        grpSave.Enabled = True
    End Sub
#End Region
    Private Sub enableInputs()
        txtEventID.Enabled = True
        txtEventDesc.Enabled = True
        cboSemester.Enabled = True
        txtLocation.Enabled = True
        mclEventRange.Enabled = True
    End Sub
End Class