Public Class Factory
    Implements IIntegerAccumulation
    'Upon program load a new instance of the factory class will be created
    'a Factory HAS many Employees that do work.
    'some of those Employees do two or more batches of work in the same day
    'This class is wholly responsible for dealing with the accumulation 
    'This class = Parent it will create one of itself
    'Employee is a child and SameEmployee is a grandchild
    Protected intWorkerCount As Integer = 0 'will be used to tabulate the total number of people it will be based on logic if the person is the same or not
    Protected intPieceCountAccumulation As Integer = 0 'this is an accumulation of all pieces done
    Protected decEarningsAccumulation As Decimal = 0 'accumulation of all worker's earnings.  Keeping this as Decimal due to the case statment.
    Protected decAveragePayPerPerson As Decimal
    Private strFactoryName As String

    Public Sub New()
        Me.strFactoryName = "TEST FACTORY" 'logic to get the name will implement later
    End Sub



    Public ReadOnly Property TotalWorkers()
        Get
            Return intWorkerCount
        End Get
    End Property
    Public ReadOnly Property TotalPiecesComplete()
        Get
            Return intPieceCountAccumulation
        End Get
    End Property
    Public ReadOnly Property TotalEarnings()
        Get
            Return decEarningsAccumulation
        End Get
    End Property
    Public ReadOnly Property AverageWorkerPay()
        Get
            Return decAveragePayPerPerson
        End Get
    End Property
    'A note on these subs they  exist to keep the business logic isolated 
    'and to allow updates of the class properties. 
    'Some of them may seem like overkill, Example: to add a value to the intWorkerCount worker property 
    'While it may seem like overkill to create a sub that increments a value by either
    '0 or 1 this is being done to make certain that the business logic is implemented EXACTLY without 
    'worry about so-called `magic numbers`
    Public Sub CountWorkers(ByVal intAccumulatorVal As Integer) Implements IIntegerAccumulation.IntAccumulateTotal
        'increments the accumulator based on wether or not the person using the program
        'is a different worker from the last person to use it
        Me.intWorkerCount += intAccumulatorVal
    End Sub

    Public Sub PieceAccumulator(ByVal intPiecesCompletedByEmp As Integer)
        'builds the accumulation totals of the PieceAccumulator
        Me.intPieceCountAccumulation += intPiecesCompletedByEmp
    End Sub

    Public Sub TotalEarningsForPeriod(ByVal decEarningsForEmployee As Decimal)
        Me.decEarningsAccumulation += decEarningsForEmployee
    End Sub

    Public Sub CalculateAverageEmployeePay(ByVal decTotalEarnings As Decimal, intTotalEmployees As Integer)
        Dim decEmployees As Decimal
        Dim decAvgPay As Decimal
        Decimal.TryParse(intTotalEmployees, decEmployees)
        decAvgPay = (decTotalEarnings / intTotalEmployees)
        Me.decAveragePayPerPerson = Math.Round(decAvgPay, 2)



    End Sub

    Public Sub ResetFactoryValues()
        'Sub resets the values stored for the factory and is part of of the
        Me.intWorkerCount = 0
        Me.intPieceCountAccumulation = 0
        Me.decEarningsAccumulation = 0
        Me.decAveragePayPerPerson = 0

    End Sub

    Public Sub Dispose()
        'Dispose calls the default destructor but in a public setting so we can free up memory and stuff
        'WARNING! do not use this for clearing values as the class will not be generated upon exit.  Use this on form close!
        Me.Finalize()
    End Sub

End Class
