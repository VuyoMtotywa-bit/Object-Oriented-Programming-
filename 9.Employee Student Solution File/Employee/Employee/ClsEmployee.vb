Option Strict On
Option Explicit On

'Name:Vuyo
'Surname:Mtotywa
'Date:10/03/2025
'Project:#9



Public MustInherit Class ClsEmployee


    'Declaration of Data Members
    Private strEmployeeNo As String
    Private strEmployeeName As String
    Private strEmployeeSurname As String

    'Properties
    Public Property _strEmployeeNO() As String
        Get
            Return strEmployeeNo
        End Get
        Set(ByVal value As String)
            strEmployeeNo = value
        End Set
    End Property

    Public Property _strEmployeeName() As String
        Get
            Return strEmployeeName
        End Get
        Set(ByVal value As String)
            strEmployeeName = value
        End Set
    End Property


    Public Property _strEmployeeSurname() As String
        Get
            Return strEmployeeSurname
        End Get
        Set(ByVal value As String)
            strEmployeeSurname = value
        End Set
    End Property


    'Methods

    Public Overridable Function CalcNetSalary() As Integer

        Return 0
    End Function


End Class
