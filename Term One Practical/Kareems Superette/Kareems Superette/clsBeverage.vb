Option Explicit On
Option Strict On

'Name:Vuyo
'Surname:Mtotywa
'Date:18/02/2025
'Project:Practical Assessment 



Public Class clsBeverage
    'Inheritence
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


    'Method 

    Public Overrides Function CalcSubTotalAmount() As Decimal

        Return MyBase.CalcSubTotalAmount


    End Function


    Public Overrides Function CalcVAT() As Decimal


        Return MyBase.CalcVAT
    End Function

    Public Overrides Function CalcDiscount() As Decimal

        Return MyBase.CalcDiscount
    End Function

    Public Overrides Function CalcFinalAmount() As Decimal

        Return MyBase.CalcFinalAmount
    End Function
End Class
