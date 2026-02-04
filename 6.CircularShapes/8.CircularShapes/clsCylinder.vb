'Name:Vuyo
'Surname:Mtotywa
'Date:17/02/2025
'Project:no6


Public Class clsCylinder


    'Inheritence 
    Inherits clsCircularShapes
    Private decHeight As Decimal

    Public Property _decHeight() As Decimal
        Get
            Return decHeight
        End Get
        Set(ByVal value As Decimal)
            decHeight = value
        End Set
    End Property
    'Polymorphism
    Public Overrides Function CalcVolume() As Decimal
        Return 4 / 3 * Math.PI * Math.Pow(_decRadius, 3)

    End Function
End Class
