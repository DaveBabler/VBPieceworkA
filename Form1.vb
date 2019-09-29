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



Public Class frmPiecework_A
    Public Sub TestingLabelManipulation(ByVal SomeCrap As String, ByRef SomeLabel As Label)
        Dim strSomeDumbShit As String
        strSomeDumbShit = SomeCrap & "SomeBullshit" & " no, for real! "

        SomeLabel.Text = strSomeDumbShit
    End Sub
    Private Sub FrmPiecework_A_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Close form terminate program
        Close()
    End Sub

    Private Sub BtnPurgeData_Click(sender As Object, e As EventArgs) Handles btnPurgeData.Click
        TestingLabelManipulation("This Is some", lblBullShit)
    End Sub
End Class
