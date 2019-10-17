<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculationOutput
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
        Me.tblyCalculationTableLayout = New System.Windows.Forms.TableLayoutPanel()
        Me.lblNumPeopleOutput = New System.Windows.Forms.Label()
        Me.lblTotalPayOutput = New System.Windows.Forms.Label()
        Me.lblAvgPayPerPersonOutput = New System.Windows.Forms.Label()
        Me.lblTotalPiecesLabel = New System.Windows.Forms.Label()
        Me.lblNumPeopleLabel = New System.Windows.Forms.Label()
        Me.lblTotalPayLabel = New System.Windows.Forms.Label()
        Me.lblAvgPayPerPersonLabel = New System.Windows.Forms.Label()
        Me.lblTotalNumPiecesOutput = New System.Windows.Forms.Label()
        Me.lblSummaryHeader = New System.Windows.Forms.Label()
        Me.btnSummaryOK = New System.Windows.Forms.Button()
        Me.tblyCalculationTableLayout.SuspendLayout()
        Me.SuspendLayout()
        '
        'tblyCalculationTableLayout
        '
        Me.tblyCalculationTableLayout.ColumnCount = 2
        Me.tblyCalculationTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.12861!))
        Me.tblyCalculationTableLayout.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.87139!))
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblNumPeopleOutput, 1, 1)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPayOutput, 1, 2)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblAvgPayPerPersonOutput, 1, 3)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPiecesLabel, 0, 0)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblNumPeopleLabel, 0, 1)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPayLabel, 0, 2)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblAvgPayPerPersonLabel, 0, 3)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalNumPiecesOutput, 1, 0)
        Me.tblyCalculationTableLayout.Cursor = System.Windows.Forms.Cursors.SizeNESW
        Me.tblyCalculationTableLayout.Location = New System.Drawing.Point(3, 90)
        Me.tblyCalculationTableLayout.Name = "tblyCalculationTableLayout"
        Me.tblyCalculationTableLayout.RowCount = 4
        Me.tblyCalculationTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblyCalculationTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblyCalculationTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblyCalculationTableLayout.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.tblyCalculationTableLayout.Size = New System.Drawing.Size(381, 162)
        Me.tblyCalculationTableLayout.TabIndex = 0
        '
        'lblNumPeopleOutput
        '
        Me.lblNumPeopleOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblNumPeopleOutput.AutoSize = True
        Me.lblNumPeopleOutput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPeopleOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumPeopleOutput.Location = New System.Drawing.Point(323, 58)
        Me.lblNumPeopleOutput.Name = "lblNumPeopleOutput"
        Me.lblNumPeopleOutput.Size = New System.Drawing.Size(55, 22)
        Me.lblNumPeopleOutput.TabIndex = 6
        Me.lblNumPeopleOutput.Text = "88888"
        Me.lblNumPeopleOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblNumPeopleOutput.Visible = False
        '
        'lblTotalPayOutput
        '
        Me.lblTotalPayOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPayOutput.AutoSize = True
        Me.lblTotalPayOutput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPayOutput.Location = New System.Drawing.Point(281, 98)
        Me.lblTotalPayOutput.Name = "lblTotalPayOutput"
        Me.lblTotalPayOutput.Size = New System.Drawing.Size(97, 22)
        Me.lblTotalPayOutput.TabIndex = 5
        Me.lblTotalPayOutput.Text = "$888888.88"
        Me.lblTotalPayOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblTotalPayOutput.Visible = False
        '
        'lblAvgPayPerPersonOutput
        '
        Me.lblAvgPayPerPersonOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvgPayPerPersonOutput.AutoSize = True
        Me.lblAvgPayPerPersonOutput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgPayPerPersonOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgPayPerPersonOutput.Location = New System.Drawing.Point(290, 140)
        Me.lblAvgPayPerPersonOutput.Name = "lblAvgPayPerPersonOutput"
        Me.lblAvgPayPerPersonOutput.Size = New System.Drawing.Size(88, 22)
        Me.lblAvgPayPerPersonOutput.TabIndex = 7
        Me.lblAvgPayPerPersonOutput.Text = "$88888.88"
        Me.lblAvgPayPerPersonOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblAvgPayPerPersonOutput.Visible = False
        '
        'lblTotalPiecesLabel
        '
        Me.lblTotalPiecesLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPiecesLabel.AutoSize = True
        Me.lblTotalPiecesLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPiecesLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPiecesLabel.Location = New System.Drawing.Point(3, 18)
        Me.lblTotalPiecesLabel.Name = "lblTotalPiecesLabel"
        Me.lblTotalPiecesLabel.Size = New System.Drawing.Size(233, 22)
        Me.lblTotalPiecesLabel.TabIndex = 0
        Me.lblTotalPiecesLabel.Text = "Number of completed pieces:"
        Me.lblTotalPiecesLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblNumPeopleLabel
        '
        Me.lblNumPeopleLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblNumPeopleLabel.AutoSize = True
        Me.lblNumPeopleLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNumPeopleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblNumPeopleLabel.Location = New System.Drawing.Point(3, 58)
        Me.lblNumPeopleLabel.Name = "lblNumPeopleLabel"
        Me.lblNumPeopleLabel.Size = New System.Drawing.Size(262, 22)
        Me.lblNumPeopleLabel.TabIndex = 2
        Me.lblNumPeopleLabel.Text = "Number of contributing workers:"
        Me.lblNumPeopleLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotalPayLabel
        '
        Me.lblTotalPayLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPayLabel.AutoSize = True
        Me.lblTotalPayLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPayLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPayLabel.Location = New System.Drawing.Point(3, 98)
        Me.lblTotalPayLabel.Name = "lblTotalPayLabel"
        Me.lblTotalPayLabel.Size = New System.Drawing.Size(227, 22)
        Me.lblTotalPayLabel.TabIndex = 1
        Me.lblTotalPayLabel.Text = "Grand total paid to workers:"
        Me.lblTotalPayLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAvgPayPerPersonLabel
        '
        Me.lblAvgPayPerPersonLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAvgPayPerPersonLabel.AutoSize = True
        Me.lblAvgPayPerPersonLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgPayPerPersonLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgPayPerPersonLabel.Location = New System.Drawing.Point(3, 140)
        Me.lblAvgPayPerPersonLabel.Name = "lblAvgPayPerPersonLabel"
        Me.lblAvgPayPerPersonLabel.Size = New System.Drawing.Size(200, 22)
        Me.lblAvgPayPerPersonLabel.TabIndex = 3
        Me.lblAvgPayPerPersonLabel.Text = "Average pay per worker:"
        Me.lblAvgPayPerPersonLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotalNumPiecesOutput
        '
        Me.lblTotalNumPiecesOutput.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalNumPiecesOutput.AutoSize = True
        Me.lblTotalNumPiecesOutput.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalNumPiecesOutput.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalNumPiecesOutput.Location = New System.Drawing.Point(287, 18)
        Me.lblTotalNumPiecesOutput.Name = "lblTotalNumPiecesOutput"
        Me.lblTotalNumPiecesOutput.Size = New System.Drawing.Size(91, 22)
        Me.lblTotalNumPiecesOutput.TabIndex = 4
        Me.lblTotalNumPiecesOutput.Text = "888888888"
        Me.lblTotalNumPiecesOutput.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.lblTotalNumPiecesOutput.Visible = False
        '
        'lblSummaryHeader
        '
        Me.lblSummaryHeader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSummaryHeader.AutoSize = True
        Me.lblSummaryHeader.Font = New System.Drawing.Font("Trebuchet MS", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSummaryHeader.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer))
        Me.lblSummaryHeader.Location = New System.Drawing.Point(128, 27)
        Me.lblSummaryHeader.Name = "lblSummaryHeader"
        Me.lblSummaryHeader.Size = New System.Drawing.Size(131, 35)
        Me.lblSummaryHeader.TabIndex = 1
        Me.lblSummaryHeader.Text = "Summary"
        Me.lblSummaryHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnSummaryOK
        '
        Me.btnSummaryOK.BackColor = System.Drawing.Color.Black
        Me.btnSummaryOK.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSummaryOK.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnSummaryOK.Location = New System.Drawing.Point(151, 283)
        Me.btnSummaryOK.Name = "btnSummaryOK"
        Me.btnSummaryOK.Size = New System.Drawing.Size(84, 30)
        Me.btnSummaryOK.TabIndex = 2
        Me.btnSummaryOK.Text = "OK"
        Me.btnSummaryOK.UseVisualStyleBackColor = False
        '
        'frmCalculationOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(386, 342)
        Me.Controls.Add(Me.btnSummaryOK)
        Me.Controls.Add(Me.lblSummaryHeader)
        Me.Controls.Add(Me.tblyCalculationTableLayout)
        Me.Name = "frmCalculationOutput"
        Me.Text = "frmCalculationOutput"
        Me.tblyCalculationTableLayout.ResumeLayout(False)
        Me.tblyCalculationTableLayout.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tblyCalculationTableLayout As TableLayoutPanel
    Friend WithEvents lblTotalPiecesLabel As Label
    Friend WithEvents lblNumPeopleLabel As Label
    Friend WithEvents lblTotalPayLabel As Label
    Friend WithEvents lblAvgPayPerPersonLabel As Label
    Friend WithEvents lblNumPeopleOutput As Label
    Friend WithEvents lblTotalPayOutput As Label
    Friend WithEvents lblAvgPayPerPersonOutput As Label
    Friend WithEvents lblTotalNumPiecesOutput As Label
    Friend WithEvents lblSummaryHeader As Label
    Friend WithEvents btnSummaryOK As Button
End Class
