<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPiecework_A
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPiecework_A))
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
        Me.grpSummaryInfo = New System.Windows.Forms.GroupBox()
        Me.lblTotalNumPiecesOutput = New System.Windows.Forms.Label()
        Me.lblTotalPayOutput = New System.Windows.Forms.Label()
        Me.lblNumPeopleOutput = New System.Windows.Forms.Label()
        Me.lblAvgPayPerPersonOutput = New System.Windows.Forms.Label()
        Me.lblAvgPayPerPerson = New System.Windows.Forms.Label()
        Me.lblNumberPeopleTotalPay = New System.Windows.Forms.Label()
        Me.lblTotalNumPieces = New System.Windows.Forms.Label()
        Me.grpSummaryInfo.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtName
        '
        Me.txtName.BackColor = System.Drawing.Color.Gainsboro
        Me.txtName.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.ForeColor = System.Drawing.Color.Black
        Me.txtName.Location = New System.Drawing.Point(20, 62)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(152, 24)
        Me.txtName.TabIndex = 0
        '
        'txtNumberOfPieces
        '
        Me.txtNumberOfPieces.BackColor = System.Drawing.Color.Gainsboro
        Me.txtNumberOfPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNumberOfPieces.ForeColor = System.Drawing.Color.Black
        Me.txtNumberOfPieces.Location = New System.Drawing.Point(193, 62)
        Me.txtNumberOfPieces.Name = "txtNumberOfPieces"
        Me.txtNumberOfPieces.Size = New System.Drawing.Size(152, 24)
        Me.txtNumberOfPieces.TabIndex = 1
        '
        'lblPersonName
        '
        Me.lblPersonName.AutoSize = True
        Me.lblPersonName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPersonName.Location = New System.Drawing.Point(20, 36)
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
        Me.Label2.Location = New System.Drawing.Point(193, 36)
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
        Me.lblEarnedAmountLabel.Location = New System.Drawing.Point(44, 112)
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
        Me.lblEarnedAmountOutput.Location = New System.Drawing.Point(193, 112)
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
        Me.btnCalculate.Location = New System.Drawing.Point(375, 62)
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
        Me.btnClear.Location = New System.Drawing.Point(375, 112)
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
        Me.btnSummary.Location = New System.Drawing.Point(20, 170)
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
        Me.btnPurgeData.Location = New System.Drawing.Point(203, 170)
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
        Me.btnExit.Location = New System.Drawing.Point(375, 170)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 27)
        Me.btnExit.TabIndex = 10
        Me.btnExit.TabStop = False
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'grpSummaryInfo
        '
        Me.grpSummaryInfo.Controls.Add(Me.lblTotalNumPiecesOutput)
        Me.grpSummaryInfo.Controls.Add(Me.lblTotalPayOutput)
        Me.grpSummaryInfo.Controls.Add(Me.lblNumPeopleOutput)
        Me.grpSummaryInfo.Controls.Add(Me.lblAvgPayPerPersonOutput)
        Me.grpSummaryInfo.Controls.Add(Me.lblAvgPayPerPerson)
        Me.grpSummaryInfo.Controls.Add(Me.lblNumberPeopleTotalPay)
        Me.grpSummaryInfo.Controls.Add(Me.lblTotalNumPieces)
        Me.grpSummaryInfo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpSummaryInfo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.grpSummaryInfo.Location = New System.Drawing.Point(20, 233)
        Me.grpSummaryInfo.Name = "grpSummaryInfo"
        Me.grpSummaryInfo.Size = New System.Drawing.Size(500, 190)
        Me.grpSummaryInfo.TabIndex = 11
        Me.grpSummaryInfo.TabStop = False
        Me.grpSummaryInfo.Text = "Summary Information"
        '
        'lblTotalNumPiecesOutput
        '
        Me.lblTotalNumPiecesOutput.AutoSize = True
        Me.lblTotalNumPiecesOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumPiecesOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalNumPiecesOutput.Location = New System.Drawing.Point(372, 37)
        Me.lblTotalNumPiecesOutput.Name = "lblTotalNumPiecesOutput"
        Me.lblTotalNumPiecesOutput.Size = New System.Drawing.Size(108, 20)
        Me.lblTotalNumPiecesOutput.TabIndex = 9
        Me.lblTotalNumPiecesOutput.Text = "88888888888"
        Me.lblTotalNumPiecesOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalNumPiecesOutput.Visible = False
        '
        'lblTotalPayOutput
        '
        Me.lblTotalPayOutput.AutoSize = True
        Me.lblTotalPayOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPayOutput.Location = New System.Drawing.Point(390, 83)
        Me.lblTotalPayOutput.Name = "lblTotalPayOutput"
        Me.lblTotalPayOutput.Size = New System.Drawing.Size(89, 20)
        Me.lblTotalPayOutput.TabIndex = 8
        Me.lblTotalPayOutput.Text = "$ 88888.88"
        Me.lblTotalPayOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblTotalPayOutput.Visible = False
        '
        'lblNumPeopleOutput
        '
        Me.lblNumPeopleOutput.AutoSize = True
        Me.lblNumPeopleOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPeopleOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumPeopleOutput.Location = New System.Drawing.Point(28, 83)
        Me.lblNumPeopleOutput.Name = "lblNumPeopleOutput"
        Me.lblNumPeopleOutput.Size = New System.Drawing.Size(36, 20)
        Me.lblNumPeopleOutput.TabIndex = 7
        Me.lblNumPeopleOutput.Text = "888"
        Me.lblNumPeopleOutput.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.lblNumPeopleOutput.Visible = False
        '
        'lblAvgPayPerPersonOutput
        '
        Me.lblAvgPayPerPersonOutput.AutoSize = True
        Me.lblAvgPayPerPersonOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgPayPerPersonOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgPayPerPersonOutput.Location = New System.Drawing.Point(390, 129)
        Me.lblAvgPayPerPersonOutput.Name = "lblAvgPayPerPersonOutput"
        Me.lblAvgPayPerPersonOutput.Size = New System.Drawing.Size(89, 20)
        Me.lblAvgPayPerPersonOutput.TabIndex = 6
        Me.lblAvgPayPerPersonOutput.Text = "$ 88888.88"
        Me.lblAvgPayPerPersonOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.lblAvgPayPerPersonOutput.Visible = False
        '
        'lblAvgPayPerPerson
        '
        Me.lblAvgPayPerPerson.AutoSize = True
        Me.lblAvgPayPerPerson.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgPayPerPerson.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgPayPerPerson.Location = New System.Drawing.Point(62, 129)
        Me.lblAvgPayPerPerson.Name = "lblAvgPayPerPerson"
        Me.lblAvgPayPerPerson.Size = New System.Drawing.Size(180, 20)
        Me.lblAvgPayPerPerson.TabIndex = 5
        Me.lblAvgPayPerPerson.Text = "Average Pay Per Person"
        Me.lblAvgPayPerPerson.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNumberPeopleTotalPay
        '
        Me.lblNumberPeopleTotalPay.AutoSize = True
        Me.lblNumberPeopleTotalPay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumberPeopleTotalPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumberPeopleTotalPay.Location = New System.Drawing.Point(71, 83)
        Me.lblNumberPeopleTotalPay.Name = "lblNumberPeopleTotalPay"
        Me.lblNumberPeopleTotalPay.Size = New System.Drawing.Size(172, 20)
        Me.lblNumberPeopleTotalPay.TabIndex = 4
        Me.lblNumberPeopleTotalPay.Text = "# of People -- Total Pay"
        Me.lblNumberPeopleTotalPay.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotalNumPieces
        '
        Me.lblTotalNumPieces.AutoSize = True
        Me.lblTotalNumPieces.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumPieces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalNumPieces.Location = New System.Drawing.Point(70, 37)
        Me.lblTotalNumPieces.Name = "lblTotalNumPieces"
        Me.lblTotalNumPieces.Size = New System.Drawing.Size(173, 20)
        Me.lblTotalNumPieces.TabIndex = 3
        Me.lblTotalNumPieces.Text = "Total Number of Pieces"
        Me.lblTotalNumPieces.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'frmPiecework_A
        '
        Me.AcceptButton = Me.btnCalculate
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(541, 472)
        Me.Controls.Add(Me.grpSummaryInfo)
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
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximumSize = New System.Drawing.Size(557, 511)
        Me.MinimumSize = New System.Drawing.Size(557, 511)
        Me.Name = "frmPiecework_A"
        Me.Text = "Piece Rate Earnings"
        Me.grpSummaryInfo.ResumeLayout(False)
        Me.grpSummaryInfo.PerformLayout()
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
    Friend WithEvents grpSummaryInfo As GroupBox
    Private WithEvents lblAvgPayPerPersonOutput As Label
    Private WithEvents lblAvgPayPerPerson As Label
    Private WithEvents lblNumberPeopleTotalPay As Label
    Private WithEvents lblTotalNumPieces As Label
    Private WithEvents lblNumPeopleOutput As Label
    Private WithEvents lblTotalNumPiecesOutput As Label
    Private WithEvents lblTotalPayOutput As Label
End Class
