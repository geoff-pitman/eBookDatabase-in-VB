<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.sbrMain = New System.Windows.Forms.StatusStrip()
        Me.sbrPic = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbrName = New System.Windows.Forms.ToolStripStatusLabel()
        Me.sbrTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuLogin = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExisting = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCreate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMember = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuPay = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuDelete = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuLogout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEbooks = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBrowse = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuViewcart = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCheckout = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuContact = New System.Windows.Forms.ToolStripMenuItem()
        Me.tbrMain = New System.Windows.Forms.ToolStrip()
        Me.tbrExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator0 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrLogin = New System.Windows.Forms.ToolStripButton()
        Me.tbrBrowse = New System.Windows.Forms.ToolStripButton()
        Me.tbrCart = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tbrContact = New System.Windows.Forms.ToolStripButton()
        Me.tmTime = New System.Windows.Forms.Timer(Me.components)
        Me.sbrMain.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.tbrMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'sbrMain
        '
        Me.sbrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.sbrPic, Me.sbrName, Me.sbrTime})
        Me.sbrMain.Location = New System.Drawing.Point(0, 242)
        Me.sbrMain.Name = "sbrMain"
        Me.sbrMain.Size = New System.Drawing.Size(839, 22)
        Me.sbrMain.TabIndex = 1
        Me.sbrMain.Text = "StatusStrip1"
        '
        'sbrPic
        '
        Me.sbrPic.Image = CType(resources.GetObject("sbrPic.Image"), System.Drawing.Image)
        Me.sbrPic.Name = "sbrPic"
        Me.sbrPic.Size = New System.Drawing.Size(16, 17)
        '
        'sbrName
        '
        Me.sbrName.Name = "sbrName"
        Me.sbrName.Size = New System.Drawing.Size(758, 17)
        Me.sbrName.Spring = True
        Me.sbrName.Text = "Ebook Ordering"
        '
        'sbrTime
        '
        Me.sbrTime.Image = CType(resources.GetObject("sbrTime.Image"), System.Drawing.Image)
        Me.sbrTime.Name = "sbrTime"
        Me.sbrTime.Size = New System.Drawing.Size(50, 17)
        Me.sbrTime.Text = "Time"
        '
        'mnuMain
        '
        Me.mnuMain.AllowMerge = False
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuLogin, Me.mnuMember, Me.mnuEbooks, Me.mnuCart, Me.mnuContact})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(839, 24)
        Me.mnuMain.TabIndex = 2
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuLogin
        '
        Me.mnuLogin.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuExisting, Me.mnuCreate})
        Me.mnuLogin.Name = "mnuLogin"
        Me.mnuLogin.Size = New System.Drawing.Size(49, 20)
        Me.mnuLogin.Text = "Login"
        '
        'mnuExisting
        '
        Me.mnuExisting.Name = "mnuExisting"
        Me.mnuExisting.Size = New System.Drawing.Size(162, 22)
        Me.mnuExisting.Text = "Existing Account"
        '
        'mnuCreate
        '
        Me.mnuCreate.Name = "mnuCreate"
        Me.mnuCreate.Size = New System.Drawing.Size(162, 22)
        Me.mnuCreate.Text = "Create Account"
        '
        'mnuMember
        '
        Me.mnuMember.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuPay, Me.mnuDelete, Me.mnuLogout})
        Me.mnuMember.Name = "mnuMember"
        Me.mnuMember.Size = New System.Drawing.Size(64, 20)
        Me.mnuMember.Text = "Member"
        '
        'mnuPay
        '
        Me.mnuPay.Name = "mnuPay"
        Me.mnuPay.Size = New System.Drawing.Size(155, 22)
        Me.mnuPay.Text = "Make Payment"
        '
        'mnuDelete
        '
        Me.mnuDelete.Name = "mnuDelete"
        Me.mnuDelete.Size = New System.Drawing.Size(155, 22)
        Me.mnuDelete.Text = "Delete Account"
        '
        'mnuLogout
        '
        Me.mnuLogout.Name = "mnuLogout"
        Me.mnuLogout.Size = New System.Drawing.Size(155, 22)
        Me.mnuLogout.Text = "Logout"
        '
        'mnuEbooks
        '
        Me.mnuEbooks.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuBrowse})
        Me.mnuEbooks.Name = "mnuEbooks"
        Me.mnuEbooks.Size = New System.Drawing.Size(57, 20)
        Me.mnuEbooks.Text = "Ebooks"
        '
        'mnuBrowse
        '
        Me.mnuBrowse.Name = "mnuBrowse"
        Me.mnuBrowse.Size = New System.Drawing.Size(112, 22)
        Me.mnuBrowse.Text = "Browse"
        '
        'mnuCart
        '
        Me.mnuCart.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuViewcart, Me.mnuCheckout})
        Me.mnuCart.Name = "mnuCart"
        Me.mnuCart.Size = New System.Drawing.Size(95, 20)
        Me.mnuCart.Text = "Shopping Cart"
        '
        'mnuViewcart
        '
        Me.mnuViewcart.Name = "mnuViewcart"
        Me.mnuViewcart.Size = New System.Drawing.Size(125, 22)
        Me.mnuViewcart.Text = "View Cart"
        '
        'mnuCheckout
        '
        Me.mnuCheckout.Name = "mnuCheckout"
        Me.mnuCheckout.Size = New System.Drawing.Size(125, 22)
        Me.mnuCheckout.Text = "Checkout"
        '
        'mnuContact
        '
        Me.mnuContact.Name = "mnuContact"
        Me.mnuContact.Size = New System.Drawing.Size(77, 20)
        Me.mnuContact.Text = "Contact Us"
        '
        'tbrMain
        '
        Me.tbrMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tbrExit, Me.ToolStripSeparator0, Me.tbrLogin, Me.tbrBrowse, Me.tbrCart, Me.ToolStripSeparator1, Me.tbrContact})
        Me.tbrMain.Location = New System.Drawing.Point(0, 24)
        Me.tbrMain.Name = "tbrMain"
        Me.tbrMain.Size = New System.Drawing.Size(839, 25)
        Me.tbrMain.TabIndex = 3
        Me.tbrMain.Text = "ToolStrip1"
        '
        'tbrExit
        '
        Me.tbrExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrExit.Image = CType(resources.GetObject("tbrExit.Image"), System.Drawing.Image)
        Me.tbrExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrExit.Name = "tbrExit"
        Me.tbrExit.Size = New System.Drawing.Size(23, 22)
        Me.tbrExit.ToolTipText = "Quit Program"
        '
        'ToolStripSeparator0
        '
        Me.ToolStripSeparator0.Name = "ToolStripSeparator0"
        Me.ToolStripSeparator0.Size = New System.Drawing.Size(6, 25)
        '
        'tbrLogin
        '
        Me.tbrLogin.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrLogin.Image = CType(resources.GetObject("tbrLogin.Image"), System.Drawing.Image)
        Me.tbrLogin.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrLogin.Name = "tbrLogin"
        Me.tbrLogin.Size = New System.Drawing.Size(23, 22)
        Me.tbrLogin.ToolTipText = "Login"
        '
        'tbrBrowse
        '
        Me.tbrBrowse.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrBrowse.Image = CType(resources.GetObject("tbrBrowse.Image"), System.Drawing.Image)
        Me.tbrBrowse.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrBrowse.Name = "tbrBrowse"
        Me.tbrBrowse.Size = New System.Drawing.Size(23, 22)
        Me.tbrBrowse.ToolTipText = "Browse Books"
        '
        'tbrCart
        '
        Me.tbrCart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrCart.Image = CType(resources.GetObject("tbrCart.Image"), System.Drawing.Image)
        Me.tbrCart.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrCart.Name = "tbrCart"
        Me.tbrCart.Size = New System.Drawing.Size(23, 22)
        Me.tbrCart.ToolTipText = "View Cart"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'tbrContact
        '
        Me.tbrContact.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.tbrContact.Image = CType(resources.GetObject("tbrContact.Image"), System.Drawing.Image)
        Me.tbrContact.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tbrContact.Name = "tbrContact"
        Me.tbrContact.Size = New System.Drawing.Size(23, 22)
        Me.tbrContact.ToolTipText = "Contact Us"
        '
        'tmTime
        '
        Me.tmTime.Enabled = True
        Me.tmTime.Interval = 1000
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(839, 264)
        Me.Controls.Add(Me.tbrMain)
        Me.Controls.Add(Me.sbrMain)
        Me.Controls.Add(Me.mnuMain)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Ebook Ordering"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.sbrMain.ResumeLayout(False)
        Me.sbrMain.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.tbrMain.ResumeLayout(False)
        Me.tbrMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents sbrMain As System.Windows.Forms.StatusStrip
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuLogin As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrMain As System.Windows.Forms.ToolStrip
    Friend WithEvents sbrPic As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sbrName As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents sbrTime As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents mnuMember As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuEbooks As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuContact As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tbrExit As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator0 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbrLogin As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrBrowse As System.Windows.Forms.ToolStripButton
    Friend WithEvents tbrCart As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tbrContact As System.Windows.Forms.ToolStripButton
    Friend WithEvents mnuExisting As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCreate As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBrowse As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tmTime As System.Windows.Forms.Timer
    Friend WithEvents mnuPay As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuDelete As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuLogout As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuViewcart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCheckout As System.Windows.Forms.ToolStripMenuItem

End Class
