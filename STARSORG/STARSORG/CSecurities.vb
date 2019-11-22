Imports System.Data.SqlClient
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

End Class
