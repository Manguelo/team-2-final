Imports System.Data.SqlClient
Public Class CMembers
    'Represents teh MEMBER table and its associated business rules
    Private _Member As CMember

    'Constructor
    Public Sub New()
        'instantiate the Cmember object
        _Member = New CMember
    End Sub

    Public ReadOnly Property CurrentObject() As CMember
        Get
            Return _Member
        End Get
    End Property

    Public Sub Clear()
        _Member = New CMember
    End Sub

    Public Sub CreateNewMember()
        'Call this when clearing the edit portion to any new role
        Clear()
        _Member.isNewMember = True
    End Sub

    Public Function Save() As Integer
        Return _Member.Save()
    End Function

    Public Function GetAllMembers() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_GetAllMembers", Nothing)
        Return objDR
    End Function

    Public Function GetMemberByPID(PID As String) As CMember
        Dim params As New ArrayList
        'Dim objDR As SqlDataReader
        params.Add(New SqlParameter("pid", PID))
        'objDR = myDB.GetDataReaderBySP("sp_getMemberByLName", params)
        'Return objDR

        Return FillObject(myDB.GetDataReaderBySP("sp_getMemberByPID", params))
    End Function

    Public Function GetMemberByLName(LName As String) As CMember
        Dim params As New ArrayList
        'Dim objDR As SqlDataReader
        params.Add(New SqlParameter("lname", LName))
        'objDR = myDB.GetDataReaderBySP("sp_getMemberByLName", params)
        'Return objDR

        Return FillObject(myDB.GetDataReaderBySP("sp_getMemberByLName", params))
    End Function

    Private Function FillObject(objDR As SqlDataReader) As CMember
        If objDR.Read Then
            With _Member
                .PID = objDR("PID")
                .FName = objDR.Item("FName")
                .LName = objDR.Item("LName")
                .MI = objDR.Item("MI")
                .Email = objDR.Item("Email")
                .Phone = objDR.Item("Phone")
                .PhotoPath = objDR.Item("PhotoPath")
                '.SecRole = objDR.Item("SecRole")
            End With
        Else 'no record was returned
        End If
        objDR.Close()
        Return _Member
    End Function

End Class
