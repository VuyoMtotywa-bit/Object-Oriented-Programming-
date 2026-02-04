


Public Class ClsCasualEmployee

    Inherits ClsEmployee
    'Data members
    Private decPayRate As Decimal
    Private intHoursWorked As Integer

    'Properties
    Public Property _decPayRate() As Decimal
        Get
            Return decPayRate
        End Get
        Set(ByVal value As Decimal)
            decPayRate = value
        End Set
    End Property

    Public Property _intHoursWorked() As Integer
        Get
            Return intHoursWorked
        End Get
        Set(ByVal value As Integer)
            intHoursWorked = value
        End Set
    End Property
    Public Overrides Function CalcNetSalary() As Integer

        Return _decPayRate * _intHoursWorked

    End Function


End Class
