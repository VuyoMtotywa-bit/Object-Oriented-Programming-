'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:no7
'Purpose: Calc Monthly Installment



Public Class clsMainFrame

    'Inheritence
    Inherits clsComputer

    'Method
    Public Overrides Function CalcMonthlyInstallment() As Decimal
        Return decComputerPrice + 22000

    End Function
End Class
