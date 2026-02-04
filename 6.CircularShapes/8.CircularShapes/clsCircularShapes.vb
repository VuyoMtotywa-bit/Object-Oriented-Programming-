'Name:Vuyo
'Surname:Mtotywa
'Date:17/02/2025
'Project:no6
'Purpose:Calculating the Volumes of Circular Shapes

Public MustInherit Class clsCircularShapes
    'Declare Data Members

    Private decRadius As Decimal
    Sub MySub()
        decRadius = 0

    End Sub
    'Property
    Public Property _decRadius() As Decimal
        Get
            Return decRadius
        End Get
        Set(ByVal value As Decimal)
            decRadius = value
        End Set
    End Property

    'Method/Function
    Public Overridable Function CalcVolume() As Decimal

        Return 0
    End Function

End Class
