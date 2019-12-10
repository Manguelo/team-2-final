﻿Module modGlobal
    'contains all variables, constants, procedures, and functions 
    'that need to be accessed in more than one forum

#Region "Action Constants"
    Public Const ACTION_NONE As Integer = 0
    Public Const ACTION_HOME As Integer = 1
    Public Const ACTION_MEMBER As Integer = 2
    Public Const ACTION_ROLE As Integer = 3
    Public Const ACTION_EVENT As Integer = 4
    Public Const ACTION_RSVP As Integer = 5
    Public Const ACTION_COURSE As Integer = 6
    Public Const ACTION_SEMESTER As Integer = 7
    Public Const ACTION_TUTOR As Integer = 8
    Public Const ACTION_HELP As Integer = 9
    Public Const ACTION_LOGOUT As Integer = 10
#End Region
#Region "Security Roles"
    Public Const ADMIN_ROLE As String = "ADMIN"
    Public Const OFFICER_ROLE As String = "OFFICER"
    Public Const MEMBER_ROLE As String = "MEMBER"
    Public Const GUEST_ROLE As String = "GUEST"


#End Region
    Public intNextAction As Integer
    Public myDB As New CDB
    Public currentSecurity As CSecurity
End Module
