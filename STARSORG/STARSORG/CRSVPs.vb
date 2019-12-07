Imports System.Data.SqlClient
Public Class CRSVPs
    Private _RSVP As CRSVP
    'constructor
    Public Sub New()
        'instantiate the CRSVP object
        _RSVP = New CRSVP
    End Sub

    Public ReadOnly Property CurrentObject() As CRSVP
        Get
            Return _RSVP
        End Get
    End Property
    Public Sub Clear()
        _RSVP = New CRSVP
    End Sub
    Public Sub CreateNewRSVP()
        'call this when clearing the edit portion of the screen to add a new role
        Clear()
        _RSVP.isNewRSVP = True
    End Sub
    Public Function Save() As Integer
        Return _RSVP.Save()
    End Function

    Public Function GetAllEvents() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllEvents", Nothing) 'CHANGE THIS
        Return objDR
    End Function

    'Private Function FillObject(objDR As SqlDataReader) As CRSVP
    '    If objDR.Read Then
    '        With _RSVP
    '            .RoleID = objDR.Item("RoleID")
    '            .RoleDescription = objDR.Item("RoleDescription") 'CHANGE THIS
    '        End With
    '    Else 'no record was returned
    '        'nothing to do here
    '    End If
    '    objDR.Close()
    '    Return _RSVP
    'End Function
End Class
