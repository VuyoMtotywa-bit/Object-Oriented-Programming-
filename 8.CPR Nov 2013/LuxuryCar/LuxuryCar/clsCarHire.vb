'Name:Vuyo
'Surname:Mtotywa
'Date:06/03/2025
'Project:Luxury Car (8)
Option Strict On
Option Explicit On

Public MustInherit Class clsCarHire
    'Declaration of Data Members
    Private strName As String
    Private strSurname As String
    Private strContact As String
    Private intNoOfDays As Integer

    'Constructor
    Sub MySub()
        strName = ""
        strSurname = ""
        strContact = ""
        intNoOfDays = 0

    End Sub
    'Properties
    Public Property _strName() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property


    Public Property _strSurname() As String
        Get
            Return strSurname
        End Get
        Set(ByVal value As String)
            strSurname = value
        End Set
    End Property

    Public Property _strContact() As String
        Get
            Return strContact
        End Get
        Set(ByVal value As String)
            strContact = value
        End Set
    End Property

    Public Property _intNoOfDays() As Integer
        Get
            Return intNoOfDays
        End Get
        Set(ByVal value As Integer)
            intNoOfDays = value
        End Set
    End Property

    Public Overridable Function CalcCompute() As Decimal

        Return 0
    End Function
End Class