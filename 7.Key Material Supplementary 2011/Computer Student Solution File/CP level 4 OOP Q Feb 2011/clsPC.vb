'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:no7


Public Class clsPC

    'Inheritence
    Inherits clsComputer

    Public Overrides Function CalcMonthlyInstallment() As Decimal
        Return decComputerPrice + 17590

    End Function

End Class
