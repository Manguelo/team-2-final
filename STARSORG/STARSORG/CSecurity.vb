Imports System.Data.SqlClient
Public Class CSecurity
    'Represents a single record in the security table
    Private _mstrPID As String
    Private _mstrUserID As String
    Private _mstrPassword As String
    Private _mstrSecRole As String
    Private _isNewSecurity As Boolean
    ' constructor
    Public Sub New()
        _mstrPID = ""
        _mstrUserID = ""
        _mstrPassword = ""
        _mstrSecRole = ""
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
    Public Property UserID As String
        Get
            Return _mstrUserID
        End Get
        Set(strVal As String)
            _mstrUserID = strVal

        End Set
    End Property
    Public Property Password As String
        Get
            Return _mstrPassword
        End Get
        Set(strVal As String)
            _mstrPassword = strVal
        End Set
    End Property
    Public Property SecRole As String
        Get
            Return _mstrSecRole
        End Get
        Set(strVal As String)
            _mstrSecRole = strVal
        End Set
    End Property

    Public Property IsNewSecurity As Boolean
        Get
            Return _isNewSecurity
        End Get
        Set(blnval As Boolean)
            _isNewSecurity = blnval
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this property's code will create the parameters for the stored procedure to save a record 
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("PID", _mstrPID))
            params.Add(New SqlParameter("userID", _mstrUserID))
            params.Add(New SqlParameter("password", _mstrPassword))
            params.Add(New SqlParameter("secRole", _mstrSecRole))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        Return myDB.ExecSP("sp_saveSecurity", GetSaveParameters())
    End Function



End Class
