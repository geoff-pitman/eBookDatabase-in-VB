'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmBooks.vb
'Purpose: Contains the interface and routines necessary for members to interact
'         with records from the books data table.  Allows members to browse books
'         and specify a genre.

Public Class frmBooks

    'provides access to parent form
    Dim mainParent As frmMain

    'Name: Display 
    'Purpose: loads the books data table into a data grid view object 
    'Parameters: none 
    'Return: none
    Private Sub Display()
        Try
            retrieveTable(BooksQuery, BooksDT)
            dgvBooks.DataSource = BooksDT
            dgvBooks.AutoResizeColumns()
            dgvBooks.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
            dgvBooks.Columns.Item("Price").DefaultCellStyle.Format = "c"

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub

    'Name: frmBooks_Disposed 
    'Purpose: call closeBooks sub on form's dispose
    'Parameters: the form and the event 
    'Return: none
    Private Sub frmBooks_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        mainParent.closeBooks()
    End Sub


    'Name: frmBooks_Load 
    'Purpose: set the books form's (frmBooks) initial state and assigns parent
    'Parameters: the form and the event 
    'Return: none
    Private Sub frmBooks_Load(sender As Object, e As EventArgs) Handles Me.Load
        mainParent = Me.MdiParent
        Try
            BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable
            Display()
            If loggedIn = True Then
                mnuAddcart.Enabled = True
                CartQuery = "Select * From " & CartTable
                retrieveTable(CartQuery, CartDT)
            Else
                mnuAddcart.Enabled = False
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: mnuAddcart_Click 
    'Purpose: add book to cart
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuAddcart_Click(sender As Object, e As EventArgs) Handles mnuAddcart.Click
        Try
            Dim isbn As String = dgvBooks.CurrentRow.Cells(0).Value
            Dim id As String = loggedInMember
            Dim addRow As DataRow = CartDT.NewRow()
            addRow.Item("ISBN") = isbn
            addRow.Item("IDNumber") = id
            CartDT.Rows.Add(addRow)
            updateTable(CartQuery, CartDT)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: mnuAll_Click 
    'Purpose: select all categories
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuAll_Click(sender As Object, e As EventArgs) Handles mnuAll.Click
        uncheckOptions()
        mnuAll.Checked = True
        BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable
        Display()
    End Sub


    'Name: mnuBiography_Click 
    'Purpose: select biography category
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuBiography_Click(sender As Object, e As EventArgs) Handles mnuBiography.Click
        uncheckOptions()
        mnuBiography.Checked = True
        BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable & _
                     " Where Genre = 'biography'"
        Display()
    End Sub

    'Name: mnuClose_Click 
    'Purpose: performs dispose call
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuClose_Click(sender As Object, e As EventArgs) Handles mnuClose.Click
        Me.Dispose()
    End Sub

    'Name: mnuFiction_Click 
    'Purpose: select fiction category
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuFiction_Click(sender As Object, e As EventArgs) Handles mnuFiction.Click
        uncheckOptions()
        mnuFiction.Checked = True
        BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable & _
                     " Where Genre = 'fiction'"
        Display()
    End Sub

    'Name: mnuMystery_Click 
    'Purpose: select mystery and crime category
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuMystery_Click(sender As Object, e As EventArgs) Handles mnuMystery.Click
        uncheckOptions()
        mnuMystery.Checked = True
        BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable & _
                     " Where Genre = 'mystery and crime'"
        Display()
    End Sub

    'Name: mnuOther_Click 
    'Purpose: retrieves user input and selects other category
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuOther_Click(sender As Object, e As EventArgs) Handles mnuOther.Click
        uncheckOptions()
        Dim input As String = InputBox("Enter another category...")
        mnuOther.Checked = True
        BooksQuery = "Select ISBN, Title, Author, NewItem, Price From " & BooksTable & _
                     " Where Genre = '" & input & "'"
        Display()
        Try
            If BooksDT.Rows.Count = 0 Then
                MessageBox.Show("No records found")
                mnuOther.Checked = False
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: uncheckOptions 
    'Purpose: uncheck all category menu items
    'Parameters: none
    'Return: none
    Private Sub uncheckOptions()
        mnuBiography.Checked = False
        mnuFiction.Checked = False
        mnuMystery.Checked = False
        mnuOther.Checked = False
        mnuAll.Checked = False
    End Sub


End Class