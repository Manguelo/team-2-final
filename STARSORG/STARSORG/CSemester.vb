Imports System.Data.SqlClient
Public Class CSemester

    Private _mstrSemesterID As String
    Private _mstrSemesterDescription As String
    Private _isNewSemester As Boolean
    ' constructor
    Public Sub New()
        _mstrSemesterID = ""
        _mstrSemesterDescription = ""
    End Sub
#Region "Exposed Properties"
    Public Property SemesterID As String
        Get
            Return _mstrSemesterID
        End Get
        Set(strVal As String)
            _mstrSemesterID = strVal
        End Set
    End Property
    Public Property SemesterDescription As String
        Get
            Return _mstrSemesterDescription
        End Get
        Set(strVal As String)
            _mstrSemesterDescription = strVal

        End Set
    End Property
    Public Property IsNewSemester As Boolean
        Get
            Return _isNewSemester
        End Get
        Set(blnval As Boolean)
            _isNewSemester = blnval
        End Set
    End Property
    Public ReadOnly Property GetSaveParameters() As ArrayList

        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            params.Add(New SqlParameter("semesterDescription", _mstrSemesterDescription))
            Return params
        End Get
    End Property
#End Region
    Public Function Save() As Integer

        If IsNewSemester Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("semesterID", _mstrSemesterID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckSemesterIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not UNIQUE!!!
            End If
        End If

        Return myDB.ExecSP("sp_saveSemester", GetSaveParameters())
    End Function
End Class

