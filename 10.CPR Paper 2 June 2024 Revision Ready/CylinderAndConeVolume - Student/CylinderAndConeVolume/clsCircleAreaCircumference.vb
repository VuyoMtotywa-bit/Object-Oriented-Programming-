
'Name:Vuyo
'Surname:Mtotywa
'Date:11/03/2025
'Project:no8 
Public Class clsCircleAreaCircumference
    'Declaration of Data Member

    Private decRadius As Decimal
    Private decPI As Decimal = 3.142D

    'Constructor
    Sub MySub(ByVal parRadius As Decimal)
        decRadius = parRadius


    End Sub
    'Properties

    Public Property _decRadius() As Decimal
        Get
            Return decRadius
        End Get
        Set(ByVal value As Decimal)
            If decRadius <= 0 And decRadius >= 100 Then
                Dim codeException As New ArgumentException
                Throw codeException
            Else
                decRadius = value

            End If

        End Set
    End Property


    Public ReadOnly Property _decPI() As Decimal
        Get

            Return decPI
        End Get

    End Property

    Function CalcCircleArea() As Integer

        Return decPI * Math.Pow(_decRadius, 2)


    End Function

    Function CalcCircleCurcumference() As Integer

        Return 2 * decPI * _decRadius
    End Function
End Class
