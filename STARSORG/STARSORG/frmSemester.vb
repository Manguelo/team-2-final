Imports System.Data.SqlClient
Public Class frmSemester
    Private objSemesters As CSemesters
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar Routines"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter, tsbTutor.MouseEnter

        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave, tsbTutor.MouseLeave

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

    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_SEMESTER
        Me.Hide()
    End Sub
#End Region
    Private Sub LoadSemesters()
        Dim objReader As SqlDataReader
        lstSemester.Items.Clear()
        Try
            objReader = objSemesters.GetAllSemesters()
            Do While objReader.Read
                lstSemester.Items.Add(objReader.Item("SemesterID"))
            Loop
            objReader.Close()
        Catch ex As Exception

        End Try
        If objSemesters.CurrentObject.SemesterID <> "" Then
            lstSemester.SelectedIndex = lstSemester.FindStringExact(objSemesters.CurrentObject.SemesterID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmSemester_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadSemesters()
        grpAddModSemester.Enabled = False
    End Sub

    Private Sub FrmSemesters_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSemesters = New CSemesters
    End Sub

    Private Sub chkNewSemester_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewSemester.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewSemester.Checked Then
            tslStatus.Text = ""
            txtSemesterAdd.Clear()
            txtSemesterDescription.Clear()
            grpSemesters.Enabled = False
            grpAddModSemester.Enabled = True
            objSemesters.CreateNewSemester()
            txtSemesterAdd.Focus()
        Else
            grpSemesters.Enabled = True
            grpAddModSemester.Enabled = False
            objSemesters.CurrentObject.IsNewSemester = False
        End If
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objSemesters.GetSemesterBySemesterID(lstSemester.SelectedItem.ToString)
            With objSemesters.CurrentObject
                txtSemesterAdd.Text = .SemesterID
                txtSemesterDescription.Text = .SemesterDescription
            End With
        Catch ex As Exception
            MessageBox.Show("Error Loading Semester Values: " & ex.ToString, "Program", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstSemester_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstSemester.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstSemester.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNewSemester.Checked = False
        LoadSelectedRecord()
        grpAddModSemester.Enabled = True
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnSemesterAdd.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""

        If Not ValidateTextBoxLength(txtSemesterAdd, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtSemesterAdd, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        With objSemesters.CurrentObject
            .SemesterID = txtSemesterAdd.Text
            .SemesterDescription = txtSemesterDescription.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objSemesters.Save()
            If intResult = 1 Then
                tslStatus.Text = "Semester record saved"
            End If
            If intResult = -1 Then
                MessageBox.Show("SemeseterID must be unique. Unable to save semester record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save semester record: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadSemesters()
        chkNewSemester.Checked = False
        grpSemesters.Enabled = True
    End Sub

    Private Sub btnSemesterReport_Click(sender As Object, e As EventArgs) Handles btnSemesterReport.Click
        frmSemesterReport.Show()
        Me.Close()
    End Sub
End Class