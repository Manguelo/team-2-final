﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtUserId = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.errP = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblErr = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblUpdateStatus = New System.Windows.Forms.Label()
        Me.btnUpdatePass = New System.Windows.Forms.Button()
        Me.txtNewPass = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.txtUserIdUpdate = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnGuestLogin = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.errP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(150, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 21)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "User ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(159, 227)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Password"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUserId
        '
        Me.txtUserId.Location = New System.Drawing.Point(75, 197)
        Me.txtUserId.MaxLength = 7
        Me.txtUserId.Name = "txtUserId"
        Me.txtUserId.Size = New System.Drawing.Size(220, 20)
        Me.txtUserId.TabIndex = 0
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(75, 243)
        Me.txtPassword.MaxLength = 8
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(220, 20)
        Me.txtPassword.TabIndex = 3
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.White
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnLogin.FlatAppearance.BorderSize = 2
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLogin.Location = New System.Drawing.Point(59, 299)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(253, 37)
        Me.btnLogin.TabIndex = 4
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'errP
        '
        Me.errP.ContainerControl = Me
        '
        'lblErr
        '
        Me.lblErr.ForeColor = System.Drawing.Color.Red
        Me.lblErr.Location = New System.Drawing.Point(44, 266)
        Me.lblErr.Name = "lblErr"
        Me.lblErr.Size = New System.Drawing.Size(283, 26)
        Me.lblErr.TabIndex = 5
        Me.lblErr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblUpdateStatus)
        Me.GroupBox1.Controls.Add(Me.btnUpdatePass)
        Me.GroupBox1.Controls.Add(Me.txtNewPass)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txtOldPass)
        Me.GroupBox1.Controls.Add(Me.txtUserIdUpdate)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(375, 21)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(339, 315)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Update Password"
        '
        'lblUpdateStatus
        '
        Me.lblUpdateStatus.ForeColor = System.Drawing.Color.Red
        Me.lblUpdateStatus.Location = New System.Drawing.Point(27, 199)
        Me.lblUpdateStatus.Name = "lblUpdateStatus"
        Me.lblUpdateStatus.Size = New System.Drawing.Size(283, 26)
        Me.lblUpdateStatus.TabIndex = 11
        Me.lblUpdateStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnUpdatePass
        '
        Me.btnUpdatePass.BackColor = System.Drawing.Color.White
        Me.btnUpdatePass.FlatAppearance.BorderColor = System.Drawing.Color.LightSkyBlue
        Me.btnUpdatePass.FlatAppearance.BorderSize = 2
        Me.btnUpdatePass.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUpdatePass.Location = New System.Drawing.Point(43, 240)
        Me.btnUpdatePass.Name = "btnUpdatePass"
        Me.btnUpdatePass.Size = New System.Drawing.Size(253, 37)
        Me.btnUpdatePass.TabIndex = 10
        Me.btnUpdatePass.Text = "Update Password"
        Me.btnUpdatePass.UseVisualStyleBackColor = False
        '
        'txtNewPass
        '
        Me.txtNewPass.Location = New System.Drawing.Point(59, 176)
        Me.txtNewPass.MaxLength = 8
        Me.txtNewPass.Name = "txtNewPass"
        Me.txtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPass.Size = New System.Drawing.Size(220, 20)
        Me.txtNewPass.TabIndex = 8
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(118, 152)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 21)
        Me.Label7.TabIndex = 9
        Me.Label7.Text = "New Password"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtOldPass
        '
        Me.txtOldPass.Location = New System.Drawing.Point(59, 125)
        Me.txtOldPass.MaxLength = 8
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(220, 20)
        Me.txtOldPass.TabIndex = 7
        '
        'txtUserIdUpdate
        '
        Me.txtUserIdUpdate.Location = New System.Drawing.Point(59, 79)
        Me.txtUserIdUpdate.MaxLength = 7
        Me.txtUserIdUpdate.Name = "txtUserIdUpdate"
        Me.txtUserIdUpdate.Size = New System.Drawing.Size(220, 20)
        Me.txtUserIdUpdate.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(115, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(108, 20)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Old Password"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(134, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 21)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "User ID"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.White
        Me.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.LightCoral
        Me.btnExit.FlatAppearance.BorderSize = 2
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(555, 362)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(159, 37)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnGuestLogin
        '
        Me.btnGuestLogin.BackColor = System.Drawing.Color.White
        Me.btnGuestLogin.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnGuestLogin.FlatAppearance.BorderSize = 2
        Me.btnGuestLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnGuestLogin.Location = New System.Drawing.Point(59, 362)
        Me.btnGuestLogin.Name = "btnGuestLogin"
        Me.btnGuestLogin.Size = New System.Drawing.Size(253, 37)
        Me.btnGuestLogin.TabIndex = 8
        Me.btnGuestLogin.Text = "Sign In as Guest"
        Me.btnGuestLogin.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.STARSORG.My.Resources.Resources.STARS_National_LOGO1
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(59, 21)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(253, 133)
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(738, 424)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnGuestLogin)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblErr)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserId)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Login"
        CType(Me.errP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtUserId As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents errP As ErrorProvider
    Friend WithEvents lblErr As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents lblUpdateStatus As Label
    Friend WithEvents btnUpdatePass As Button
    Friend WithEvents txtNewPass As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtOldPass As TextBox
    Friend WithEvents txtUserIdUpdate As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnGuestLogin As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
