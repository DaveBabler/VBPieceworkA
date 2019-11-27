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
End Class
