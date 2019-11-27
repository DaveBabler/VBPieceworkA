Public Class Employee
    Inherits Factory
    Implements IIncrementLogic, IEarningsByPiece
    'The employee class contains the data structure that holds information about the Employee, and the amount of work they have done.
    ' Do not forget to check the constructor function on the main form to see if it is the same person
    Private strEmployeeName As String
    Private intNumPiecesCompleted As Integer
    Private intIncrementValue As Integer
    Private decTotalEarningForEntry As Decimal


    Sub New()

    End Sub
    Public Property EmpName() As String
        Get

            Return strEmployeeName
        End Get
        Set(ByVal value As String)
            Try
                If String.IsNullOrEmpty(value) Then
                    Throw New Exception
                End If
            Catch ex As Exception
                GlobalClass.UserErrorMessage("You must enter a name to proceed.", "Comply.")
                frmPiecework_C.ClearAndFocus("Name")
            End Try
            strEmployeeName = value
        End Set
    End Property

    Public Property PiecesCompleted() As Integer
        Get
            Return intNumPiecesCompleted

        End Get
        Set(value As Integer)
            Dim intTester As Integer 'for holing test values

            'Dim modTester As Integer 'used in modulus 


            Try
                If String.IsNullOrEmpty(value) Then
                    Throw New ArgumentNullException

                ElseIf Integer.TryParse(value, intTester) = False Then
                    Throw New FormatException
                ElseIf CInt(value) = 0 Then
                    Throw New DivideByZeroException




                Else
                    intNumPiecesCompleted = value

                End If
            Catch appEx As ApplicationException
                GlobalClass.UserErrorMessage("If you're seeing this, you likely tried to enter in a partial piece.  Whole numbers only (no decimals, no fractions)!",
                                                 "Seriously, what are you doing?")
                frmPiecework_C.ClearAndFocus("Number")
            Catch Exception As DivideByZeroException
                MsgBox("If You're seeing this it is likely because: " _
                     & Environment.NewLine _
                     & Space(5) & "1." & Space(2) & "You likely entered in a Partial Piece" _
                     & Environment.NewLine & Convert.ToChar(Keys.Tab) & "Solution: use a whole number." _
                     & Environment.NewLine _
                     & Space(5) & "2." & Space(2) & "You entered in a 0 value, are you trying to create a black hole?" _
                     & Environment.NewLine & Convert.ToChar(Keys.Tab) & "Solution: use a whole number, NOT ZERO.")

                frmPiecework_C.ClearAndFocus("Number")


            Catch Exception As ArgumentNullException
                MsgBox("I'm afraid you must actually enter a value, if you want information!")
                frmPiecework_C.ClearAndFocus("Number")
            Catch ex As Exception
                GlobalClass.UserErrorMessage("Generic Message", "Wrong things!")




            End Try
            decTotalEarningForEntry = CalculateEarnings(Me.intNumPiecesCompleted)
            'intNumPiecesCompleted = value
            ''accumulation goes here

        End Set
    End Property

    Public ReadOnly Property EarningsForEntry() As Decimal
        Get
            Return decTotalEarningForEntry
        End Get

    End Property

    Public Overridable Function WorkerIncrement() As Integer Implements IIncrementLogic.WorkerIncrement
        'This is to let us know that the employee is not the same person as the employee that just used the form. 
        'This is for error checking with regards to the aforemention business logic, along with increasing a loop counter
        'for calculating averages.
        Return 1
    End Function


    Private Function CalculateEarnings(ByVal intIncomingNumPieces As Integer) As Decimal Implements IEarningsByPiece.CalculateEarnings
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


End Class


' below is a link to a page that might be helpful with setting static properties and trying to find a way to override.
' unfortunately it is from .net's online documentation which is horrifically boring to the point of being in accessable to people with ADHD
' https://docs.microsoft.com/en-us/dotnet/api/system.reflection.propertyinfo.setvalue?view=netframework-4.8