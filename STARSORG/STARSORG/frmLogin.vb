Public Class frmLogin
    Private strPantherId As String
    Private strPassword As String
    Private objSecurity As CSecurities
    Private objAudits As CAudits
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim PID As String
        Dim result As CSecurity
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtUserId, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPassword, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        strPantherId = txtUserId.Text
        strPassword = txtPassword.Text

        ' Check if user id exists. 
        ' If not, then assign value Of 9999999 for auditing purposes
        PID = objSecurity.GetPIDByUserId(txtUserId.Text)
        If PID = -1 Then
            PID = "9999999"
        End If

        result = objSecurity.CheckCredentials(PID, strPassword)
        If result.PID = "" Then
            lblErr.Text = "Unable to sign in. Invalid User ID or Password"
            With objAudits.CurrentObject
                .PID = PID
                .Success = 0
                .AccessTimeStamp = DateTime.Now
            End With
            objAudits.SaveAttempt()
            Exit Sub
        End If
        'Successful login!
        'Remove the user's password from memory and save their security status 
        With objAudits.CurrentObject
            .PID = result.PID
            .Success = 1
            .AccessTimeStamp = DateTime.Now
        End With
        objAudits.SaveAttempt()

        result.Password = ""
        currentSecurity = result
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecurity = New CSecurities
        objAudits = New CAudits
    End Sub

    Private Sub fields_TextChanged(sender As Object, e As EventArgs) Handles txtUserId.TextChanged, txtPassword.TextChanged, txtUserIdUpdate.TextChanged
        lblErr.Text = ""
    End Sub

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        Dim blnErrors As Boolean
        Dim result As CSecurity
        Dim PID As String
        Dim saveResult As Integer

        If Not ValidateTextBoxLength(txtUserIdUpdate, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtOldPass, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtNewPass, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If

        PID = objSecurity.GetPIDByUserId(txtUserIdUpdate.Text)
        result = objSecurity.CheckCredentials(PID, txtOldPass.Text)
        If result.PID = "" Then
            lblUpdateStatus.Text = "Unable to update password. Invalid User ID or Password"
            lblUpdateStatus.ForeColor = Color.Red
            Exit Sub
        End If
        'Old password and PID are valid. Save them
        With objSecurity.CurrentObject
            .PID = result.PID
            .UserID = result.UserID
            .Password = txtNewPass.Text
            .SecRole = result.SecRole
        End With
        saveResult = objSecurity.Save()
        If saveResult <> 1 Then
            'failed to update security
            lblUpdateStatus.Text = "Unable to update password. Database error"
            lblUpdateStatus.ForeColor = Color.Red
            Exit Sub
        End If
        ClearScreenControls(Me)
        lblUpdateStatus.Text = "Password was successfully updated"
        lblUpdateStatus.ForeColor = Color.Green
        objSecurity.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit
    End Sub

    Private Sub btnGuestLogin_Click(sender As Object, e As EventArgs) Handles btnGuestLogin.Click
        Dim PID As String
        Dim result As CSecurity
        PID = "0000001"

        result = objSecurity.CheckCredentials(PID, "")
        If result.PID = "" Then
            lblErr.Text = "Unable to sign in. Database error"
            With objAudits.CurrentObject
                .PID = PID
                .Success = 0
                .AccessTimeStamp = DateTime.Now
            End With
            objAudits.SaveAttempt()
            Exit Sub
        End If
        'Successful login!
        'Remove the user's password from memory and save their security status 
        With objAudits.CurrentObject
            .PID = result.PID
            .Success = 1
            .AccessTimeStamp = DateTime.Now
        End With
        objAudits.SaveAttempt()

        result.Password = ""
        currentSecurity = result
        Me.Close()
    End Sub
End Class