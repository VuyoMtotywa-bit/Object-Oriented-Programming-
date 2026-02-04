'Name: Vuyo 
'Surname: Mtotywa
'Date: 13/02/2025
'Project : No4
'Purpose: Calculate Cylinder Volume


Public Class clsCylinderVolume
    Private dblRadius As Double
    Private dblHeight As Double

    'Constructor
    Sub MySub()
        dblRadius = 0
        dblHeight = 0

    End Sub

    'Properties
    Public Property _dblRadius() As Double
        Get
            Return dblRadius
        End Get
        Set(ByVal value As Double)
            dblRadius = value
        End Set
    End Property
    Public Property _dblHeight() As Double
        Get
            Return _dblHeight
        End Get
        Set(ByVal value As Double)
            dblHeight = value
        End Set
    End Property


    'Function
    Function CylinderVolume() As Decimal
        Return Math.PI * Math.Pow(dblRadius, 2) * dblHeight
    End Function

End Class
