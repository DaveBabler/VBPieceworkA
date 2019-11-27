Public Class Factory
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

    Public Sub CountWorkers(ByVal intAccumulatorVal As Integer)
        'This sub exists to add a value to the intWorkerCount worker property 
        'While it may seem like overkill to create a sub that increments a value by either
        '0 or 1 this is being done to make certain that the business logic is implemented EXACTLY without 
        'worry about so-called `magic numbers`

        Me.intWorkerCount += intAccumulatorVal
    End Sub



End Class
