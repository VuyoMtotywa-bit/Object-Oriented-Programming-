'Name:Vuyo
'Surname:Mtotywa
'Date:06/03/2025
'Project:Luxury Car (8)
Option Strict On
Option Explicit On

Public Class ClsMiniBus
    Inherits clsCarHire


    Function CalcDiscount() As Decimal

        Return (_intNoOfDays * 450) * 0.15D
    End Function
    Public Overrides Function CalcCompute() As Decimal
        Return (_intNoOfDays * 450) - CalcDiscount()

    End Function
End Class
