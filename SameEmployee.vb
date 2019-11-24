Public Class SameEmployee
    'This will overload the value that is set so we don't screw up our calculations
    Inherits Employee
    Public Overrides Function WorkerIncrement() As Integer

        'This is to let us know that the employee is in fact  the same person as the employee that just used the form. 
        'This is for error checking with regards to the aforemention business logic, along with NOT INCREASING a loop counter
        'for calculating averages.
        Return MyBase.WorkerIncrement() = 0
    End Function
End Class
