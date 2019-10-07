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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiecework_B))
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNumberOfPieces = New System.Windows.Forms.TextBox()
        Me.lblPersonName = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblEarnedAmountLabel = New System.Windows.Forms.Label()
        Me.lblEarnedAmountOutput = New System.Windows.Forms.Label()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnSummary = New System.Windows.Forms.Button()
        Me.btnPurgeData = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CalculatePayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(193, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 20)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Number of Pieces"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft
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
        'btnCalculate
        '
        Me.btnCalculate.BackColor = System.Drawing.Color.Black
        Me.btnCalculate.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCalculate.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnCalculate.Location = New System.Drawing.Point(375, 106)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(126, 27)
        Me.btnCalculate.TabIndex = 6
        Me.btnCalculate.Text = "&Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = False
        '
        'btnClear
        '
        Me.btnClear.BackColor = System.Drawing.Color.Black
        Me.btnClear.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnClear.Location = New System.Drawing.Point(375, 156)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(126, 27)
        Me.btnClear.TabIndex = 7
        Me.btnClear.Text = "&Reset/Clear"
        Me.btnClear.UseVisualStyleBackColor = False
        '
        'btnSummary
        '
        Me.btnSummary.BackColor = System.Drawing.Color.Black
        Me.btnSummary.Enabled = False
        Me.btnSummary.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummary.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSummary.Location = New System.Drawing.Point(20, 214)
        Me.btnSummary.Name = "btnSummary"
        Me.btnSummary.Size = New System.Drawing.Size(126, 27)
        Me.btnSummary.TabIndex = 8
        Me.btnSummary.Text = "&Summary"
        Me.btnSummary.UseVisualStyleBackColor = False
        '
        'btnPurgeData
        '
        Me.btnPurgeData.BackColor = System.Drawing.Color.Black
        Me.btnPurgeData.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPurgeData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnPurgeData.Location = New System.Drawing.Point(203, 214)
        Me.btnPurgeData.Name = "btnPurgeData"
        Me.btnPurgeData.Size = New System.Drawing.Size(126, 27)
        Me.btnPurgeData.TabIndex = 9
        Me.btnPurgeData.TabStop = False
        Me.btnPurgeData.Text = "Clear &All"
        Me.btnPurgeData.UseVisualStyleBackColor = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnExit.Location = New System.Drawing.Point(375, 214)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 27)
        Me.btnExit.TabIndex = 10
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(541, 24)
        Me.MenuStrip1.TabIndex = 11
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.BackColor = System.Drawing.Color.Gainsboro
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CalculatePayToolStripMenuItem})
        Me.FileToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(90, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(72, Byte), Integer))
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'CalculatePayToolStripMenuItem
        '
        Me.CalculatePayToolStripMenuItem.Name = "CalculatePayToolStripMenuItem"
        Me.CalculatePayToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CalculatePayToolStripMenuItem.Text = "&Calculate Pay"
        '
        'frmPiecework_B
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(541, 314)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnPurgeData)
        Me.Controls.Add(Me.btnSummary)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnCalculate)
        Me.Controls.Add(Me.lblEarnedAmountOutput)
        Me.Controls.Add(Me.lblEarnedAmountLabel)
        Me.Controls.Add(Me.Label2)
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
    Friend WithEvents Label2 As Label
    Friend WithEvents lblEarnedAmountLabel As Label
    Friend WithEvents lblEarnedAmountOutput As Label
    Private WithEvents lblPersonName As Label
    Friend WithEvents btnCalculate As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnSummary As Button
    Friend WithEvents btnPurgeData As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CalculatePayToolStripMenuItem As ToolStripMenuItem
End Class
