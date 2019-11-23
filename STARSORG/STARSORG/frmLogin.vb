Public Class frmLogin
    Private strPantherId As String
    Private strPassword As String
    Private objSecurity As CSecurities
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim blnErrors As Boolean
        If Not ValidateTextBoxLength(txtPantherId, errP) Then
            blnErrors = True
        End If
        If Not ValidateTextBoxLength(txtPassword, errP) Then
            blnErrors = True
        End If
        If blnErrors Then
            Exit Sub
        End If
        strPantherId = txtPantherId.Text
        strPassword = txtPassword.Text

        Dim result As CSecurity
        result = objSecurity.CheckCredentials(strPantherId, strPassword)
        If result.PID = "" Then
            lblErr.Text = "Unable to sign in. Invalid Panther ID or Password"
            Exit Sub
        End If
        'Successful login!
        'Remove the user's password from memory and save their security status 
        result.Password = ""
        currentSecurity = result
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecurity = New CSecurities
    End Sub

    Private Sub fields_TextChanged(sender As Object, e As EventArgs) Handles txtPantherId.TextChanged, txtPassword.TextChanged
        lblErr.Text = ""
    End Sub

    Private Sub btnUpdatePass_Click(sender As Object, e As EventArgs) Handles btnUpdatePass.Click
        Dim blnErrors As Boolean
        Dim result As CSecurity
        Dim saveResult As Integer

        If Not ValidateTextBoxLength(txtPIDUpdate, errP) Then
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

        result = objSecurity.CheckCredentials(txtPIDUpdate.Text, txtOldPass.Text)
        If result.PID = "" Then
            lblUpdateStatus.Text = "Unable to update password. Invalid Panther ID or Password"
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

        currentSecurity = objSecurity.CurrentObject
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit
    End Sub
End Class