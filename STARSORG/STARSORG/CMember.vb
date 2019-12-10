﻿Imports System.Data.SqlClient
Public Class CMember

    'Represents a single record in the MEMBER table
    Private _mstrPID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrMI As String
    Private _mstrEmail As String
    Private _mstrPhone As String
    Private _mstrPhotoPath As String
    'Private _mstrSecRole As String

    Private _isNewMember As Boolean

    Public Sub New()
        _mstrPID = ""
        _mstrFName = ""
        _mstrLName = ""
        _mstrMI = ""
        _mstrEmail = ""
        _mstrPhone = ""
        _mstrPhotoPath = ""
        '_mstrSecRole = ""
    End Sub

#Region "Exposed Properties"
    Public Property PID As String
        Get
            Return _mstrPID
        End Get
        Set(strVal As String)
            _mstrPID = strVal
        End Set
    End Property
    Public Property FName As String
        Get
            Return _mstrFName
        End Get
        Set(strVal As String)
            _mstrFName = strVal
        End Set
    End Property
    Public Property LName As String
        Get
            Return _mstrLName
        End Get
        Set(strVal As String)
            _mstrLName = strVal
        End Set
    End Property
    Public Property MI As String
        Get
            Return _mstrMI
        End Get
        Set(strVal As String)
            _mstrMI = strVal
        End Set
    End Property
    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strVal As String)
            _mstrEmail = strVal
        End Set
    End Property
    Public Property Phone As String
        Get
            Return _mstrPhone
        End Get
        Set(strVal As String)
            _mstrPhone = strVal
        End Set
    End Property
    Public Property PhotoPath As String
        Get
            Return _mstrPhotoPath
        End Get
        Set(strVal As String)
            _mstrPhotoPath = strVal
        End Set
    End Property
    'Public Property SecRole As String
    '    Get
    '        Return _mstrSecRole
    '    End Get
    '    Set(strVal As String)
    '        _mstrSecRole = strVal
    '    End Set
    'End Property
    Public Property isNewMember As Boolean
        Get
            Return _isNewMember
        End Get
        Set(blnVal As Boolean)
            _isNewMember = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'This property's code will get create the parameters 
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("FName", _mstrFName))
            params.Add(New SqlParameter("LName", _mstrLName))
            params.Add(New SqlParameter("MI", _mstrMI))
            params.Add(New SqlParameter("Email", _mstrEmail))
            params.Add(New SqlParameter("Phone", _mstrPhone))
            params.Add(New SqlParameter("PhotoPath", _mstrPhotoPath))
            'params.Add(New SqlParameter("SecRole", _mstrSecRole))
            Return params
        End Get
    End Property
#End Region

    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with duplicate ID)
        If isNewMember Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckPIDExists", params)
            If Not strResult = 0 Then
                Return -1   'Not Unique
            End If
        End If
        'if not a new member, or it is new member and has a unique ID, then do the save (insert or update)
        Return myDB.ExecSP("sp_saveMember", GetSaveParameters())
    End Function

    Public Function GetReportData() As SqlDataAdapter
        Return myDB.GetDataAdapterBySP("dbo.sp_MemberReport", Nothing)
    End Function

End Class
