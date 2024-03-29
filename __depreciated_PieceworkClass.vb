'''class is depreciated, being used only for grabbing old functions and subs
Option Strict On

Public Class _ORIGINAL_pieceworkData
    Protected intWorkerCount As Integer = 0 'will be used to tabulate the total number of people
    Protected intPieceCountAccumulation As Integer = 0 'this is an accumulation of all pieces done
    Protected decEarningsAccumulation As Decimal = 0 'accumulation of all worker's earnings.  Keeping this as Decimal due to the case statment.
    Protected strLastWorkerName As String = ""

    Protected Sub ClearAndFocus(ByVal strTypeOfClear As String)
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
                lblTotalNumPiecesOutput.Visible = False
                lblNumPeopleOutput.Visible = False
                lblTotalPayOutput.Visible = False
                lblAvgPayPerPersonOutput.Visible = False

                btnSummary.Enabled = False
        End Select

    End Sub
    Protected Function CalculateEarnings(ByRef intIncomingNumPieces As Integer) As Decimal
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


    Protected Function CheckWorker(ByVal strIncWorkerName As String) As Integer
        'If the stored user name matches the same name entered it asks the user
        'if they are the same person, if they are it returns a 1 or a 0 for tabulating the number 
        'of users! This allows us to get actual averages
        'at the end it sets the current worker as the stored worker for later comparison 
        Dim msgNameResponse As MsgBoxResult

        Dim intDiffUser As Integer

        If String.Equals(txtName.Text, strLastWorkerName) Then

                msgNameResponse = MsgBox("It appears that the same name from the last user is still in the user box, are you the same person?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Same User")
                If msgNameResponse = vbYes Then
                    'if the person is the same then we shan't update the person counter
                    intDiffUser = 0
                Else
                    intDiffUser = 1
                End If
            Else
            'if they don't equal they shouldn't be the same person so we increment 
            'this includes if the value before was null! Because then by default they won't equal.
            intDiffUser = 1

            End If


        'Set the class variable
        strLastWorkerName = txtName.Text
        Return intDiffUser
    End Function


    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form terminate program
        Close()
    End Sub


    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
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

                    decAmountEarned = CalculateEarnings(intPiecesEntered)
                    lblEarnedAmountOutput.Text = decAmountEarned.ToString("C")
                    lblEarnedAmountOutput.Visible = True
                    intUserIncrement = CheckWorker(strCurrentName)
                    intWorkerCount += intUserIncrement
                    intPieceCountAccumulation += +intPiecesEntered
                    decEarningsAccumulation += decAmountEarned



                    'Make the Summary button now useable
                    btnSummary.Enabled = True

                Catch Exception As DivideByZeroException
                    MsgBox("You can't actually generate a black hole by dividing by zero. Please choose whole number greater than 1")
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


    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearAndFocus("Both")
    End Sub

    Private Sub BtnPurgeData_Click(sender As Object, e As EventArgs) Handles btnPurgeData.Click
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

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        'Calculates and then displays Summary data on the sheet.
        'Does nothing to focus as it can be done at any time once data exists in the system
        Dim decAveragePayPerPerson As Decimal
        decAveragePayPerPerson = decEarningsAccumulation / intWorkerCount
        'set the values of the soon to be displayed labels

        lblTotalNumPiecesOutput.Text = intPieceCountAccumulation.ToString("N0")
        lblNumPeopleOutput.Text = intWorkerCount.ToString("N0")
        lblTotalPayOutput.Text = decEarningsAccumulation.ToString("C")
        lblAvgPayPerPersonOutput.Text = decAveragePayPerPerson.ToString("C")

        'set the labels to be visible
        lblTotalNumPiecesOutput.Visible = True
        lblNumPeopleOutput.Visible = True
        lblTotalPayOutput.Visible = True
        lblAvgPayPerPersonOutput.Visible = True




    End Sub

End Class
