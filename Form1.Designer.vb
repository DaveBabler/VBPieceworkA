<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPiecework_B
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiecework_B))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfPieces = New System.Windows.Forms.TextBox()
        Me.lblPersonName = New System.Windows.Forms.Label()
        Me.lblNumberOfPieces = New System.Windows.Forms.Label()
        Me.lblEarnedAmountLabel = New System.Windows.Forms.Label()
        Me.lblEarnedAmountOutput = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileCalculate = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileSummary = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuFilePrint = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuFileExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEdit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditClear = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditClearAll = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuEditFont = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuEditColor = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuHelp = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuAbout = New System.Windows.Forms.ToolStripMenuItem()
        Me.printPieceRateForm = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(20, 106)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 24)
        Me.txtName.TabIndex = 0
        '
        'txtNumberOfPieces
        '
        Me.txtNumberOfPieces.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumberOfPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfPieces.ForeColor = System.Drawing.Color.Black
        Me.txtNumberOfPieces.Location = New System.Drawing.Point(193, 106)
        Me.txtNumberOfPieces.Name = "txtNumberOfPieces"
        Me.txtNumberOfPieces.Size = New System.Drawing.Size(152, 24)
        Me.txtNumberOfPieces.TabIndex = 1
        '
        'lblPersonName
        '
        Me.lblPersonName.AutoSize = True
        Me.lblPersonName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonName.Location = New System.Drawing.Point(20, 80)
        Me.lblPersonName.Name = "lblPersonName"
        Me.lblPersonName.Size = New System.Drawing.Size(116, 20)
        Me.lblPersonName.TabIndex = 2
        Me.lblPersonName.Text = "Person's Name"
        Me.lblPersonName.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNumberOfPieces
        '
        Me.lblNumberOfPieces.AutoSize = True
        Me.lblNumberOfPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberOfPieces.Location = New System.Drawing.Point(193, 80)
        Me.lblNumberOfPieces.Name = "lblNumberOfPieces"
        Me.lblNumberOfPieces.Size = New System.Drawing.Size(134, 20)
        Me.lblNumberOfPieces.TabIndex = 3
        Me.lblNumberOfPieces.Text = "Number of Pieces"
        Me.lblNumberOfPieces.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblEarnedAmountLabel
        '
        Me.lblEarnedAmountLabel.AutoSize = True
        Me.lblEarnedAmountLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarnedAmountLabel.Location = New System.Drawing.Point(20, 156)
        Me.lblEarnedAmountLabel.Name = "lblEarnedAmountLabel"
        Me.lblEarnedAmountLabel.Size = New System.Drawing.Size(121, 20)
        Me.lblEarnedAmountLabel.TabIndex = 4
        Me.lblEarnedAmountLabel.Text = "Earned Amount"
        Me.lblEarnedAmountLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'lblEarnedAmountOutput
        '
        Me.lblEarnedAmountOutput.AutoSize = True
        Me.lblEarnedAmountOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEarnedAmountOutput.Location = New System.Drawing.Point(189, 156)
        Me.lblEarnedAmountOutput.Name = "lblEarnedAmountOutput"
        Me.lblEarnedAmountOutput.Size = New System.Drawing.Size(76, 20)
        Me.lblEarnedAmountOutput.TabIndex = 5
        Me.lblEarnedAmountOutput.Text = "$8888.88"
        Me.lblEarnedAmountOutput.Visible = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuEdit, Me.mnuHelp})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(386, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.BackColor = System.Drawing.Color.Black
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFileCalculate, Me.mnuFileSummary, Me.ToolStripSeparator1, Me.mnuFilePrint, Me.mnuFileExit})
        Me.mnuFile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "&File"
        '
        'mnuFileCalculate
        '
        Me.mnuFileCalculate.Name = "mnuFileCalculate"
        Me.mnuFileCalculate.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileCalculate.Text = "&Calculate Pay"
        '
        'mnuFileSummary
        '
        Me.mnuFileSummary.Enabled = False
        Me.mnuFileSummary.Name = "mnuFileSummary"
        Me.mnuFileSummary.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileSummary.Text = "&Summary"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'mnuFilePrint
        '
        Me.mnuFilePrint.Name = "mnuFilePrint"
        Me.mnuFilePrint.Size = New System.Drawing.Size(180, 22)
        Me.mnuFilePrint.Text = "&Print"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Name = "mnuFileExit"
        Me.mnuFileExit.Size = New System.Drawing.Size(180, 22)
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuEdit
        '
        Me.mnuEdit.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuEditClear, Me.mnuEditClearAll, Me.ToolStripSeparator2, Me.mnuEditFont, Me.mnuEditColor})
        Me.mnuEdit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuEdit.Name = "mnuEdit"
        Me.mnuEdit.Size = New System.Drawing.Size(39, 20)
        Me.mnuEdit.Text = "&Edit"
        '
        'mnuEditClear
        '
        Me.mnuEditClear.Name = "mnuEditClear"
        Me.mnuEditClear.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditClear.Text = "Clea&r"
        '
        'mnuEditClearAll
        '
        Me.mnuEditClearAll.Name = "mnuEditClearAll"
        Me.mnuEditClearAll.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditClearAll.Text = "Clear All"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'mnuEditFont
        '
        Me.mnuEditFont.Name = "mnuEditFont"
        Me.mnuEditFont.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditFont.Text = "&Font"
        '
        'mnuEditColor
        '
        Me.mnuEditColor.Name = "mnuEditColor"
        Me.mnuEditColor.Size = New System.Drawing.Size(180, 22)
        Me.mnuEditColor.Text = "&Color"
        '
        'mnuHelp
        '
        Me.mnuHelp.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuAbout})
        Me.mnuHelp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.mnuHelp.Name = "mnuHelp"
        Me.mnuHelp.Size = New System.Drawing.Size(44, 20)
        Me.mnuHelp.Text = "&Help"
        '
        'mnuAbout
        '
        Me.mnuAbout.Name = "mnuAbout"
        Me.mnuAbout.Size = New System.Drawing.Size(180, 22)
        Me.mnuAbout.Text = "&About"
        '
        'printPieceRateForm
        '
        Me.printPieceRateForm.DocumentName = "document"
        Me.printPieceRateForm.Form = Me
        Me.printPieceRateForm.PrintAction = System.Drawing.Printing.PrintAction.PrintToPreview
        Me.printPieceRateForm.PrinterSettings = CType(resources.GetObject("printPieceRateForm.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.printPieceRateForm.PrintFileName = "Piece Rate Earnings"
        '
        'frmPiecework_B
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(386, 216)
        Me.Controls.Add(Me.lblEarnedAmountOutput)
        Me.Controls.Add(Me.lblEarnedAmountLabel)
        Me.Controls.Add(Me.lblNumberOfPieces)
        Me.Controls.Add(Me.lblPersonName)
        Me.Controls.Add(Me.txtNumberOfPieces)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.Name = "frmPiecework_B"
        Me.Text = "Piece Rate Earnings"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtName As TextBox
    Friend WithEvents txtNumberOfPieces As TextBox
    Friend WithEvents lblNumberOfPieces As Label
    Friend WithEvents lblEarnedAmountLabel As Label
    Friend WithEvents lblEarnedAmountOutput As Label
    Private WithEvents lblPersonName As Label
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents mnuFile As ToolStripMenuItem
    Friend WithEvents mnuFileCalculate As ToolStripMenuItem
    Friend WithEvents mnuFileSummary As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents mnuFilePrint As ToolStripMenuItem
    Friend WithEvents mnuFileExit As ToolStripMenuItem
    Friend WithEvents mnuEdit As ToolStripMenuItem
    Friend WithEvents mnuEditClear As ToolStripMenuItem
    Friend WithEvents mnuEditClearAll As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents mnuEditFont As ToolStripMenuItem
    Friend WithEvents mnuEditColor As ToolStripMenuItem
    Friend WithEvents mnuHelp As ToolStripMenuItem
    Friend WithEvents mnuAbout As ToolStripMenuItem
    Friend WithEvents printPieceRateForm As PowerPacks.Printing.PrintForm
End Class
