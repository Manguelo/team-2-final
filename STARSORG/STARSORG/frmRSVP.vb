Imports System.Data.SqlClient
Public Class frmRSVP
    Private objRSVP As CRSVPs
    Private objEvent As CEvents
    Private blnClearing As Boolean
    Private blnReloading As Boolean
    Private report As frmReport
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

    Private Sub tsbRoles_Click(sender As Object, e As EventArgs) Handles tsbRoles.Click
        intNextAction = ACTION_ROLE
        Me.Hide()
    End Sub

    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
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
    Private Sub txtBoxes_GotFocus(sender As Object, e As EventArgs) Handles txtFirstName.GotFocus, txtLastName.GotFocus, txtEmail.GotFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.SelectAll()
    End Sub

    Private Sub txtBoxes_LostFocus(sender As Object, e As EventArgs) Handles txtFirstName.LostFocus, txtLastName.LostFocus, txtEmail.LostFocus
        Dim txtBox As TextBox
        txtBox = DirectCast(sender, TextBox)
        txtBox.DeselectAll()
    End Sub
#End Region
    Private Sub LoadEvents()
        Dim objDR As SqlDataReader
        lstEvents.Items.Clear()
        Try
            objDR = objRSVP.GetAllEvents()
            Do While objDR.Read
                lstEvents.Items.Add(objDR.Item("EventID"))
            Loop
            objDR.Close()
        Catch ex As Exception
            'could have CBD throw the error and trap it here
        End Try
        blnReloading = False
    End Sub
    Private Sub frmRSVP_Load(sender As Object, e As EventArgs) Handles Me.Load
        objRSVP = New CRSVPs
    End Sub
    Private Sub frmRSVP_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadEvents()
    End Sub

    Private Sub btnRSVP_Click(sender As Object, e As EventArgs) Handles btnRSVP.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtFirstName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtLastName, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtEmail, errP) Then
            blnErrors = True
        End If
        If lstEvents.SelectedIndex = -1 Then
            errP.SetError(lstEvents, "You must select an event.")
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        With objRSVP.CurrentObject
            .FName = txtFirstName.Text
            .LName = txtLastName.Text
            .Email = txtEmail.Text
            .EventID = lstEvents.SelectedItem.ToString
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objRSVP.Save
            If intResult = 1 Then
                tslStatus.Text = "RSVP record saved"
            End If
            If intResult = -1 Then
                MessageBox.Show("Unable to save RSVP record", "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save RSVP record: " & ex.ToString, "Database error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        btnClear.PerformClick()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFirstName.Clear()
        txtLastName.Clear()
        txtEmail.Clear()
        lstEvents.SelectedIndex = -1
    End Sub

    Private Sub btnReport_Click(sender As Object, e As EventArgs) Handles btnReport.Click
        report = New frmReport
        report.ShowDialog()
    End Sub
End Class