'Name:Vuyo
'Surname:Mtotywa
'Date:10/03/2025
'Project:#9


Public Class ClsFullTimeEmployee
    Inherits ClsEmployee
    Private decAnnualSalary As Decimal
    Public Property _decAnnualSalary() As Decimal
        Get
            Return decAnnualSalary
        End Get
        Set(ByVal value As Decimal)
            decAnnualSalary = value
        End Set
    End Property
    Public Overrides Function CalcNetSalary() As Integer

        Return _decAnnualSalary / 12
    End Function

End Class
