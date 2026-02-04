Option Explicit On
Option Strict On

'Name:Vuyo
'Surname:Mtotywa
'Date:26/02/2025
'Project:Practical Assessment 


Public MustInherit Class clsProducts
    'Declaration of Data Members
    Private strCustomerName As String
    Private strCustomerSurname As String
    Private strProductName As String
    Public decProductPrice As Decimal
    Public intProductQuantity As Integer

    Public decSubTotal As Decimal
    Public decDiscountRate As Decimal = 35D
    Public decFinalAmount As Decimal
    Public decVat As Decimal = 0.15D
    Public decVATRate As Decimal = 0.15D
    Public decAmountAfterDiscount As Decimal = 0.35D
    Public decVATAmount As Decimal





    Sub MySub()
        'Available Constructors
        strCustomerName = ""
        strCustomerSurname = ""
        strProductName = ""
        decProductPrice = 0

        decSubTotal = 0
        decVATRate = 0.15D
    End Sub
    'Properties
    Public Property _strCustomerName() As String
        Get
            Return strCustomerName
        End Get
        Set(ByVal value As String)
            strCustomerName = value
        End Set
    End Property

    Public Property _strCustomerSurname() As String
        Get
            Return strCustomerName
        End Get
        Set(ByVal value As String)
            strCustomerName = value
        End Set
    End Property

    Public Property _strProductName() As String
        Get
            Return strProductName
        End Get
        Set(ByVal value As String)
            strCustomerName = value
        End Set
    End Property

    Public Property _decProductPrice() As Decimal
        Get
            Return decProductPrice
        End Get
        Set(ByVal value As Decimal)
            decProductPrice = value
        End Set
    End Property

    Public Property _intProductQuantity() As Integer
        Get
            Return intProductQuantity
        End Get
        Set(ByVal value As Integer)
            intProductQuantity = value
        End Set
    End Property

    'Method/Funtion
    Public Overridable Function CalcSubTotalAmount() As Decimal

        Return decProductPrice * intProductQuantity
    End Function

    Public Overridable Function CalcDiscount() As Decimal

        Return decProductPrice * decDiscountRate / 100 * intProductQuantity
    End Function

    Public Overridable Function CalcVAT() As Decimal

        Return decSubTotal * decVATRate
    End Function

    Public Overridable Function CalcFinalAmount() As Decimal
        Dim decAmountAfterDiscount As Decimal = CalcSubTotalAmount() - CalcDiscount()
        Dim decVATAmount As Decimal = CalcVAT()
        Return decAmountAfterDiscount + decVATAmount
    End Function


End Class
