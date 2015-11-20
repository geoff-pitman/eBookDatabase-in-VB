'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmLogin.vb
'Purpose: Contains the interface and routines necessary to handle member login.

Public Class frmLogin

    'used to find record in data table
    Dim currentRow As Integer

    'Name: btnLogin_Click 
    'Purpose: to get and verify login input from user
    'Parameters: the button and the event
    'Return: none
    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try
            txtLast.Text = txtLast.Text.Trim()
            MembersQuery = "Select * From " & MembersTable & " Where LastName = '" & txtLast.Text & "'"
            retrieveTable(MembersQuery, MembersDT)
            If MembersDT.Rows.Count <> 0 Then
                currentRow = searchMemberByLast(txtLast.Text)
                If MembersDT.Rows(currentRow).Item("Passwrd") = txtPassword.Text Then
                    loggedIn = True
                    loggedInMember = MembersDT.Rows(currentRow).Item("IDNumber")
                    Me.Close()
                Else
                    MessageBox.Show("Invalid Password", "Error")
                    txtPassword.Clear()
                    txtPassword.Focus()
                End If
            Else
                MessageBox.Show("No such User", "Error")
                txtLast.Clear()
                txtPassword.Clear()
                txtLast.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: frmLogin_Load 
    'Purpose: set initial states of login form (frmLogin)
    'Parameters: the button and the event
    'Return: none
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles Me.Load
        txtLast.Focus()
        txtLast.Clear()
        txtPassword.Clear()
    End Sub

End Class