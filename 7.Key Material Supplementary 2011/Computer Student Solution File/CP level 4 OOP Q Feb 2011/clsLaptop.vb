'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:no7
'Purpose: Calc Monthly Installment

Public Class clsLaptop
    'Inheritence
    Inherits clsComputer

    Public Overrides Function CalcMonthlyInstallment() As Decimal
        Return decComputerPrice + 9899

    End Function


End Class
