'Name:Vuyo
'Surname:Mtotywa
'Date:17/02/2025
'Project:no6


Public Class clsCone

    'Inheritence 
    Inherits clsCircularShapes
    'Data Member
    Private decHeight As Decimal


    'Property
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
        Return Math.PI * Math.Pow(_decRadius, 2) * decHeight / 3


    End Function

End Class
