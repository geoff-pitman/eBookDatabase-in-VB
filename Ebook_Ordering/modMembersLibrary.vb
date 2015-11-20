'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: modMembersLibrary.vb
'Purpose: Contains the objects and routines that provide access and functionality
'         to the database the application will be working with

Module modMembersLibrary

    'name of table in database
    Public Const MembersTable As String = "Members"

    'SQL query to search database
    Public MembersQuery As String

    'creates instance of members data table
    Public MembersDT As New DataTable


    'Name: searchMemberByID
    'Purpose: finds a record in member data table by member id number
    'Parameters: member id number as a string
    'Return: index of record, or -1 if nothing found
    Public Function searchMemberByID(ByVal id As String) As Integer
        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < MembersDT.Rows.Count And Not found
            If MembersDT.Rows(i).RowState = DataRowState.Deleted Then
                i += 1
            Else
                If MembersDT.Rows(i).Item("IDNumber") = id Then
                    found = True
                Else
                    i += 1
                End If
            End If
        End While
        If found Then
            Return i
        Else
            Return -1
        End If
    End Function

    'Name: searchMemberByLast
    'Purpose: finds a record in member data table by member last name
    'Parameters: member last name as a string
    'Return: index of record, or -1 if nothing found
    Public Function searchMemberByLast(ByVal lastname As String) As Integer
        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < MembersDT.Rows.Count And Not found
            If MembersDT.Rows(i).RowState = DataRowState.Deleted Then
                i += 1
            Else
                If MembersDT.Rows(i).Item("LastName") = lastname Then
                    found = True
                Else
                    i += 1
                End If
            End If
        End While
        If found Then
            Return i
        Else
            Return -1
        End If
    End Function


End Module
