Public Class frmLogin
    Private strUserId As String
    Private strPassword As String
    Private objSecurity As CSecurities
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        lblError.Text = ""
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
        With objSecurity
            strUserId = txtUserId.Text
            strPassword = txtPassword.Text
        End With

        Dim result As CSecurity
        result = objSecurity.CheckCredentials(strUserId, strPassword)
        If result.PID = "" Then
            lblError.Text = "Unable to sign in. Invalid User ID or Password"
            Exit Sub
        End If
        currentUser = result
        Me.Close()
    End Sub

    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        objSecurity = New CSecurities
    End Sub

    Private Sub fields_TextChanged(sender As Object, e As EventArgs) Handles txtUserId.TextChanged, txtPassword.TextChanged
        lblError.Text = ""
    End Sub
End Class