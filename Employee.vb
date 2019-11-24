Public Class Employee
    'The employee class contains the data structure that holds information about the Employee, and the amount of work they have done.
    ' Do not forget to check the constructor function on the main form to see if it is the same person
    Private _strEmployeeName As String
    Private _intNumPiecesCompleted As Integer

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
            Try
                If String.IsNullOrEmpty(value) Then
                    Throw New ArgumentNullException

                ElseIf Not Integer.TryParse(value, intTester) Then
                    Throw New FormatException

                ElseIf CInt(value) = 0 Then
                    Throw New DivideByZeroException
                ElseIf Decimal.TryParse(value, intTester) Then
                    Throw New ApplicationException

                Else
                    _intNumPiecesCompleted = value

                End If
            Catch appEx As ApplicationException
                GlobalClass.UserErrorMessage("If you're seeing this, you likely tried to enter in a partial piece.  Whole numbers only (no decimals, no fractions)!",
                                                 "Seriously, what are you doing?")
                frmPiecework_C.ClearAndFocus("Number")
            Catch Exception As DivideByZeroException
                MsgBox("You can't actually generate a black hole by dividing by zero. Please choose a whole number greater than 1" _
                       & Environment.NewLine _
                       & "Why are you trying to generate a black hole anyway? That Seems dangerous." _
                                                  & Environment.NewLine _
                       & "Again, use a number larger than 1 (one)")
                frmPiecework_C.ClearAndFocus("Number")
            Catch Exception As FormatException

                MsgBox("You have entered something that is Not a whole number. Enter a whole number to procced")
                frmPiecework_C.ClearAndFocus("Number")

            Catch Exception As ArgumentNullException
                MsgBox("I'm afraid you must actually enter a value, if you want information!")
                frmPiecework_C.ClearAndFocus("Number")
            Catch ex As Exception
                GlobalClass.UserErrorMessage("Generic Message", "Wrong things!")




            End Try
        End Set
    End Property



End Class
