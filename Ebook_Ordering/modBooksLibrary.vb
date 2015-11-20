'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: modBooksLibrary.vb
'Purpose: Contains the objects and routines that provide access and functionality
'         to the database the application will be working with

Module modBooksLibrary

    'name of table in database
    Public Const BooksTable As String = "Books"

    'SQL query to search database
    Public BooksQuery As String

    'creates instance of books data table
    Public BooksDT As New DataTable


    'Name: searchBookByID
    'Purpose: finds a record in book data table by ISBN number
    'Parameters: ISBN number as a string
    'Return: index of record, or -1 if nothing found
    Public Function searchBookByID(ByVal id As String) As Integer

        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < BooksDT.Rows.Count And Not found
            If BooksDT.Rows(i).RowState = DataRowState.Deleted Then
                i += 1
            Else
                If BooksDT.Rows(i).Item("ISBN") = id Then
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
