'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmCart.vb
'Purpose:  Contains the shoppping cart form interface and routines allowing
'          a user to keep track of books they've added and the total cost.
'          Is currently being loaded with junk data to show formatting.

Public Class frmCart

    'provides access to parent form
    Dim mainParent As frmMain

    'running total of book costs
    Dim runningTotal As Double

    'list box format string
    Dim frmtString As String = "{0,-20} {1,-49} {2,-6:C}"


    'Name: btnBack_Click 
    'Purpose: close form and reset menu object states
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        mainParent.closeCart()
        Me.Close()
    End Sub


    'Name: frmCart_Disposed 
    'Purpose: call closeCart on dispose
    'Parameters: the form and the event
    'Return: none
    Private Sub frmCart_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        mainParent.closeCart()
    End Sub


    'Name: frmCart_Load
    'Purpose: sets cart form's (frmCart) initial states and adds member's items to cart
    'Parameters: the form and the event
    'Return: none
    Private Sub frmCart_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            mainParent = Me.MdiParent
            mainParent.mnuCheckout.Enabled = True
            runningTotal = 0
            CartQuery = "Select * From " & CartTable & " Where IDNumber = '" & loggedInMember & "'"
            retrieveTable(CartQuery, CartDT)
            BooksQuery = "Select * From " & BooksTable
            retrieveTable(BooksQuery, BooksDT)
            mainParent.mnuCheckout.Enabled = True
            Dim count As Integer = 0
            While count < CartDT.Rows.Count
                Dim isbn As String = CartDT.Rows(count).Item("ISBN")
                Dim bookRow As Integer = searchBookByID(isbn)
                Dim title As String = BooksDT.Rows(bookRow).Item("Title")
                Dim price As Double = BooksDT.Rows(bookRow).Item("Price")
                lstBooks.Items.Add(String.Format(frmtString, isbn, title, price))
                runningTotal = runningTotal + price
                count = count + 1
            End While
            txtTotal.Text = FormatCurrency(runningTotal)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub

End Class