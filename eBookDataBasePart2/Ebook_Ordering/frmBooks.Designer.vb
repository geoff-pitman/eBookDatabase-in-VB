<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBooks
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
        Me.mnuBooksform = New System.Windows.Forms.MenuStrip()
        Me.mnuClose = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuCategory = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMystery = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFiction = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuBiography = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuOther = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAddcart = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvBooks = New System.Windows.Forms.DataGridView()
        Me.mnuBooksform.SuspendLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuBooksform
        '
        Me.mnuBooksform.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuClose, Me.mnuCategory, Me.mnuAddcart})
        Me.mnuBooksform.Location = New System.Drawing.Point(0, 0)
        Me.mnuBooksform.Name = "mnuBooksform"
        Me.mnuBooksform.Size = New System.Drawing.Size(721, 24)
        Me.mnuBooksform.TabIndex = 0
        Me.mnuBooksform.Text = "MenuStrip1"
        '
        'mnuClose
        '
        Me.mnuClose.Name = "mnuClose"
        Me.mnuClose.Size = New System.Drawing.Size(48, 20)
        Me.mnuClose.Text = "Close"
        '
        'mnuCategory
        '
        Me.mnuCategory.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMystery, Me.mnuFiction, Me.mnuBiography, Me.mnuAll, Me.mnuOther})
        Me.mnuCategory.Name = "mnuCategory"
        Me.mnuCategory.Size = New System.Drawing.Size(101, 20)
        Me.mnuCategory.Text = "Select Category"
        '
        'mnuMystery
        '
        Me.mnuMystery.Name = "mnuMystery"
        Me.mnuMystery.Size = New System.Drawing.Size(174, 22)
        Me.mnuMystery.Text = "Mystery and Crime"
        '
        'mnuFiction
        '
        Me.mnuFiction.Name = "mnuFiction"
        Me.mnuFiction.Size = New System.Drawing.Size(174, 22)
        Me.mnuFiction.Text = "Fiction"
        '
        'mnuBiography
        '
        Me.mnuBiography.Name = "mnuBiography"
        Me.mnuBiography.Size = New System.Drawing.Size(174, 22)
        Me.mnuBiography.Text = "Biography"
        '
        'mnuAll
        '
        Me.mnuAll.Checked = True
        Me.mnuAll.CheckState = System.Windows.Forms.CheckState.Checked
        Me.mnuAll.Name = "mnuAll"
        Me.mnuAll.Size = New System.Drawing.Size(174, 22)
        Me.mnuAll.Text = "All"
        '
        'mnuOther
        '
        Me.mnuOther.Name = "mnuOther"
        Me.mnuOther.Size = New System.Drawing.Size(174, 22)
        Me.mnuOther.Text = "Other"
        '
        'mnuAddcart
        '
        Me.mnuAddcart.Name = "mnuAddcart"
        Me.mnuAddcart.Size = New System.Drawing.Size(80, 20)
        Me.mnuAddcart.Text = "Add to Cart"
        '
        'dgvBooks
        '
        Me.dgvBooks.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBooks.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvBooks.Location = New System.Drawing.Point(0, 24)
        Me.dgvBooks.Name = "dgvBooks"
        Me.dgvBooks.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.dgvBooks.Size = New System.Drawing.Size(721, 351)
        Me.dgvBooks.TabIndex = 1
        '
        'frmBooks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(721, 375)
        Me.Controls.Add(Me.dgvBooks)
        Me.Controls.Add(Me.mnuBooksform)
        Me.MainMenuStrip = Me.mnuBooksform
        Me.Name = "frmBooks"
        Me.Text = "Ebooks"
        Me.mnuBooksform.ResumeLayout(False)
        Me.mnuBooksform.PerformLayout()
        CType(Me.dgvBooks, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mnuBooksform As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuClose As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuCategory As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMystery As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFiction As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuBiography As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAll As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuOther As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuAddcart As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents dgvBooks As System.Windows.Forms.DataGridView
End Class
