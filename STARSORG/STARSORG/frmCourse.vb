Imports System.Data.SqlClient

Public Class frmCourse
    Private objCourses As CCourses
    Private blnClearing As Boolean
    Private blnReloading As Boolean
#Region "Toolbar Routines"
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbCourse.MouseEnter, tsbTutor.MouseEnter

        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub

    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbCourse.MouseLeave, tsbTutor.MouseLeave

        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
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

    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click

    End Sub

    Private Sub tsbTutor_Click(sender As Object, e As EventArgs) Handles tsbTutor.Click
        intNextAction = ACTION_COURSE
        Me.Hide()
    End Sub
#End Region
    Private Sub LoadCourses()
        Dim objReader As SqlDataReader
        lstCourse.Items.Clear()
        Try
            objReader = objCourses.GetAllCourses()
            Do While objReader.Read
                lstCourse.Items.Add(objReader.Item("CourseID"))
            Loop
            objReader.Close()
        Catch ex As Exception

        End Try
        If objCourses.CurrentObject.CourseID <> "" Then
            lstCourse.SelectedIndex = lstCourse.FindStringExact(objCourses.CurrentObject.CourseID)
        End If
        blnReloading = False
    End Sub

    Private Sub frmCourse_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        ClearScreenControls(Me)
        LoadCourses()
        grpAddModCourse.Enabled = False
    End Sub

    Private Sub FrmCourses_Load(sender As Object, e As EventArgs) Handles Me.Load
        objCourses = New CCourses
    End Sub

    Private Sub chkNewCourse_CheckedChanged(sender As Object, e As EventArgs) Handles chkNewCourse.CheckedChanged
        If blnClearing Then
            Exit Sub
        End If
        If chkNewCourse.Checked Then
            tslStatus.Text = ""
            txtCourseAdd.Clear()
            txtCourseName.Clear()
            grpCourses.Enabled = False
            grpAddModCourse.Enabled = True
            objCourses.CreateNewCourse()
            txtCourseAdd.Focus()
        Else
            grpCourses.Enabled = True
            grpAddModCourse.Enabled = False
            objCourses.CurrentObject.IsNewCourse = False
        End If
    End Sub

    Private Sub LoadSelectedRecord()
        Try
            objCourses.GetCourseByCourseID(lstCourse.SelectedItem.ToString)
            With objCourses.CurrentObject
                txtCourseAdd.Text = .CourseID
                txtCourseName.Text = .CourseName
            End With
        Catch ex As Exception
            MessageBox.Show("Error Loading Course Values: " & ex.ToString, "Program", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub lstCourse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstCourse.SelectedIndexChanged
        If blnClearing Then
            Exit Sub
        End If
        If blnReloading Then
            Exit Sub
        End If
        If lstCourse.SelectedIndex = -1 Then
            Exit Sub
        End If
        chkNewCourse.Checked = False
        LoadSelectedRecord()
        grpAddModCourse.Enabled = True
    End Sub
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnCourseAdd.Click
        Dim intResult As Integer
        Dim blnErrors As Boolean
        tslStatus.Text = ""

        If Not ValidateTextBoxLength(txtCourseAdd, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtCourseAdd, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        With objCourses.CurrentObject
            .CourseID = txtCourseAdd.Text
            .CourseName = txtCourseName.Text
        End With
        Try
            Me.Cursor = Cursors.WaitCursor
            intResult = objCourses.Save()
            If intResult = 1 Then
                tslStatus.Text = "Course record saved"
            End If
            If intResult = -1 Then
                MessageBox.Show("SemeseterID must be unique. Unable to save Course record", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                tslStatus.Text = "Error"
            End If
        Catch ex As Exception
            MessageBox.Show("Unable to save Course record: " & ex.ToString, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tslStatus.Text = "Error"
        End Try
        Me.Cursor = Cursors.Default
        blnReloading = True
        LoadCourses()
        chkNewCourse.Checked = False
        grpCourses.Enabled = True
    End Sub

    Private Sub btnCourseReport_Click(sender As Object, e As EventArgs) Handles btnCourseReport.Click
        frmCourseReport.Show()
        Me.Close()
    End Sub
End Class