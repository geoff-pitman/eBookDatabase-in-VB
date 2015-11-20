<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMember
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreate = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnPay = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblID = New System.Windows.Forms.Label()
        Me.lblLast = New System.Windows.Forms.Label()
        Me.lblFirst = New System.Windows.Forms.Label()
        Me.lblPhone = New System.Windows.Forms.Label()
        Me.lblPassword = New System.Windows.Forms.Label()
        Me.lblPayment = New System.Windows.Forms.Label()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.lblReenter = New System.Windows.Forms.Label()
        Me.radGold = New System.Windows.Forms.RadioButton()
        Me.grpLevel = New System.Windows.Forms.GroupBox()
        Me.radStandard = New System.Windows.Forms.RadioButton()
        Me.txtLast = New System.Windows.Forms.TextBox()
        Me.txtFirst = New System.Windows.Forms.TextBox()
        Me.txtBalance = New System.Windows.Forms.TextBox()
        Me.grpMember = New System.Windows.Forms.GroupBox()
        Me.txtReenter = New System.Windows.Forms.TextBox()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtPayment = New System.Windows.Forms.TextBox()
        Me.grpLevel.SuspendLayout()
        Me.grpMember.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Location = New System.Drawing.Point(665, 129)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(84, 54)
        Me.btnCreate.TabIndex = 12
        Me.btnCreate.Text = "Create Account"
        Me.btnCreate.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(665, 205)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(84, 54)
        Me.btnDelete.TabIndex = 13
        Me.btnDelete.Text = "Delete Account"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnPay
        '
        Me.btnPay.Location = New System.Drawing.Point(665, 50)
        Me.btnPay.Name = "btnPay"
        Me.btnPay.Size = New System.Drawing.Size(84, 54)
        Me.btnPay.TabIndex = 11
        Me.btnPay.Text = "Make Payment"
        Me.btnPay.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(665, 280)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(84, 54)
        Me.btnCancel.TabIndex = 14
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblID
        '
        Me.lblID.AutoSize = True
        Me.lblID.Location = New System.Drawing.Point(23, 26)
        Me.lblID.Name = "lblID"
        Me.lblID.Size = New System.Drawing.Size(59, 13)
        Me.lblID.TabIndex = 100
        Me.lblID.Text = "Member ID"
        '
        'lblLast
        '
        Me.lblLast.AutoSize = True
        Me.lblLast.Location = New System.Drawing.Point(23, 63)
        Me.lblLast.Name = "lblLast"
        Me.lblLast.Size = New System.Drawing.Size(58, 13)
        Me.lblLast.TabIndex = 101
        Me.lblLast.Text = "Last Name"
        '
        'lblFirst
        '
        Me.lblFirst.AutoSize = True
        Me.lblFirst.Location = New System.Drawing.Point(23, 101)
        Me.lblFirst.Name = "lblFirst"
        Me.lblFirst.Size = New System.Drawing.Size(57, 13)
        Me.lblFirst.TabIndex = 102
        Me.lblFirst.Text = "First Name"
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(23, 140)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(38, 13)
        Me.lblPhone.TabIndex = 103
        Me.lblPhone.Text = "Phone"
        '
        'lblPassword
        '
        Me.lblPassword.AutoSize = True
        Me.lblPassword.Location = New System.Drawing.Point(312, 104)
        Me.lblPassword.Name = "lblPassword"
        Me.lblPassword.Size = New System.Drawing.Size(53, 13)
        Me.lblPassword.TabIndex = 106
        Me.lblPassword.Text = "Password"
        '
        'lblPayment
        '
        Me.lblPayment.AutoSize = True
        Me.lblPayment.Location = New System.Drawing.Point(312, 66)
        Me.lblPayment.Name = "lblPayment"
        Me.lblPayment.Size = New System.Drawing.Size(48, 13)
        Me.lblPayment.TabIndex = 105
        Me.lblPayment.Text = "Payment"
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Location = New System.Drawing.Point(314, 29)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(46, 13)
        Me.lblBalance.TabIndex = 104
        Me.lblBalance.Text = "Balance"
        '
        'lblReenter
        '
        Me.lblReenter.AutoSize = True
        Me.lblReenter.Location = New System.Drawing.Point(312, 143)
        Me.lblReenter.Name = "lblReenter"
        Me.lblReenter.Size = New System.Drawing.Size(97, 13)
        Me.lblReenter.TabIndex = 107
        Me.lblReenter.Text = "Re-enter Password"
        '
        'radGold
        '
        Me.radGold.AutoSize = True
        Me.radGold.Location = New System.Drawing.Point(6, 51)
        Me.radGold.Name = "radGold"
        Me.radGold.Size = New System.Drawing.Size(47, 17)
        Me.radGold.TabIndex = 6
        Me.radGold.TabStop = True
        Me.radGold.Text = "Gold"
        Me.radGold.UseVisualStyleBackColor = True
        '
        'grpLevel
        '
        Me.grpLevel.Controls.Add(Me.radStandard)
        Me.grpLevel.Controls.Add(Me.radGold)
        Me.grpLevel.Location = New System.Drawing.Point(26, 184)
        Me.grpLevel.Name = "grpLevel"
        Me.grpLevel.Size = New System.Drawing.Size(88, 74)
        Me.grpLevel.TabIndex = 4
        Me.grpLevel.TabStop = False
        Me.grpLevel.Text = "Level"
        '
        'radStandard
        '
        Me.radStandard.AutoSize = True
        Me.radStandard.Location = New System.Drawing.Point(6, 28)
        Me.radStandard.Name = "radStandard"
        Me.radStandard.Size = New System.Drawing.Size(68, 17)
        Me.radStandard.TabIndex = 5
        Me.radStandard.TabStop = True
        Me.radStandard.Text = "Standard"
        Me.radStandard.UseVisualStyleBackColor = True
        '
        'txtLast
        '
        Me.txtLast.Location = New System.Drawing.Point(106, 63)
        Me.txtLast.MaxLength = 20
        Me.txtLast.Name = "txtLast"
        Me.txtLast.Size = New System.Drawing.Size(131, 20)
        Me.txtLast.TabIndex = 1
        '
        'txtFirst
        '
        Me.txtFirst.Location = New System.Drawing.Point(106, 101)
        Me.txtFirst.MaxLength = 15
        Me.txtFirst.Name = "txtFirst"
        Me.txtFirst.Size = New System.Drawing.Size(131, 20)
        Me.txtFirst.TabIndex = 2
        '
        'txtBalance
        '
        Me.txtBalance.Location = New System.Drawing.Point(424, 26)
        Me.txtBalance.Name = "txtBalance"
        Me.txtBalance.ReadOnly = True
        Me.txtBalance.Size = New System.Drawing.Size(122, 20)
        Me.txtBalance.TabIndex = 7
        '
        'grpMember
        '
        Me.grpMember.Controls.Add(Me.txtReenter)
        Me.grpMember.Controls.Add(Me.txtPassword)
        Me.grpMember.Controls.Add(Me.txtPhone)
        Me.grpMember.Controls.Add(Me.txtID)
        Me.grpMember.Controls.Add(Me.txtPayment)
        Me.grpMember.Controls.Add(Me.grpLevel)
        Me.grpMember.Controls.Add(Me.lblID)
        Me.grpMember.Controls.Add(Me.lblLast)
        Me.grpMember.Controls.Add(Me.lblFirst)
        Me.grpMember.Controls.Add(Me.txtBalance)
        Me.grpMember.Controls.Add(Me.lblPhone)
        Me.grpMember.Controls.Add(Me.lblBalance)
        Me.grpMember.Controls.Add(Me.lblReenter)
        Me.grpMember.Controls.Add(Me.lblPayment)
        Me.grpMember.Controls.Add(Me.lblPassword)
        Me.grpMember.Controls.Add(Me.txtFirst)
        Me.grpMember.Controls.Add(Me.txtLast)
        Me.grpMember.Location = New System.Drawing.Point(12, 21)
        Me.grpMember.Name = "grpMember"
        Me.grpMember.Size = New System.Drawing.Size(562, 291)
        Me.grpMember.TabIndex = 120
        Me.grpMember.TabStop = False
        '
        'txtReenter
        '
        Me.txtReenter.Location = New System.Drawing.Point(424, 137)
        Me.txtReenter.MaxLength = 8
        Me.txtReenter.Name = "txtReenter"
        Me.txtReenter.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtReenter.Size = New System.Drawing.Size(122, 20)
        Me.txtReenter.TabIndex = 10
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(424, 101)
        Me.txtPassword.MaxLength = 8
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(122, 20)
        Me.txtPassword.TabIndex = 9
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(106, 138)
        Me.txtPhone.MaxLength = 15
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(131, 20)
        Me.txtPhone.TabIndex = 3
        '
        'txtID
        '
        Me.txtID.Location = New System.Drawing.Point(106, 23)
        Me.txtID.MaxLength = 11
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(131, 20)
        Me.txtID.TabIndex = 0
        '
        'txtPayment
        '
        Me.txtPayment.Location = New System.Drawing.Point(424, 62)
        Me.txtPayment.Name = "txtPayment"
        Me.txtPayment.Size = New System.Drawing.Size(122, 20)
        Me.txtPayment.TabIndex = 8
        '
        'frmMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(825, 356)
        Me.Controls.Add(Me.grpMember)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnPay)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnCreate)
        Me.Name = "frmMember"
        Me.Text = "Members"
        Me.grpLevel.ResumeLayout(False)
        Me.grpLevel.PerformLayout()
        Me.grpMember.ResumeLayout(False)
        Me.grpMember.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnPay As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents lblID As System.Windows.Forms.Label
    Friend WithEvents lblLast As System.Windows.Forms.Label
    Friend WithEvents lblFirst As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblPassword As System.Windows.Forms.Label
    Friend WithEvents lblPayment As System.Windows.Forms.Label
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents lblReenter As System.Windows.Forms.Label
    Friend WithEvents radGold As System.Windows.Forms.RadioButton
    Friend WithEvents grpLevel As System.Windows.Forms.GroupBox
    Friend WithEvents radStandard As System.Windows.Forms.RadioButton
    Friend WithEvents txtLast As System.Windows.Forms.TextBox
    Friend WithEvents txtFirst As System.Windows.Forms.TextBox
    Friend WithEvents txtBalance As System.Windows.Forms.TextBox
    Friend WithEvents grpMember As System.Windows.Forms.GroupBox
    Friend WithEvents txtPayment As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents txtID As System.Windows.Forms.TextBox
    Friend WithEvents txtReenter As System.Windows.Forms.TextBox
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
End Class
