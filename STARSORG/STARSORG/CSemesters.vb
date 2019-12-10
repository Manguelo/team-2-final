Imports System.Data.SqlClient
Public Class CSemesters

    Private _Semester As CSemester

    Public Sub New()

        _Semester = New CSemester
    End Sub

    Public ReadOnly Property CurrentObject As CSemester
        Get
            Return _Semester
        End Get
    End Property
    Public Sub Clear()
        _Semester = New CSemester
    End Sub
    Public Sub CreateNewSemester()

        Clear()
        _Semester.IsNewSemester = True
    End Sub
    Public Function Save() As Integer
        Return _Semester.Save()
    End Function
    Public Function GetAllSemesters() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getAllSemesters", Nothing)
        Return objDR
    End Function
    Public Function GetSemesterBySemesterID(strID As String) As CSemester
        Dim params As New ArrayList
        params.Add(New SqlParameter("SemesterID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getSemesterBySemesterID", params))
        Return _Semester
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CSemester
        If objDR.Read Then
            With _Semester
                .SemesterID = objDR("SemesterID")
                .SemesterDescription = objDR.Item("SemesterDescription")
            End With
        End If
        objDR.Close()
        Return _Semester
    End Function
End Class
