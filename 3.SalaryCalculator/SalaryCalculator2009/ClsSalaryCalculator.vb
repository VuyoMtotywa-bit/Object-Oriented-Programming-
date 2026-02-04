'Name: Vuyo
'Surname:Mtotywa
'Project: no3
'Date: 04/02/2025


Public Class ClsSalaryCalculator
    'Decalring data members
    Private decSalary As Decimal
    Private strWorkerRank As String
    Private decIncreasePecentage As Decimal

    'Constructor Declaration

    Sub MySub()
        decSalary = 0
        strWorkerRank = ""
        decIncreasePecentage = 0
    End Sub
    Public Property _decSalary() As Decimal
        Get
            Return decSalary

        End Get
        Set(ByVal value As Decimal)
            decSalary = value


        End Set


    End Property

    Public Property _strWorkerRank() As String
        Get
            Return strWorkerRank

        End Get
        Set(ByVal value As String)
            strWorkerRank = value


        End Set


    End Property

    Public Property _decIncresePercentage() As Decimal
        Get
            Return decIncreasePecentage

        End Get
        Set(ByVal value As Decimal)
            decIncreasePecentage = value


        End Set


    End Property


    'Function
    Function CalcSalary() As Decimal
        Return (decIncreasePecentage / 100 * decSalary) + decSalary


    End Function
End Class
