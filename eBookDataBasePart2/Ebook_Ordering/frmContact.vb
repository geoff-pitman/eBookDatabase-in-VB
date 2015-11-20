'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmContact.vb
'Purpose: Contains the contact form interface and the routines allowing
'         a user to "submit" their contact info and message

Public Class frmContact

    'Name: btnClose_Click
    'Purpose: close the form
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Dispose()
    End Sub

    'Name: btnSubmit_Click
    'Purpose: checks text field validity, then "submits" info and closes the form
    'Parameters: the button and the event 
    'Return: none
    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        If txtName.Text = "" Then
            MessageBox.Show("You must have a name", "Error")
            txtName.Focus()
        ElseIf txtEmail.Text = "" Then
            MessageBox.Show("You must have an Email", "Error")
            txtEmail.Focus()
        ElseIf txtSubject.Text = "" Then
            MessageBox.Show("You must have a Subject", "Error")
            txtSubject.Focus()
        ElseIf txtMessage.Text = "" Then
            MessageBox.Show("You must have a Message", "Error")
            txtMessage.Focus()
        Else
            Dim buttonclick As Integer = MessageBox.Show("Your message has been sent", "Sent Message")
            If DialogResult.OK Then
                Me.Dispose()
            End If
        End If
    End Sub

End Class