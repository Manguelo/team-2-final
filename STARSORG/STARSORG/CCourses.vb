Imports System.Data.SqlClient
Public Class CCourses

    Private _Course As CCourse

    Public Sub New()

        _Course = New CCourse
    End Sub

    Public ReadOnly Property CurrentObject As CCourse
        Get
            Return _Course
        End Get
    End Property
    Public Sub Clear()
        _Course = New CCourse
    End Sub
    Public Sub CreateNewCourse()

        Clear()
        _Course.IsNewCourse = True
    End Sub
    Public Function Save() As Integer
        Return _Course.Save()
    End Function
    Public Function GetAllCourses() As SqlDataReader
        Dim objDR As SqlDataReader
        objDR = myDB.GetDataReaderBySP("sp_getCourses", Nothing)
        Return objDR
    End Function
    Public Function GetCourseByCourseID(strID As String) As CCourse
        Dim params As New ArrayList
        params.Add(New SqlParameter("CourseID", strID))
        FillObject(myDB.GetDataReaderBySP("sp_getCourseByCourseID", params))
        Return _Course
    End Function
    Public Function FillObject(objDR As SqlDataReader) As CCourse
        If objDR.Read Then
            With _Course
                .CourseID = objDR("CourseID")
                .CourseName = objDR.Item("CourseName")
            End With
        End If
        objDR.Close()
        Return _Course
    End Function
End Class
