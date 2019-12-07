Public Class CAudits
    'Represents the role table and it's associated business roles
    Private _Audit As CAudit
    'constructor
    Public Sub New()
        'instantiate the CAudit object
        _Audit = New CAudit
    End Sub
    Public ReadOnly Property CurrentObject As CAudit
        Get
            Return _Audit
        End Get
    End Property
    Public Sub Clear()
        _Audit = New CAudit
    End Sub
    Public Function SaveAttempt() As Integer
        Return _Audit.Save()
    End Function
End Class
