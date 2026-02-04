'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:no7


Public MustInherit Class clsComputer
    Public decComputerPrice As Decimal = 28000D

    'Data Members declaration
    Private strProductNumber As String
    Private decCostPrice As Decimal
    Private strColor As String
    Private strDiskSize As String

    'Constructor
    Sub MySub()
        strProductNumber = ""
        strColor = ""
        strDiskSize = ""
        decCostPrice = 0


    End Sub
    'Properties
    Public Property _strProductNumber() As String
        Get
            Return strProductNumber
        End Get
        Set(ByVal value As String)
            strProductNumber = value
        End Set
    End Property



    Public Property _strColor() As String
        Get
            Return strColor
        End Get
        Set(ByVal value As String)
            strColor = value
        End Set
    End Property


    Public Property _strDiskSize() As String
        Get
            Return strDiskSize
        End Get
        Set(ByVal value As String)
            strDiskSize = value
        End Set
    End Property


    Public Property _decCostPrice() As String
        Get
            Return decCostPrice
        End Get
        Set(ByVal value As String)
            decCostPrice = value
        End Set
    End Property

    'Method/Function
    Overridable Function CalcMonthlyInstallment() As Decimal

        Return 0
    End Function

End Class
