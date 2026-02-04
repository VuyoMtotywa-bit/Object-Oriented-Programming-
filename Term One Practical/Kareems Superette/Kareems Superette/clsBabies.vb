Option Explicit On
Option Strict On

'Name:Vuyo
'Surname:Mtotywa
'Date:27/02/2025
'Project:Practical Assessment 



Public Class clsBabies

    Inherits clsProducts

    Private strCategoryName As String
    Public Property _strCategoryName() As String
        Get
            Return strCategoryName
        End Get
        Set(ByVal value As String)
            strCategoryName = value
        End Set
    End Property


    'Methods*

    Public Overrides Function CalcSubTotalAmount() As Decimal

        Return decProductPrice - decVATRate


    End Function


    Public Overrides Function CalcVAT() As Decimal


        Return CalcSubTotalAmount() * decVATRate
    End Function

    Public Overrides Function CalcDiscount() As Decimal

        Return decProductPrice * decDiscountRate / 100 * intProductQuantity
    End Function

    Public Overrides Function CalcFinalAmount() As Decimal
        Dim decAmountAfterDiscount As Decimal = CalcSubTotalAmount() - CalcDiscount()
        Dim decVATAmount As Decimal = CalcVAT()
        Return decProductPrice * decDiscountRate / 100
    End Function
End Class
