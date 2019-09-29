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

    Private Sub FrmPiecework_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form terminate program
        Close()
    End Sub
    Protected Function CalculateEarnings(ByRef intIncomingNumPieces As Integer) As Double
        ' Calculates the earnings based on the number of pieces and returns that value
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
End Class
