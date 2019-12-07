Imports System.Data.SqlClient
Public Class CAudit
    'Represents a single record in the Audit table
    Private _mstrPID As String
    Private _mstrAccessTimeStamp As DateTime
    Private _mintSuccess As Integer
    ' constructor
    Public Sub New()
        _mstrPID = ""
        _mstrAccessTimeStamp = DateTime.Now
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
    Public Property AccessTimeStamp As DateTime
        Get
            Return _mstrAccessTimeStamp
        End Get
        Set(dateVal As DateTime)
            _mstrAccessTimeStamp = dateVal

        End Set
    End Property
    Public Property Success As Integer
        Get
            Return _mintSuccess
        End Get
        Set(intVal As Integer)
            _mintSuccess = intVal

        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList
        'this property's code will create the parameters for the stored procedure to save a record 
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("pid", _mstrPID))
            params.Add(New SqlParameter("accessTimeStamp", _mstrAccessTimeStamp))
            params.Add(New SqlParameter("success", _mintSuccess))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer
        Dim paramsPID = New ArrayList
        paramsPID.Add(New SqlParameter("pid", _mstrPID))
        Dim intResult As Integer = myDB.GetSingleValueFromSP("sp_CheckPIDExists", paramsPID)
        If intResult = 0 Then ' The PID doesn't exist so return 0
            Return 0
        End If

        Return myDB.ExecSP("sp_saveAudit", GetSaveParameters())
    End Function
End Class
