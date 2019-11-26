' Program:  Piecework A
' Author:   Dave Babler
' Date:     2019-09-28
' Purpose: Calculates and accumulates values entered in by workers.  Values are calculated 
'           based on the number of pieces done on a scale.
'Colors used:   #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc)
'               #00ccff|rgb(0, 204, 255)
'               #ccff00|rgb(204, 255, 0)
'               End split complementary color scheme
'               Standard Windows colors: Black, Gainsboro
'
'Tab stop note.  FOR SAFTEY Clear All and Exit have been removed from tabstops.
Option Strict On

Public Class frmPiecework_C
    Protected intWorkerCount As Integer = 0 'will be used to tabulate the total number of people
    Protected intPieceCountAccumulation As Integer = 0 'this is an accumulation of all pieces done
    Protected decEarningsAccumulation As Decimal = 0 'accumulation of all worker's earnings.  Keeping this as Decimal due to the case statment.
    Protected strLastWorkerName As String = ""
    Protected decAveragePayPerPerson As Decimal
    Protected strPreviousName As String
    Public Sub ClearAndFocus(ByVal strTypeOfClear As String)
        'This sub clears the forms and focuses back to the correct line
        'WARNING: "Total" purges stored variable data and hides outputs.
        Select Case strTypeOfClear
            Case "Number"
                txtNumberOfPieces.Clear()
                txtNumberOfPieces.Focus()
            Case "Name"
                txtName.Clear()
                txtName.Focus()
            Case "Both"
                'defaults to name since that comes first, but clears both fields
                txtNumberOfPieces.Clear()
                txtName.Clear()
                txtName.Focus()
            Case "Total"
                'Complete purge of data
                '
                '
                'In my 2 years of programming professionally (mostly with Programmatic SQL PHP and C# 
                'This is the first time I've been brave enough to try recursion!!!
                ClearAndFocus("Both")
                '
                lblEarnedAmountOutput.Text = ""
                lblEarnedAmountOutput.Visible = False
                intWorkerCount = 0
                intPieceCountAccumulation = 0
                decEarningsAccumulation = 0
                strLastWorkerName = ""
                mnuFileSummary.Enabled = False
        End Select

    End Sub


    ''depreciated sub, saved incase customer changes mind
    Private Sub ResultsBox(ByVal intPieceTotal As Integer, ByVal intPeople As Integer, ByVal decTotalPay As Decimal, ByVal decAveragePay As Decimal)
        'This procedure compiles and displays a nicely formatted Message Box with information about 
        ' the cumulative stats of pieces done, amount of workers, total paid, and average paid per worker.
        ' hard spaces and vbTab stops are used for formatting
        ''depreciated!!!!

        Dim strNumPieces As String = "The number of pieces completed is: "
        Dim strNumWokers As String = "The number of workers contributing is: "
        Dim strTotalPay As String = "The total amount paid to the workers is: "
        Dim strAveragePay As String = "The average pay per worker is: "
        Dim strMessageBoxHeading As String = "Accumulation Totals"
        MsgBox(strNumPieces & vbTab & vbTab & "  " & intPieceTotal.ToString("N0") & vbCr &
                strNumWokers & vbTab & "  " & intPeople.ToString("N0") & vbCr &
                strTotalPay & vbTab & decTotalPay.ToString("C") & vbCr &
                strAveragePay & vbTab & vbTab & decAveragePay.ToString("C") & vbCr, MsgBoxStyle.Information, strMessageBoxHeading)
    End Sub

    Protected Function CalculateEarnings(ByVal intIncomingNumPieces As Integer) As Decimal
        ' Calculates the earnings based on the number of pieces and returns that value
        ' Warning, for some reason Visual Basic absolutely will not tolerate Decimal in Case Statments!
        Dim decRate As Decimal
        Dim decEarningsOut As Decimal

        Select Case intIncomingNumPieces
            Case Is <= 199
                decRate = CDec(0.5)
            Case 200 To 399
                decRate = CDec(0.55)
            Case 400 To 599
                decRate = CDec(0.6)
            Case >= 600
                decRate = CDec(0.65)
        End Select
        decEarningsOut = decRate * intIncomingNumPieces

        Return decEarningsOut

    End Function

    Protected Function CalculateAverage(ByVal decTotalAccumulation As Decimal, ByVal decAmountOfContributors As Decimal) As Decimal
        'This is a generic Average calculator and is mostly here because Dave already made a function for the previous part of the assignment
        Dim decAverageOut = decTotalAccumulation / decAmountOfContributors
        Return decAverageOut

    End Function


    Private Sub SummaryFontChanger(ByRef lblToChange As Label)
        Dim strOriginalFontName As String = lblToChange.Font.Name.ToString()
        'Changes the font of the specifified label based on it's current font
        If strOriginalFontName = "Microsoft Sans Serif" Then
            lblToChange.Font = New Font("Rockwell", 11.25, Font.Style.Bold)
        Else lblToChange.Font = New Font("Microsoft Sans Serif", 12, Font.Style.Regular)

        End If

    End Sub
    Private Sub SummaryFontColorChanger(ByRef lblToChange As Label)
        Const strDEFAULTCOLOR As String = "[A=255, R=204, G=255, B=0]"
        Const strALTCOLOR As String = "[A=255, R=90, G=0, B=72]"
        Dim clrDeepPink As Color = Color.FromArgb(90, 0, 72)
        Dim clrNeonGreen As Color = Color.FromArgb(204, 255, 0)
        Dim clrHotBlue As Color = Color.FromArgb(0, 204, 255)
        Dim intIsColorInStr As Integer
        'Changes the font color of the specified label based on the original input color
        Dim strColorName = lblToChange.ForeColor.ToString()
        'Find out if the constant color (the original color on the form) is in the string

        If (InStr(strColorName, strDEFAULTCOLOR)) > 0 Then
            lblToChange.ForeColor = clrDeepPink
        ElseIf (InStr(strColorName, strALTCOLOR)) > 0 Then
            lblToChange.ForeColor = clrHotBlue
        Else lblToChange.ForeColor = clrNeonGreen
        End If

    End Sub



    Private Sub SummaryToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileSummary.Click
        'Calculates and then displays Summary data on the in a MessageBox.
        'Does nothing to focus as it can be done at any time once data exists in the system

        decAveragePayPerPerson = CalculateAverage(decEarningsAccumulation, intWorkerCount)


        'set the values of the soon to be displayed labels

        frmCalculationOutput.lblTotalNumPiecesOutput.Text = intPieceCountAccumulation.ToString("N0")
        frmCalculationOutput.lblNumPeopleOutput.Text = intWorkerCount.ToString("N0")
        frmCalculationOutput.lblTotalPayOutput.Text = decEarningsAccumulation.ToString("C")
        frmCalculationOutput.lblAvgPayPerPersonOutput.Text = decAveragePayPerPerson.ToString("C")

        'set the labels to be visible
        frmCalculationOutput.lblTotalNumPiecesOutput.Visible = True
        frmCalculationOutput.lblNumPeopleOutput.Visible = True
        frmCalculationOutput.lblTotalPayOutput.Visible = True
        frmCalculationOutput.lblAvgPayPerPersonOutput.Visible = True
        ' If we want the form to show as a modal must use ShowDialog and not Show
        ' This also means we cannot populate the form UNTIL the data is loaded
        frmCalculationOutput.ShowDialog()
    End Sub

    Private Sub CalculatePayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFileCalculate.Click
        Dim intPiecesEntered As Integer
        Dim intUserIncrement As Integer 'will be zero or 1 depending on a function call
        Dim exDecimalError As Decimal  'using ex instaed of dec as I'm using this for error checking! 
        Dim decAmountEarned As Decimal
        Dim strCurrentName As String = txtName.Text 'store the user name temporarily 


        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("You must enter a name to proceed")
            ClearAndFocus("Name")
        Else
            If Integer.TryParse(txtNumberOfPieces.Text, intPiecesEntered) Then
                Try
                    If intPiecesEntered = 0 Then
                        Throw New DivideByZeroException
                    Else
                        decAmountEarned = CalculateEarnings(intPiecesEntered)
                        lblEarnedAmountOutput.Text = decAmountEarned.ToString("C")
                        lblEarnedAmountOutput.Visible = True
                        intUserIncrement = GlobalClass.CheckWorkerInt(strCurrentName, strLastWorkerName)
                        intWorkerCount += intUserIncrement
                        intPieceCountAccumulation += +intPiecesEntered
                        decEarningsAccumulation += decAmountEarned



                        'Make the Summary button now useable
                        mnuFileSummary.Enabled = True
                    End If
                Catch Exception As DivideByZeroException
                    MsgBox("You can't actually generate a black hole by dividing by zero. Please choose a whole number greater than 1" _
                           & Environment.NewLine _
                           & "Why are you trying to generate a black hole anyway? That Seems dangerous." _
                                                      & Environment.NewLine _
                           & "Again, use a number larger than 1 (one)")
                    ClearAndFocus("Number")
                Catch Exception As FormatException

                    MsgBox("You have entered something that is Not a whole number. Enter a whole number to procced")
                    ClearAndFocus("Number")

                Catch Exception As ArgumentNullException
                    MsgBox("I'm afraid you must actually enter a value, if you want information!")
                    ClearAndFocus("Number")
                End Try
            ElseIf Decimal.TryParse(txtNumberOfPieces.Text, exDecimalError) Then
                MsgBox("If you're seeing this, you likely tried to enter in a partial piece.  Whole numbers only (no decimals, no fractions)!")
                ClearAndFocus("Number")
            Else
                MsgBox("You have entered something that is Not a whole number. Enter a whole number to procced")
                ClearAndFocus("Number")
            End If



        End If
    End Sub

    Private Sub MnuFileExit_Click(sender As Object, e As EventArgs) Handles mnuFileExit.Click
        'Close form terminate program
        Close()
    End Sub

    Private Sub MnuEditClear_Click(sender As Object, e As EventArgs) Handles mnuEditClear.Click
        ClearAndFocus("Both")
    End Sub

    Private Sub MnuEditClearAll_Click(sender As Object, e As EventArgs) Handles mnuEditClearAll.Click
        'this is for setting the program back to a default state (as if it had just been loaded into RAM
        'it gives the user warning,  that all user data is purged.
        Dim msgConfirmReset As MsgBoxResult
        msgConfirmReset = MsgBox("This will completely clear all data." & vbNewLine & "Are you sure?", MsgBoxStyle.Critical Or
               MsgBoxStyle.YesNo, "Purge Data?")
        If msgConfirmReset = vbNo Then
            txtName.Focus()
        Else
            ClearAndFocus("Total")
        End If

    End Sub


    Private Sub MnuEditFont_Click(sender As Object, e As EventArgs) Handles mnuEditFont.Click
        If dlgFontDialog.ShowDialog <> DialogResult.Cancel Then
            lblEarnedAmountLabel.Font = dlgFontDialog.Font
            lblEarnedAmountOutput.Font = dlgFontDialog.Font

        End If
    End Sub

    Private Sub MnuEditColor_Click(sender As Object, e As EventArgs) Handles mnuEditColor.Click
        If dlgColorDialog.ShowDialog <> DialogResult.Cancel Then
            lblEarnedAmountLabel.ForeColor = dlgColorDialog.Color
            lblEarnedAmountOutput.ForeColor = dlgColorDialog.Color
        End If
    End Sub

    Private Sub MnuAbout_Click(sender As Object, e As EventArgs) Handles mnuAbout.Click
        'Load aboutbox as a modal, which is why ShowDialog is used instead of Show
        frmAbout.ShowDialog()

    End Sub

    Private Sub MnuFilePrint_Click(sender As Object, e As EventArgs) Handles mnuFilePrint.Click
        'Print preview the form on the printer.
        printPieceRateForm.PrintAction = Printing.PrintAction.PrintToPreview
        'Nobody needs this tiny little screen in landscape form setting that to false   
        printPieceRateForm.PrinterSettings.DefaultPageSettings.Landscape = False
        printPieceRateForm.Print(frmCalculationOutput, PowerPacks.Printing.PrintForm.PrintOption.FullWindow)
    End Sub

    Private Sub frmPiecework_C_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
    End Sub



    Private Sub mnuFontRorationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuFontRorationToolStripMenuItem.Click
        SummaryFontChanger(lblEarnedAmountLabel)
        SummaryFontChanger(lblEarnedAmountOutput)
    End Sub

    Private Sub mnuColorRotationToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles mnuColorRotationToolStripMenuItem1.Click
        SummaryFontColorChanger(lblEarnedAmountLabel)
        SummaryFontColorChanger(lblEarnedAmountOutput)
    End Sub

    Private Sub ShowLogoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles mnuShowLogoToolStrip.Click
        If mnuShowLogoToolStrip.Checked Then
            picEmmaFrost.Visible = True
        Else
            picEmmaFrost.Visible = False
        End If


    End Sub

    Private Sub mnuShowSloganToolStrip_Click(sender As Object, e As EventArgs) Handles mnuShowSloganToolStrip.Click
        If mnuShowSloganToolStrip.Checked Then
            lblSlogan.Visible = True
        Else
            lblSlogan.Visible = False
        End If

    End Sub

    Private Sub btnTesting_Click(sender As Object, e As EventArgs) Handles btnTesting.Click

        Dim strName As String = txtName.Text
        Dim intPiecesEntered As Integer

        Dim boolDiffWorker As Boolean 'Is it a different worker or not? It ABSOLUTELY matters for proper tabulation.

        Dim decAmountEarned As Decimal





        Integer.TryParse(txtNumberOfPieces.Text, intPiecesEntered)
        Console.WriteLine("Number of pieces {0}", intPiecesEntered.ToString())
        boolDiffWorker = GlobalClass.CheckWorkerBool(strName, strPreviousName)

        Console.WriteLine("The current value of sameworker is {0}", boolDiffWorker)

        If boolDiffWorker = True Then
            Dim empEntry As New Employee
            empEntry.EmpName() = strName
            empEntry.PiecesCompleted() = intPiecesEntered
            intWorkerCount += empEntry.WorkerIncrement()
           decAmountEarned =  empEntry.EarningsForEntry()
            Console.WriteLine("WE have Name {0} and intPiecesEntered {1}", empEntry.EmpName.ToString(), empEntry.PiecesCompleted.ToString())
            Console.WriteLine(empEntry.EmpName.ToString())
            Console.WriteLine("This is the first time the employee hit enter so increase by {0}", empEntry.WorkerIncrement())
            Console.WriteLine("_______________________________________________________")
            Console.WriteLine("The earned value is {0}", empEntry.EarningsForEntry.ToString())
        Else

            Dim sameEmp As New SameEmployee
            sameEmp.EmpName() = strName
            sameEmp.PiecesCompleted = intPiecesEntered
            decAmountEarned = sameEmp.EarningsForEntry()
            intWorkerCount += sameEmp.WorkerIncrement()
            Console.WriteLine("This is the second time the employee hit enter so increase by {0}", sameEmp.WorkerIncrement())
            Console.WriteLine("The earned value is {0}", decAmountEarned)
        End If






    End Sub
End Class

