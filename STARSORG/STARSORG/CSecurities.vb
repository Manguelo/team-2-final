﻿Imports System.Data.SqlClient
Public Class CSecurities
    'Represents the Security table 
    Private _Security As CSecurity
    'constructor
    Public Sub New()
        'instantiate the CSecurity object
        _Security = New CSecurity
    End Sub
    Public ReadOnly Property CurrentObject As CSecurity
        Get
            Return _Security
        End Get
    End Property
    Public Sub Clear()
        _Security = New CSecurity
    End Sub
    Public Sub CreateNewSecurity()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _Security.IsNewSecurity = True
    End Sub
    Public Function Save() As Integer
        Return _Security.Save()
    End Function
    Public Function CheckCredentials(PID As String, pass As String) As CSecurity
        Dim params As New ArrayList
        params.Add(New SqlParameter("pid", PID))
        params.Add(New SqlParameter("password", pass))
        FillObject(myDB.GetDataReaderBySP("sp_CheckCredentials", params))
        Return _Security
    End Function
    Public Function GetPIDByUserId(userID As String) As String
        Dim params As New ArrayList
        params.Add(New SqlParameter("userID", userID))
        Return myDB.GetSingleValueFromSP("sp_getPIDByUserID", params)
    End Function
    Public Function CheckPIDExists(PID As String) As Integer
        Dim params As New ArrayList
        Dim pidExists As Integer
        params.Add(New SqlParameter("pid", PID))
        pidExists = myDB.GetSingleValueFromSP("sp_checkPIDExists", params)
        Return pidExists
    End Function
    Public Function GetSecurityForUserID(userID As String) As CSecurity
        Dim params As New ArrayList
        params.Add(New SqlParameter("userID", userID))
        Return FillObject(myDB.GetDataReaderBySP("sp_getSecurityByUserID", params))
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CSecurity
        If objDR.Read Then
            With _Security
                .PID = objDR("PID")
                .UserID = objDR.Item("UserID")
                .Password = objDR.Item("Password")
                .SecRole = objDR.Item("SecRole")
            End With
        End If
        objDR.Close()
        Return _Security
    End Function
End Class
