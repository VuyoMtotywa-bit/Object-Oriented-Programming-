Option Strict On
Option Explicit On

Public Class clsPrivateCar

    Inherits clsCarHire

    Public Overrides Function CalcCompute() As Decimal
        Return _intNoOfDays * 250
    End Function

End Class
