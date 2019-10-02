' Program:  Piecework A
' Author:   Dave Babler
' Date:     2019-09-28
' Purpose: Calculates and accumulates values entered in by workers.  Values are calculated 
'           based on the number of pieces done on a scale.
'Colors used:   #ff00cc|rgb(255, 0, 204)  ~  #5a0048|rgb(90, 0, 72) (Darker shade ff0cc)
'               #00ccff|rgb(90, 0, 72)
'               #ccff00|rgb(204, 255, 0)
'               End split complementary color scheme
'               Standard Windows colors: Black, Gainsboro
'

Option Strict On

Public Class frmPiecework_A
    Protected intWorkerCount As Integer = 0 'will be used to tabulate the total number of people
    Protected intPieceCountAccumulation As Integer = 0 'this is an accumulation of all pieces done
    Protected dblEarningsAccumulation As Double = 0 'accumulation of all worker's earnings.  Keeping this as double due to the case statment.
    Protected strLastWorkerName As String = ""

    Protected Sub ClearAndFocus(strTypeOfClear As String)
        'This sub clears the forms and focuses back to the correct line
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
                txtNumberOfPieces.Clear()
                txtName.Clear()
                txtName.Focus()
                btnSummary.Enabled = False
        End Select

    End Sub
    Protected Function CalculateEarnings(ByRef intIncomingNumPieces As Integer) As Double
        ' Calculates the earnings based on the number of pieces and returns that value
        ' Warning, for some reason Visual Basic absolutely will not tolerate Decimal in Case Statments!
        Dim decEarningsOut As Double
        Select Case intIncomingNumPieces
            Case Is <= 199
                decEarningsOut = 0.5
            Case 200 To 399
                decEarningsOut = 0.55
            Case 400 To 599
                decEarningsOut = 0.6
            Case >= 600
                decEarningsOut = 0.65
        End Select
        Return decEarningsOut
    End Function

    Protected Sub CalculateSummary()

    End Sub
    Protected Function CheckWorker(ByVal strIncWorkerName As String) As Integer
        'If the stored user name matches the same name entered it asks the user
        'if they are the same person, if they are it returns a 1 or a 0 for tabulating the number 
        'of users! This allows us to get actual averages
        'at the end it sets the current worker as the stored worker for later comparison 
        Dim msgNameResponse As MsgBoxResult

        Dim intSameUser As Integer = 0
        If txtName.Text <> strIncWorkerName Then
            intSameUser = 1

        Else
            msgNameResponse = MsgBox("It appears that the same name from the last user is still in the user box, are you the same person?", MsgBoxStyle.YesNo Or MsgBoxStyle.Exclamation, "Same User")
            If msgNameResponse = vbNo Then
                intSameUser = 1
            Else intSameUser = 0

            End If

        End If
        'Set the class variable
        strLastWorkerName = txtName.Text
        Return intSameUser
    End Function

    Private Sub FrmPiecework_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form terminate program
        Close()
    End Sub


    Private Sub BtnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intPiecesEntered As Integer
        Dim intUserIncrement As Integer 'will be zero or 1 depending on a function call
        Dim exDecimalError As Decimal  'using ex instaed of dec as I'm using this for error checking! 
        Dim dblAmountEarned As Double
        Dim strCurrentName As String = txtName.Text 'store the user name temporarily 


        If String.IsNullOrEmpty(txtName.Text) Then
            MsgBox("You must enter a name to proceed")
            ClearAndFocus("Name")
        Else
            If Integer.TryParse(txtNumberOfPieces.Text, intPiecesEntered) Then
                Try

                    dblAmountEarned = CalculateEarnings(intPiecesEntered)
                    lblEarnedAmountOutput.Text = dblAmountEarned.ToString("C")
                    lblEarnedAmountOutput.Visible = True
                    intUserIncrement = CheckWorker(strCurrentName)
                    intWorkerCount += intWorkerCount + intUserIncrement
                    intPieceCountAccumulation += intPieceCountAccumulation + intPiecesEntered
                    dblEarningsAccumulation += dblEarningsAccumulation + dblAmountEarned

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



    End Sub

    Private Sub BtnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim dblAveragePayPerPerson As Double
    End Sub
End Class
