Public Class frmMain
    ' Professor 
    Private RoleInfo As frmRole
    'Matthew Anguelo
    Private Login As frmLogin
    Private Admin As frmAdmin
    ' Matthew Movilla
    Private EventForm As frmEvents
    Private RSVP As frmRSVP
    ' Julian Crespo
    Private Semester As frmSemester
    Private Course As frmCourse
    ' Elvin Blen
    Private Member As frmMember
#Region "Toolbar Actions"
    Private Sub tsbRole_Click(sender As Object, e As EventArgs) Handles tsbRole.Click
        If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
            Me.Hide()
            RoleInfo.ShowDialog()
            Me.Show()
            PerformNextAction()
        Else
            MessageBox.Show("You do not have the required permissions to view Roles. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If

    End Sub
    Private Sub tsbEvent_Click(sender As Object, e As EventArgs) Handles tsbEvent.Click
        Me.Hide()
        EventForm.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
    Private Sub tsbRSVP_Click(sender As Object, e As EventArgs) Handles tsbRSVP.Click
        Me.Hide()
        RSVP.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub
    Private Sub tsbSemester_Click(sender As Object, e As EventArgs) Handles tsbSemester.Click
        If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
            Me.Hide()
            Semester.ShowDialog()
            Me.Show()
            PerformNextAction()
        Else
            MessageBox.Show("You do not have the required permissions to view Semesters. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub tsbCourse_Click(sender As Object, e As EventArgs) Handles tsbCourse.Click
        If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
            Me.Hide()
            Course.ShowDialog()
            Me.Show()
            PerformNextAction()
        Else
            MessageBox.Show("You do not have the required permissions to view Courses. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub tsbMember_Click(sender As Object, e As EventArgs) Handles tsbMember.Click
        If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
            Me.Hide()
            Member.ShowDialog()
            Me.Show()
            PerformNextAction()
        Else
            MessageBox.Show("You do not have the required permissions to view Members. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        End If
    End Sub
    Private Sub tsbLogOut_Click(sender As Object, e As EventArgs) Handles tsbLogOut.Click
        intNextAction = ACTION_LOGOUT
        PerformNextAction()
    End Sub
    Private Sub tsbProxy_MouseEnter(sender As Object, e As EventArgs) Handles tsbCourse.MouseEnter, tsbEvent.MouseEnter, tsbHelp.MouseEnter, tsbHome.MouseEnter, tsbHome.MouseEnter, tsbLogOut.MouseEnter, tsbMember.MouseEnter, tsbRole.MouseEnter, tsbRSVP.MouseEnter, tsbSemester.MouseEnter
        'We need to do this only because we are not putting our images in the image property of the toolbra buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Text
    End Sub
    Private Sub tsbProxy_MouseLeave(sender As Object, e As EventArgs) Handles tsbCourse.MouseLeave, tsbEvent.MouseLeave, tsbHelp.MouseLeave, tsbHome.MouseLeave, tsbHome.MouseLeave, tsbLogOut.MouseLeave, tsbMember.MouseLeave, tsbRole.MouseLeave, tsbRSVP.MouseLeave, tsbSemester.MouseLeave
        'We need to do this only because we are not putting our images in the image property of the toolbra buttons
        Dim tsbProxy As ToolStripButton
        tsbProxy = DirectCast(sender, ToolStripButton)
        tsbProxy.DisplayStyle = ToolStripItemDisplayStyle.Image
    End Sub
    Private Sub PerformNextAction()
        'get the next action selected on the child form, 
        'then simulate the click on the toolbar button here
        Select Case intNextAction
            Case ACTION_COURSE
                If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
                    tsbCourse.PerformClick()
                Else
                    MessageBox.Show("You do not have the required permissions to view Courses. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Case ACTION_EVENT
                tsbEvent.PerformClick()
            Case ACTION_HELP
                tsbHelp.PerformClick()
            Case ACTION_HOME
               'nothing to do here
            Case ACTION_LOGOUT
                EndProgram()
            Case ACTION_MEMBER
                If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
                    tsbMember.PerformClick()
                Else
                    MessageBox.Show("You do not have the required permissions to view Members. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Case ACTION_NONE
                'nothing to do here
            Case ACTION_ROLE
                If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
                    tsbRole.PerformClick()
                Else
                    MessageBox.Show("You do not have the required permissions to view Roles. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Case ACTION_RSVP
                tsbRSVP.PerformClick()
            Case ACTION_SEMESTER
                If currentSecurity.SecRole = ADMIN_ROLE Or currentSecurity.SecRole = OFFICER_ROLE Then
                    tsbSemester.PerformClick()
                Else
                    MessageBox.Show("You do not have the required permissions to view Semesters. Please contact your administrator", "Permission Denied", MessageBoxButtons.OK, MessageBoxIcon.Hand)
                End If
            Case ACTION_TUTOR
                tsbTutor.PerformClick()
            Case Else
                MessageBox.Show("Unexpected case value in PerformNextAction in frmMain", "Program", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
#End Region

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        Member = New frmMember
        Semester = New frmSemester
        Course = New frmCourse
        RSVP = New frmRSVP
        EventForm = New frmEvents
        Admin = New frmAdmin
        RoleInfo = New frmRole
        Try
            myDB.OpenDB()
        Catch ex As Exception
            MessageBox.Show("Unable to open database. Connection string=" & gstrConn, "DB Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            EndProgram()
        End Try
    End Sub
    Private Sub frmMain_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Login = New frmLogin
        If currentSecurity Is Nothing Then
            Login.ShowDialog()
        End If
    End Sub
    Private Sub EndProgram()
        'Close each form except main
        Dim f As Form
        Me.Cursor = Cursors.WaitCursor
        For Each f In Application.OpenForms
            If f.Name <> Me.Name Then
                If Not f Is Nothing Then
                    f.Close()
                End If
            End If
        Next
        'Close database connection
        If Not objSQLConn Is Nothing Then
            objSQLConn.Close()
            objSQLConn.Dispose()
        End If
        Me.Cursor = Cursors.Default
        Application.Exit()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Me.Hide()
        frmAdmin.ShowDialog()
        Me.Show()
        PerformNextAction()
    End Sub

    Private Sub frmMain_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        ' check if the Admin Console button should be shown 
        If currentSecurity Is Nothing Then
        Else
            Select Case currentSecurity.SecRole
                Case ADMIN_ROLE
                    btnAdmin.Visible = True
                Case Else
                    btnAdmin.Visible = False
            End Select
        End If
    End Sub
End Class
