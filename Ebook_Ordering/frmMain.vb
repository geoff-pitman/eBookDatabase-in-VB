'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmMain.vb
'Purpose: Contains the ebook ordering interface which is used as a starting off point for
'         the application, provides access to the other forms, and contains routines to
'         maintain application organzation and integrity.

Public Class frmMain

    'to create instances of child forms
    Dim memberForm As frmMember
    Dim booksForm As frmBooks
    Dim cartForm As frmCart

    'to find record in data table
    Dim currentRow As Integer

    'Name: closeCart
    'Purpose: resets menu and toolbar object states
    'Parameters: none
    'Return: none
    Public Sub closeCart()
        mnuCheckout.Enabled = False
        mnuViewcart.Enabled = True
        tbrCart.Enabled = True
        mnuMember.Enabled = True
    End Sub


    'Name: closeBooks
    'Purpose: resets menu and toolbar object states
    'Parameters: none
    'Return: none
    Public Sub closeBooks()
        mnuBrowse.Enabled = True
        tbrBrowse.Enabled = True
    End Sub


    'Name: frmMain_Load 
    'Purpose: determines specific states of certain objects when the program loads
    'Parameters: the form and the event 
    'Return: none
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        sbrTime.Text = FormatDateTime(Now.ToLongTimeString)
        mnuCart.Enabled = False
        mnuMember.Enabled = False
        mnuCheckout.Enabled = False
        tbrCart.Enabled = False
        sbrName.Text = "Ebook Ordering"
    End Sub


    'Name: Logout
    'Purpose: resets menu, status bar, and toolbar object states
    'Parameters: none
    'Return: none
    Public Sub Logout()
        Try
            mnuCart.Enabled = False
            mnuLogin.Enabled = True
            mnuMember.Enabled = False
            tbrLogin.Enabled = True
            tbrCart.Enabled = False
            loggedIn = False
            loggedInMember = -1
            sbrName.Text = "Ebook Ordering"
            If Application.OpenForms().OfType(Of frmBooks).Any Then
                booksForm.Close()
            End If
            If Application.OpenForms().OfType(Of frmMember).Any Then
                memberForm.Close()
            End If
            If Application.OpenForms().OfType(Of frmCart).Any Then
                cartForm.Close()
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: mnuBrowse_Click 
    'Purpose: creates instance of books form (frmBooks)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuBrowse_Click(sender As Object, e As EventArgs) Handles mnuBrowse.Click
        booksForm = New frmBooks
        booksForm.MdiParent = Me
        mnuBrowse.Enabled = False
        tbrBrowse.Enabled = False
        booksForm.Show()
    End Sub


    'Name: mnuCheckout_Click 
    'Purpose: update member balance and remove items from cart
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuCheckout_Click(sender As Object, e As EventArgs) Handles mnuCheckout.Click
        Try
            Dim total As Double = CDbl(cartForm.txtTotal.Text)
            currentRow = searchMemberByID(loggedInMember)
            Dim bal = MembersDT.Rows(currentRow).Item("Balance")
            If MembersDT.Rows(currentRow).Item("MemberLevel") = "Gold" Then
                total = total * 0.9
                bal = bal + total
            Else
                bal = bal + total
            End If
            MembersDT.Rows(currentRow).Item("Balance") = bal
            CartQuery = "Select * From " & CartTable & " Where IDNumber = '" & loggedInMember & "'"
            retrieveTable(CartQuery, CartDT)
            Dim count As Integer = (CartDT.Rows.Count)
            While (count - 1) > -1
                CartDT.Rows(count - 1).Delete()
                count = count - 1
            End While
            CartQuery = "Select * From " & CartTable
            updateTable(MembersQuery, MembersDT)
            updateTable(CartQuery, CartDT)
            cartForm.Dispose()
            mnuCheckout.Enabled = False
            MessageBox.Show("The order has been placed.  Your new balance is " _
                           & FormatCurrency(MembersDT.Rows(currentRow).Item("Balance")), "Confirmed")
        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: mnuContact_Click 
    'Purpose: opens contact form (frmContact)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuContact_Click(sender As Object, e As EventArgs) Handles mnuContact.Click
        frmContact.ShowDialog()
    End Sub


    'Name: mnuCreate_Click 
    'Purpose: creates instance of member form (frmMember)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuCreate_Click(sender As Object, e As EventArgs) Handles mnuCreate.Click
        memberForm = New frmMember
        memberForm.MdiParent = Me
        memberForm.txtPassword.Visible = True
        memberForm.lblPassword.Visible = True
        memberForm.txtReenter.Visible = True
        memberForm.lblReenter.Visible = True
        memberForm.btnCreate.Visible = True
        mnuLogin.Enabled = False
        tbrLogin.Enabled = False
        memberForm.Show()
    End Sub


    'Name: mnuDelete_Click 
    'Purpose: creates instance of member form (frmMember)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuDelete_Click(sender As Object, e As EventArgs) Handles mnuDelete.Click
        memberForm = New frmMember
        memberForm.MdiParent = Me
        memberForm.btnDelete.Visible = True
        mnuMember.Enabled = False
        memberForm.Show()
    End Sub


    'Name: mnuExisting_Click 
    'Purpose: opens login form (frmLogin)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuExisting_Click(sender As Object, e As EventArgs) Handles mnuExisting.Click
        frmLogin.ShowDialog()
        Try
            If loggedIn = True Then
                mnuCart.Enabled = True
                mnuMember.Enabled = True
                mnuLogin.Enabled = False
                tbrLogin.Enabled = False
                tbrCart.Enabled = True
                currentRow = searchMemberByID(loggedInMember)
                sbrName.Text = "Welcome, Mr/Ms. " & MembersDT.Rows(currentRow).Item("LastName")
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: mnuLogout_Click 
    'Purpose: logs out user
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuLogout_Click(sender As Object, e As EventArgs) Handles mnuLogout.Click
        Dim response As Integer = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
        If response = vbYes Then
            Logout()
        End If
    End Sub


    'Name: mnuPay_Click 
    'Purpose: creates instance of member form (frmMember)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuPay_Click(sender As Object, e As EventArgs) Handles mnuPay.Click
        memberForm = New frmMember
        memberForm.MdiParent = Me
        memberForm.txtBalance.Visible = True
        memberForm.lblBalance.Visible = True
        memberForm.txtPayment.Visible = True
        memberForm.lblPayment.Visible = True
        memberForm.btnPay.Visible = True
        mnuMember.Enabled = False
        memberForm.Show()
    End Sub


    'Name: mnuViewcart_Click 
    'Purpose: creates instance of cart form (frmCart)
    'Parameters: the menu item and the event 
    'Return: none
    Private Sub mnuViewcart_Click(sender As Object, e As EventArgs) Handles mnuViewcart.Click
        cartForm = New frmCart
        cartForm.MdiParent = Me
        mnuViewcart.Enabled = False
        tbrCart.Enabled = False
        mnuMember.Enabled = False 'so the user will not see an outdated balance if member form were to be open
        cartForm.Show()
    End Sub


    'Name: tbrBrowse_Click 
    'Purpose: creates instance of books form (frmBooks)
    'Parameters: the toolbar item and the event 
    'Return: none
    Private Sub tbrBrowse_Click(sender As Object, e As EventArgs) Handles tbrBrowse.Click
        mnuBrowse.PerformClick()
    End Sub


    'Name: tbrCart_Click 
    'Purpose: creates instance of cart form (frmCart)
    'Parameters: the toolbar item and the event 
    'Return: none
    Private Sub tbrCart_Click(sender As Object, e As EventArgs) Handles tbrCart.Click
        mnuViewcart.PerformClick()
    End Sub


    'Name: tbrContact_Click 
    'Purpose: opens form Contact_Us (frmContact)
    'Parameters: the toolbar item and the event 
    'Return: none
    Private Sub tbrContact_Click(sender As Object, e As EventArgs) Handles tbrContact.Click
        mnuContact.PerformClick()
    End Sub


    'Name: tbrExit_Click 
    'Purpose: quits the program
    'Parameters: the toolbar item and the event 
    'Return: none
    Private Sub tbrExit_Click(sender As Object, e As EventArgs) Handles tbrExit.Click
        End
    End Sub

    'Name: tbrLogin_Click 
    'Purpose: opens login form (frmLogin)
    'Parameters: the toolbar item and the event 
    'Return: none
    Private Sub tbrLogin_Click(sender As Object, e As EventArgs) Handles tbrLogin.Click
        mnuExisting.PerformClick()
    End Sub


    'Name: tmTime_Tick
    'Purpose: updates the time every second
    'Parameters: the timer and the event 
    'Return: none
    Private Sub tmTime_Tick(sender As Object, e As EventArgs) Handles tmTime.Tick
        sbrTime.Text = FormatDateTime(Now.ToLongTimeString)
    End Sub


End Class

