'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: modShoppingCartLibrary.vb
'Purpose: Contains the objects and routines that provide access and functionality
'         to the database the application will be working with

Module modShoppingCartLibrary

    'if a member is logged in or not
    Public loggedIn As Boolean = False

    'account/name of logged in member
    Public loggedInMember As String

    'name of table in database
    Public Const CartTable As String = "ShoppingCarts"

    'SQL query to search database
    Public CartQuery As String

    'creates instance of cart data table
    Public CartDT As New DataTable

    'Name: searchCartByID
    'Purpose: finds a record in cart data table by item id
    'Parameters: item id as a string
    'Return: index of record, or -1 if nothing found
    Public Function searchCartByID(ByVal id As String) As Integer
        Dim i As Integer = 0
        Dim found As Boolean = False

        While i < CartDT.Rows.Count And Not found
            If CartDT.Rows(i).RowState = DataRowState.Deleted Then
                i += 1
            Else
                If CartDT.Rows(i).Item("ID") = id Then
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
