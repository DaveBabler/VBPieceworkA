﻿Public Class Employee
    'The employee class contains the data structure that holds information about the Employee, and the amount of work they have done.
    ' Do not forget to check the constructor function on the main form to see if it is the same person
    Private _strEmployeeName As String
    Private _intNumPiecesCompleted As Integer
    Sub New()

    End Sub
    Public Property EmpName() As String
        Get

            Return _strEmployeeName
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
            _strEmployeeName = value
        End Set
    End Property

    Public Property PiecesCompleted() As Integer
        Get
            Return _intNumPiecesCompleted

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
                    _intNumPiecesCompleted = value

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
            '_intNumPiecesCompleted = value
        End Set
    End Property



End Class
