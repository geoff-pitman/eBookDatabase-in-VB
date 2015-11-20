'Project: Ebook Database Part 2
'Author: Geoffrey Pitman
'Creation: November 26, 2014
'Due Date: December 3, 2014
'Course: CSC241 
'Professor Name: Prof. Day 
'File Name: frmMember.vb
'Purpose: Contains the interface and routines necessary to handle member interaction
'         with the application.  It will allow a user to create an account, make
'         payments and delete an account.

Public Class frmMember

    'provides access to parent form
    Dim mainParent As frmMain

    'used to find record in data table
    Dim currentRow As Integer

    'Name: btnCancel_Click 
    'Purpose: to close member form (frmMember)
    'Parameters: the button and the event
    'Return: none
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Dispose()
    End Sub


    'Name: btnCreate_Click 
    'Purpose: to verify input and create new account record in members data table
    'Parameters: the button and the event
    'Return: none
    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        Try
            txtID.Text = txtID.Text.Trim()
            txtLast.Text = txtLast.Text.Trim()
            txtFirst.Text = txtFirst.Text.Trim()
            txtPhone.Text = txtPhone.Text.Trim()
            txtPassword.Text = txtPassword.Text.Trim()
            MembersQuery = "Select * From " & MembersTable
            retrieveTable(MembersQuery, MembersDT)
            If searchMemberByID(txtID.Text) <> -1 Then
                MessageBox.Show("Account already in use", "Error")
                txtID.Clear()
                txtID.Focus()
            ElseIf txtID.Text = "" Then
                MessageBox.Show("You must enter member ID", "Error")
                txtID.Clear()
                txtID.Focus()
            ElseIf txtLast.Text = "" Then
                MessageBox.Show("You must enter a last name", "Error")
                txtLast.Clear()
                txtLast.Focus()
            ElseIf txtFirst.Text = "" Then
                MessageBox.Show("You must enter a first name", "Error")
                txtFirst.Clear()
                txtFirst.Focus()
            ElseIf txtPhone.Text = "" Then
                MessageBox.Show("You must enter a phone number", "Error")
                txtPhone.Clear()
                txtPhone.Focus()
            ElseIf radGold.Checked = False And radStandard.Checked = False Then
                MessageBox.Show("You must select a member level", "Error")
                grpLevel.Focus()
            ElseIf txtPassword.Text.Length <> 8 Then
                MessageBox.Show("You must enter an 8 character password", "Error")
                txtPassword.Clear()
                txtReenter.Clear()
                txtPassword.Focus()
            ElseIf txtReenter.Text <> txtPassword.Text Then
                MessageBox.Show("Reentered password must match password", "Error")
                txtReenter.Clear()
                txtReenter.Focus()
            Else
                txtBalance.Text = 0
                Dim addRow As DataRow = MembersDT.NewRow()
                CopyMemberToRow(addRow)
                MembersDT.Rows.Add(addRow)
                updateTable(MembersQuery, MembersDT)
                MessageBox.Show(txtFirst.Text & ", your account has been created!", "Confirmed")
                Me.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: btnDelete_Click 
    'Purpose: to confirm deletion of account and remove record in data table
    'Parameters: the button and the event
    'Return: none
    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Try
            Dim response As Integer = MessageBox.Show("Are you sure you want to delete account?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)
            If response = vbYes Then
                currentRow = searchMemberByID(txtID.Text)
                MembersDT.Rows(currentRow).Delete()
                updateTable(MembersQuery, MembersDT)
                MessageBox.Show("Account " & txtID.Text & " deleted!", "Confirmed")
                mainParent.Logout()
                Me.Dispose()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: btnPay_Click 
    'Purpose: make a payment and reduce balance on account
    'Parameters: the button and the event
    'Return: none
    Private Sub btnPay_Click(sender As Object, e As EventArgs) Handles btnPay.Click
        Try

            If IsNumeric(txtPayment.Text) = True Then
                Dim pay As Double = CDbl(txtPayment.Text)
                Dim bal As Double = CDbl(txtBalance.Text)
                If bal >= pay Then
                    bal = bal - pay
                    txtBalance.Text = FormatCurrency(bal)
                    txtPayment.Clear()
                    MessageBox.Show("Payment accepted", "Confirmed")
                    currentRow = searchMemberByID(loggedInMember)
                    MembersDT.Rows(currentRow).Item("Balance") = bal
                    updateTable(MembersQuery, MembersDT)
                    Me.Dispose()
                Else
                    MessageBox.Show("Payment exceeds balance", "Error")
                    txtPayment.Clear()
                    txtPayment.Focus()
                End If
            Else
                MessageBox.Show("Enter valid payment amount", "Error")
                txtPayment.Clear()
                txtPayment.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub

    'Name: CopyMemberToRow 
    'Purpose: copies member form input to data row
    'Parameters: member data row
    'Return: none
    Private Sub CopyMemberToRow(ByRef member As DataRow)
        Try 
        With member
            .Item("IDNumber") = txtID.Text
            .Item("FirstName") = txtFirst.Text
            .Item("LastName") = txtLast.Text
            .Item("Balance") = txtBalance.Text
            .Item("PhoneNumber") = txtPhone.Text
            .Item("Passwrd") = txtPassword.Text
            If radStandard.Checked = True Then
                .Item("MemberLevel") = "Standard"
            Else
                .Item("MemberLevel") = "Gold"
            End If
            End With

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub

    'Name: CopyRowToMember
    'Purpose: copies information from data row to member form
    'Parameters: member data row
    'Return: none
    Private Sub CopyRowToMember(ByRef member As DataRow)
        Try
            txtID.Text = member.Item("IDNumber")
            txtFirst.Text = member.Item("FirstName")
            txtLast.Text = member.Item("LastName")
            txtBalance.Text = FormatCurrency(member.Item("Balance"))
            txtPhone.Text = member.Item("PhoneNumber")
            txtPassword.Text = member.Item("Passwrd")
            If member.Item("MemberLevel") = "Standard" Then
                radStandard.Checked = True
            Else
                radGold.Checked = True
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: frmMember_Disposed 
    'Purpose: restore menu and toolbar object states on dipose
    'Parameters: the form and the event
    'Return: none
    Private Sub frmMember_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        If loggedIn = True Then
            mainParent.mnuMember.Enabled = True
        ElseIf btnCreate.Visible = True Then
            mainParent.mnuLogin.Enabled = True
            mainParent.tbrLogin.Enabled = True
            mainParent.mnuMember.Enabled = False
        End If
    End Sub


    'Name: frmMember_Load
    'Purpose: sets parent form and retrieves member info from member data table
    'Parameters: the form and the event
    'Return: none
    Private Sub frmMember_Load(sender As Object, e As EventArgs) Handles Me.Load
        mainParent = Me.MdiParent
        Try
            If loggedIn = True Then
                currentRow = searchMemberByID(loggedInMember)
                CopyRowToMember(MembersDT.Rows(currentRow))
                txtID.ReadOnly = True
                txtFirst.ReadOnly = True
                txtLast.ReadOnly = True
                txtBalance.ReadOnly = True
                txtPhone.ReadOnly = True
                txtPassword.ReadOnly = True
                radGold.Enabled = False
                radStandard.Enabled = False
                Dim bal = CDbl(txtBalance.Text)
                If bal = 0 Then
                    btnPay.Enabled = False
                    txtPayment.ReadOnly = True
                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "ERROR")
        End Try
    End Sub


    'Name: New()
    'Purpose: intialize form object states when instance of frmMember is created
    'Parameters: none
    'Return: none
    Public Sub New()
        InitializeComponent()
        lblBalance.Visible = False
        txtBalance.Visible = False
        lblPayment.Visible = False
        txtPayment.Visible = False
        lblPassword.Visible = False
        txtPassword.Visible = False
        lblReenter.Visible = False
        txtReenter.Visible = False
        btnCreate.Visible = False
        btnDelete.Visible = False
        btnPay.Visible = False
    End Sub


End Class