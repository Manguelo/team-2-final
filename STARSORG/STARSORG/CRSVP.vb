Imports System.Data.SqlClient
Public Class CRSVP
    'represents a single record in the ROLE table
    Private _mstrEventID As String
    Private _mstrFName As String
    Private _mstrLName As String
    Private _mstrEmail As String
    Private _isNewRSVP As Boolean
    'constructer
    Public Sub New()
        _mstrEventID = ""
        _mstrFName = ""
        _mstrLName = ""
        _mstrEmail = ""
    End Sub

#Region "Exposed Properties"
    Public Property EventID As String
        Get
            Return _mstrEventID
        End Get
        Set(strVal As String)
            _mstrEventID = strVal
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
    Public Property Email As String
        Get
            Return _mstrEmail
        End Get
        Set(strVal As String)
            _mstrEmail = strVal
        End Set
    End Property
    Public Property isNewRSVP As Boolean
        Get
            Return _isNewRSVP
        End Get
        Set(blnVal As Boolean)
            _isNewRSVP = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSavedParameters() As ArrayList
        'this property code will create the parameters for the stored procedures to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("fName", _mstrFName))
            params.Add(New SqlParameter("lName", _mstrLName))
            params.Add(New SqlParameter("eMail", _mstrEmail))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with a duplicate ID)
        If isNewRSVP Then
            Dim params As New ArrayList
            'params.Add(New SqlParameter("roleID", _mstrRoleID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckRoleIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
        'if not a new role, or it is new and has a unique ID, then do the save update or insert
        Return myDB.execSP("sp_SaveRSVP", GetSavedParameters())
    End Function
End Class
