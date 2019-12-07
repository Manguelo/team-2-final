Imports System.Data.SqlClient
Public Class CEvent
    Private _mstrEventID As String
    Private _mstrEventDescription As String
    Private _mstrEventTypeID As String
    Private _mstrSemID As String
    Private _mstrStartDate As Date
    Private _mstrEndDate As Date
    Private _mstrLocation As String
    Private _isNewEvent As Boolean

    Public Sub New()
        _mstrEventID = ""
        _mstrEventDescription = ""
        _mstrEventTypeID = ""
        _mstrSemID = ""
        _mstrStartDate = Nothing
        _mstrEndDate = Nothing
        _mstrLocation = ""
    End Sub

#Region "Event Properties"
    Public Property EventID As String
        Get
            Return _mstrEventID
        End Get
        Set(strVal As String)
            _mstrEventID = strVal
        End Set
    End Property
    Public Property EventDescription As String
        Get
            Return _mstrEventDescription
        End Get
        Set(strVal As String)
            _mstrEventDescription = strVal
        End Set
    End Property
    Public Property EventTypeID As String
        Get
            Return _mstrEventTypeID
        End Get
        Set(strVal As String)
            _mstrEventTypeID = strVal
        End Set
    End Property
    Public Property SemesterID As String
        Get
            Return _mstrSemID
        End Get
        Set(strVal As String)
            _mstrSemID = strVal
        End Set
    End Property
    Public Property StartDate As Date
        Get
            Return _mstrStartDate
        End Get
        Set(dateVal As Date)
            _mstrStartDate = dateVal
        End Set
    End Property

    Public Property EndDate As Date
        Get
            Return _mstrEndDate
        End Get
        Set(dateVal As Date)
            _mstrEndDate = dateVal
        End Set
    End Property


    Public Property Location As String
        Get
            Return _mstrLocation
        End Get
        Set(strVal As String)
            _mstrLocation = strVal
        End Set
    End Property
    Public Property isNewEvent As Boolean
        Get
            Return _isNewEvent
        End Get
        Set(blnVal As Boolean)
            _isNewEvent = blnVal
        End Set
    End Property
    Public ReadOnly Property GetSavedParameters() As ArrayList
        'this property code will create the parameters for the stored procedures to save a record
        Get
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            params.Add(New SqlParameter("eventDescription", _mstrEventDescription))
            params.Add(New SqlParameter("eventTypeID", _mstrEventTypeID))
            params.Add(New SqlParameter("semesterID", _mstrSemID))
            params.Add(New SqlParameter("startDate", _mstrStartDate))
            params.Add(New SqlParameter("endDate", _mstrEndDate))
            params.Add(New SqlParameter("location", _mstrLocation))
            Return params
        End Get
    End Property


#End Region
    Public Function Save() As Integer
        'return -1 if the ID already exists (and we cannot create a new record with a duplicate ID)
        If isNewEvent Then
            Dim params As New ArrayList
            params.Add(New SqlParameter("eventID", _mstrEventID))
            Dim strResult As String = myDB.GetSingleValueFromSP("sp_CheckEventIDExists", params)
            If Not strResult = 0 Then
                Return -1 'not unique
            End If
        End If
            'if not a new role, or it is new and has a unique ID, then do the save update or insert
            Return myDB.execSP("sp_SaveEvent", GetSavedParameters())
    End Function

End Class
