<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmSemester
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHome = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbMember = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRole = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbEvent = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRSVP = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbCourse = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSemester = New System.Windows.Forms.ToolStripButton()
        Me.tsbTutor = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLogOut = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbHelp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripSeparator10 = New System.Windows.Forms.ToolStripSeparator()
        Me.btnSemesterAdd = New System.Windows.Forms.Button()
        Me.txtSemesterAdd = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lstSemester = New System.Windows.Forms.ListBox()
        Me.tslStatus = New System.Windows.Forms.StatusStrip()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.grpAddModSemester = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSemesterDescription = New System.Windows.Forms.TextBox()
        Me.chkNewSemester = New System.Windows.Forms.CheckBox()
        Me.grpAddSemester = New System.Windows.Forms.GroupBox()
        Me.grpSemesters = New System.Windows.Forms.GroupBox()
        Me.btnSemesterReport = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpAddModSemester.SuspendLayout()
        Me.grpAddSemester.SuspendLayout()
        Me.grpSemesters.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator6, Me.tsbHome, Me.ToolStripSeparator7, Me.tsbMember, Me.ToolStripSeparator8, Me.tsbRole, Me.ToolStripSeparator5, Me.tsbEvent, Me.ToolStripSeparator3, Me.tsbRSVP, Me.ToolStripSeparator4, Me.tsbCourse, Me.ToolStripSeparator2, Me.tsbSemester, Me.tsbTutor, Me.ToolStripSeparator9, Me.tsbLogOut, Me.ToolStripSeparator1, Me.tsbHelp, Me.ToolStripSeparator11, Me.ToolStripSeparator10})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Padding = New System.Windows.Forms.Padding(0, 0, 2, 0)
        Me.ToolStrip1.Size = New System.Drawing.Size(465, 50)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.AutoSize = False
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHome
        '
        Me.tsbHome.AutoSize = False
        Me.tsbHome.BackgroundImage = Global.STARSORG.My.Resources.Resources.home
        Me.tsbHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHome.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHome.Name = "tsbHome"
        Me.tsbHome.Size = New System.Drawing.Size(48, 48)
        Me.tsbHome.Text = "HOME"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.AutoSize = False
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(10, 50)
        '
        'tsbMember
        '
        Me.tsbMember.AutoSize = False
        Me.tsbMember.BackgroundImage = Global.STARSORG.My.Resources.Resources.member
        Me.tsbMember.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbMember.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbMember.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbMember.Name = "tsbMember"
        Me.tsbMember.Size = New System.Drawing.Size(48, 48)
        Me.tsbMember.Text = "MEMBER"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.AutoSize = False
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRole
        '
        Me.tsbRole.AutoSize = False
        Me.tsbRole.BackgroundImage = Global.STARSORG.My.Resources.Resources.roles
        Me.tsbRole.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRole.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRole.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRole.Name = "tsbRole"
        Me.tsbRole.Size = New System.Drawing.Size(48, 48)
        Me.tsbRole.Text = "ROLE"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.AutoSize = False
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(10, 50)
        '
        'tsbEvent
        '
        Me.tsbEvent.AutoSize = False
        Me.tsbEvent.BackgroundImage = Global.STARSORG.My.Resources.Resources.events
        Me.tsbEvent.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbEvent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbEvent.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbEvent.Name = "tsbEvent"
        Me.tsbEvent.Size = New System.Drawing.Size(48, 48)
        Me.tsbEvent.Text = "EVENT"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.AutoSize = False
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(10, 50)
        '
        'tsbRSVP
        '
        Me.tsbRSVP.AutoSize = False
        Me.tsbRSVP.BackgroundImage = Global.STARSORG.My.Resources.Resources.rsvp
        Me.tsbRSVP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbRSVP.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbRSVP.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRSVP.Name = "tsbRSVP"
        Me.tsbRSVP.Size = New System.Drawing.Size(48, 48)
        Me.tsbRSVP.Text = "RSVP"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.AutoSize = False
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(10, 50)
        '
        'tsbCourse
        '
        Me.tsbCourse.AutoSize = False
        Me.tsbCourse.BackgroundImage = Global.STARSORG.My.Resources.Resources.courses
        Me.tsbCourse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbCourse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbCourse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbCourse.Name = "tsbCourse"
        Me.tsbCourse.Size = New System.Drawing.Size(48, 48)
        Me.tsbCourse.Text = "COURSE"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.AutoSize = False
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(10, 50)
        '
        'tsbSemester
        '
        Me.tsbSemester.AutoSize = False
        Me.tsbSemester.BackgroundImage = Global.STARSORG.My.Resources.Resources.semesters
        Me.tsbSemester.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbSemester.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbSemester.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSemester.Name = "tsbSemester"
        Me.tsbSemester.Size = New System.Drawing.Size(48, 48)
        Me.tsbSemester.Text = "SEMESTER"
        '
        'tsbTutor
        '
        Me.tsbTutor.AutoSize = False
        Me.tsbTutor.BackgroundImage = Global.STARSORG.My.Resources.Resources.tutors
        Me.tsbTutor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbTutor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbTutor.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbTutor.Name = "tsbTutor"
        Me.tsbTutor.Size = New System.Drawing.Size(48, 48)
        Me.tsbTutor.Text = "TUTOR"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator9.AutoSize = False
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(10, 50)
        '
        'tsbLogOut
        '
        Me.tsbLogOut.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbLogOut.AutoSize = False
        Me.tsbLogOut.BackgroundImage = Global.STARSORG.My.Resources.Resources.logout
        Me.tsbLogOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbLogOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbLogOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLogOut.Name = "tsbLogOut"
        Me.tsbLogOut.Size = New System.Drawing.Size(48, 48)
        Me.tsbLogOut.Text = "LOGOUT"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.AutoSize = False
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(10, 50)
        '
        'tsbHelp
        '
        Me.tsbHelp.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.tsbHelp.AutoSize = False
        Me.tsbHelp.BackgroundImage = Global.STARSORG.My.Resources.Resources.help
        Me.tsbHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.tsbHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tsbHelp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbHelp.Name = "tsbHelp"
        Me.tsbHelp.Size = New System.Drawing.Size(48, 48)
        Me.tsbHelp.Text = "HELP"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.AutoSize = False
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(10, 50)
        '
        'ToolStripSeparator10
        '
        Me.ToolStripSeparator10.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator10.AutoSize = False
        Me.ToolStripSeparator10.Name = "ToolStripSeparator10"
        Me.ToolStripSeparator10.Size = New System.Drawing.Size(10, 50)
        '
        'btnSemesterAdd
        '
        Me.btnSemesterAdd.Location = New System.Drawing.Point(132, 32)
        Me.btnSemesterAdd.Name = "btnSemesterAdd"
        Me.btnSemesterAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnSemesterAdd.TabIndex = 4
        Me.btnSemesterAdd.Text = "Update"
        Me.btnSemesterAdd.UseVisualStyleBackColor = True
        '
        'txtSemesterAdd
        '
        Me.txtSemesterAdd.Location = New System.Drawing.Point(7, 36)
        Me.txtSemesterAdd.Name = "txtSemesterAdd"
        Me.txtSemesterAdd.Size = New System.Drawing.Size(117, 20)
        Me.txtSemesterAdd.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Semester Name"
        '
        'lstSemester
        '
        Me.lstSemester.FormattingEnabled = True
        Me.lstSemester.Location = New System.Drawing.Point(4, 17)
        Me.lstSemester.Name = "lstSemester"
        Me.lstSemester.Size = New System.Drawing.Size(192, 147)
        Me.lstSemester.TabIndex = 6
        '
        'tslStatus
        '
        Me.tslStatus.AutoSize = False
        Me.tslStatus.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.tslStatus.Location = New System.Drawing.Point(0, 402)
        Me.tslStatus.Name = "tslStatus"
        Me.tslStatus.Padding = New System.Windows.Forms.Padding(0, 0, 7, 0)
        Me.tslStatus.Size = New System.Drawing.Size(465, 11)
        Me.tslStatus.TabIndex = 9
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(55, 58)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(352, 33)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Semesters"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpAddModSemester
        '
        Me.grpAddModSemester.Controls.Add(Me.Label1)
        Me.grpAddModSemester.Controls.Add(Me.txtSemesterDescription)
        Me.grpAddModSemester.Controls.Add(Me.txtSemesterAdd)
        Me.grpAddModSemester.Controls.Add(Me.Label2)
        Me.grpAddModSemester.Controls.Add(Me.btnSemesterAdd)
        Me.grpAddModSemester.Location = New System.Drawing.Point(234, 109)
        Me.grpAddModSemester.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAddModSemester.Name = "grpAddModSemester"
        Me.grpAddModSemester.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAddModSemester.Size = New System.Drawing.Size(218, 286)
        Me.grpAddModSemester.TabIndex = 11
        Me.grpAddModSemester.TabStop = False
        Me.grpAddModSemester.Text = "Add/Modify Semester"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(118, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Semester(s) Description"
        '
        'txtSemesterDescription
        '
        Me.txtSemesterDescription.Location = New System.Drawing.Point(7, 108)
        Me.txtSemesterDescription.MaxLength = 100
        Me.txtSemesterDescription.Multiline = True
        Me.txtSemesterDescription.Name = "txtSemesterDescription"
        Me.txtSemesterDescription.Size = New System.Drawing.Size(208, 160)
        Me.txtSemesterDescription.TabIndex = 7
        '
        'chkNewSemester
        '
        Me.chkNewSemester.AutoSize = True
        Me.chkNewSemester.Location = New System.Drawing.Point(3, 22)
        Me.chkNewSemester.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.chkNewSemester.Name = "chkNewSemester"
        Me.chkNewSemester.Size = New System.Drawing.Size(117, 17)
        Me.chkNewSemester.TabIndex = 9
        Me.chkNewSemester.Text = "Add New Semester"
        Me.chkNewSemester.UseVisualStyleBackColor = True
        '
        'grpAddSemester
        '
        Me.grpAddSemester.Controls.Add(Me.chkNewSemester)
        Me.grpAddSemester.Location = New System.Drawing.Point(21, 109)
        Me.grpAddSemester.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAddSemester.Name = "grpAddSemester"
        Me.grpAddSemester.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpAddSemester.Size = New System.Drawing.Size(155, 52)
        Me.grpAddSemester.TabIndex = 12
        Me.grpAddSemester.TabStop = False
        Me.grpAddSemester.Text = "Add New Semester"
        '
        'grpSemesters
        '
        Me.grpSemesters.Controls.Add(Me.lstSemester)
        Me.grpSemesters.Location = New System.Drawing.Point(21, 217)
        Me.grpSemesters.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpSemesters.Name = "grpSemesters"
        Me.grpSemesters.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.grpSemesters.Size = New System.Drawing.Size(209, 178)
        Me.grpSemesters.TabIndex = 13
        Me.grpSemesters.TabStop = False
        Me.grpSemesters.Text = "Semester(s)"
        '
        'btnSemesterReport
        '
        Me.btnSemesterReport.Location = New System.Drawing.Point(55, 177)
        Me.btnSemesterReport.Name = "btnSemesterReport"
        Me.btnSemesterReport.Size = New System.Drawing.Size(144, 23)
        Me.btnSemesterReport.TabIndex = 9
        Me.btnSemesterReport.Text = "Generate Report"
        Me.btnSemesterReport.UseVisualStyleBackColor = True
        '
        'frmSemester
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(465, 413)
        Me.ControlBox = False
        Me.Controls.Add(Me.btnSemesterReport)
        Me.Controls.Add(Me.grpSemesters)
        Me.Controls.Add(Me.grpAddSemester)
        Me.Controls.Add(Me.grpAddModSemester)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tslStatus)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "frmSemester"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Semesters"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpAddModSemester.ResumeLayout(False)
        Me.grpAddModSemester.PerformLayout()
        Me.grpAddSemester.ResumeLayout(False)
        Me.grpAddSemester.PerformLayout()
        Me.grpSemesters.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents tsbHome As ToolStripButton
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents tsbMember As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents tsbRole As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents tsbEvent As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents tsbRSVP As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbCourse As ToolStripButton
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents tsbSemester As ToolStripButton
    Friend WithEvents tsbTutor As ToolStripButton
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents tsbLogOut As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tsbHelp As ToolStripButton
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator10 As ToolStripSeparator
    Friend WithEvents btnSemesterAdd As Button
    Friend WithEvents txtSemesterAdd As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lstSemester As ListBox
    Friend WithEvents tslStatus As StatusStrip
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents Label3 As Label
    Friend WithEvents grpAddModSemester As GroupBox
    Friend WithEvents chkNewSemester As CheckBox
    Friend WithEvents Label1 As Label
    Friend WithEvents txtSemesterDescription As TextBox
    Friend WithEvents grpAddSemester As GroupBox
    Friend WithEvents grpSemesters As GroupBox
    Friend WithEvents btnSemesterReport As Button
End Class
