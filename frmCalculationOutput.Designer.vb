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
        Me.lblTotalPiecesLabel = New System.Windows.Forms.Label()
        Me.lblTotalPaidLabel = New System.Windows.Forms.Label()
        Me.lblTotalWorkersLabel = New System.Windows.Forms.Label()
        Me.lblAvgWorkerPayLabel = New System.Windows.Forms.Label()
        Me.lblTotalPieces = New System.Windows.Forms.Label()
        Me.lblTotalWorkers = New System.Windows.Forms.Label()
        Me.lblTotalPaid = New System.Windows.Forms.Label()
        Me.lblAvgWorkerPay = New System.Windows.Forms.Label()
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
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalWorkers, 1, 1)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPaid, 1, 2)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblAvgWorkerPay, 1, 3)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPiecesLabel, 0, 0)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalWorkersLabel, 0, 1)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPaidLabel, 0, 2)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblAvgWorkerPayLabel, 0, 3)
        Me.tblyCalculationTableLayout.Controls.Add(Me.lblTotalPieces, 1, 0)
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
        'lblTotalPaidLabel
        '
        Me.lblTotalPaidLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPaidLabel.AutoSize = True
        Me.lblTotalPaidLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaidLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPaidLabel.Location = New System.Drawing.Point(3, 98)
        Me.lblTotalPaidLabel.Name = "lblTotalPaidLabel"
        Me.lblTotalPaidLabel.Size = New System.Drawing.Size(227, 22)
        Me.lblTotalPaidLabel.TabIndex = 1
        Me.lblTotalPaidLabel.Text = "Grand total paid to workers:"
        Me.lblTotalPaidLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotalWorkersLabel
        '
        Me.lblTotalWorkersLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblTotalWorkersLabel.AutoSize = True
        Me.lblTotalWorkersLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWorkersLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalWorkersLabel.Location = New System.Drawing.Point(3, 58)
        Me.lblTotalWorkersLabel.Name = "lblTotalWorkersLabel"
        Me.lblTotalWorkersLabel.Size = New System.Drawing.Size(262, 22)
        Me.lblTotalWorkersLabel.TabIndex = 2
        Me.lblTotalWorkersLabel.Text = "Number of contributing workers:"
        Me.lblTotalWorkersLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblAvgWorkerPayLabel
        '
        Me.lblAvgWorkerPayLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAvgWorkerPayLabel.AutoSize = True
        Me.lblAvgWorkerPayLabel.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgWorkerPayLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgWorkerPayLabel.Location = New System.Drawing.Point(3, 140)
        Me.lblAvgWorkerPayLabel.Name = "lblAvgWorkerPayLabel"
        Me.lblAvgWorkerPayLabel.Size = New System.Drawing.Size(200, 22)
        Me.lblAvgWorkerPayLabel.TabIndex = 3
        Me.lblAvgWorkerPayLabel.Text = "Average pay per worker:"
        Me.lblAvgWorkerPayLabel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblTotalPieces
        '
        Me.lblTotalPieces.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPieces.AutoSize = True
        Me.lblTotalPieces.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPieces.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPieces.Location = New System.Drawing.Point(287, 18)
        Me.lblTotalPieces.Name = "lblTotalPieces"
        Me.lblTotalPieces.Size = New System.Drawing.Size(91, 22)
        Me.lblTotalPieces.TabIndex = 4
        Me.lblTotalPieces.Text = "888888888"
        Me.lblTotalPieces.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotalWorkers
        '
        Me.lblTotalWorkers.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalWorkers.AutoSize = True
        Me.lblTotalWorkers.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalWorkers.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalWorkers.Location = New System.Drawing.Point(323, 58)
        Me.lblTotalWorkers.Name = "lblTotalWorkers"
        Me.lblTotalWorkers.Size = New System.Drawing.Size(55, 22)
        Me.lblTotalWorkers.TabIndex = 6
        Me.lblTotalWorkers.Text = "88888"
        Me.lblTotalWorkers.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblTotalPaid
        '
        Me.lblTotalPaid.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTotalPaid.AutoSize = True
        Me.lblTotalPaid.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalPaid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblTotalPaid.Location = New System.Drawing.Point(281, 98)
        Me.lblTotalPaid.Name = "lblTotalPaid"
        Me.lblTotalPaid.Size = New System.Drawing.Size(97, 22)
        Me.lblTotalPaid.TabIndex = 5
        Me.lblTotalPaid.Text = "$888888.88"
        Me.lblTotalPaid.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'lblAvgWorkerPay
        '
        Me.lblAvgWorkerPay.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAvgWorkerPay.AutoSize = True
        Me.lblAvgWorkerPay.Font = New System.Drawing.Font("Trebuchet MS", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAvgWorkerPay.ForeColor = System.Drawing.Color.FromArgb(CType(CType(204, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblAvgWorkerPay.Location = New System.Drawing.Point(290, 140)
        Me.lblAvgWorkerPay.Name = "lblAvgWorkerPay"
        Me.lblAvgWorkerPay.Size = New System.Drawing.Size(88, 22)
        Me.lblAvgWorkerPay.TabIndex = 7
        Me.lblAvgWorkerPay.Text = "$88888.88"
        Me.lblAvgWorkerPay.TextAlign = System.Drawing.ContentAlignment.BottomRight
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
    Friend WithEvents lblTotalWorkersLabel As Label
    Friend WithEvents lblTotalPaidLabel As Label
    Friend WithEvents lblAvgWorkerPayLabel As Label
    Friend WithEvents lblTotalWorkers As Label
    Friend WithEvents lblTotalPaid As Label
    Friend WithEvents lblAvgWorkerPay As Label
    Friend WithEvents lblTotalPieces As Label
    Friend WithEvents lblSummaryHeader As Label
    Friend WithEvents btnSummaryOK As Button
End Class
