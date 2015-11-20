'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: modDataBaseLibrary.vb
'Purpose: Contains the objects and routines that provide access and functionality
'         to the database the application will be working with

Module modDatabaseLibrary

    'database file to access
    Private Const DatabaseFile As String = "ebooks.accdb"

    'connection string
    Public Const c_connectionString As String = "Provider=Microsoft.ACE.OLEDB.12.0;" & _
                                                "Data Source = " & DatabaseFile

    'Name: retrieveTable
    'Purpose: retrieves records from data table based on SQL query 
    'Parameters: SQL query and data table
    'Return: none
    Public Sub retrieveTable(ByVal query As String, ByRef memoryTable As DataTable)
        Try
            Dim aTableAdapter As New OleDb.OleDbDataAdapter(query, c_connectionString)
            memoryTable.Clear()
            aTableAdapter.Fill(memoryTable)
            aTableAdapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message, "RETRIEVAL ERROR")
        End Try

    End Sub

    'Name: updateTable
    'Purpose: updates records in data table
    'Parameters: SQL query and data table
    'Return: none
    Public Sub updateTable(ByVal query As String, ByRef memoryTable As DataTable)
        Try
            Dim aTableAdapter As New OleDb.OleDbDataAdapter(query, c_connectionString)
            Dim aCommBuilder As New OleDb.OleDbCommandBuilder(aTableAdapter)
            aTableAdapter.Update(memoryTable)
            aCommBuilder.Dispose()
            aTableAdapter.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message(), "UPDATE ERROR")
        End Try
    End Sub

End Module
