'Name:Vuyo
'Surname:Mtotywa
'Date:17/02/2025
'Project:no5
'Purpose:Student Competence

Public Class clsAssessment

    'Declaring Data Members

    Private strStudentNumber As String
    Private strSubject As String
    Private intAssignment As Integer
    Private intTestMark As Integer
    Private intPracticalMark As Integer
    Private intInternalMark As Integer
    Private intFormalMark As Integer
    Private strName As String


    'Constructor/Initializing
    Sub MySub()
        strStudentNumber = ""
        strName = ""
        strSubject = ""
        intAssignment = 0
        intInternalMark = 0
        intPracticalMark = 0
        intTestMark = 0


    End Sub

    'Properties
    Public Property _strStudentNumber() As String
        Get
            Return strStudentNumber
        End Get
        Set(ByVal value As String)
            strStudentNumber = value
        End Set
    End Property


    Public Property _strSubject() As String
        Get
            Return strSubject
        End Get
        Set(ByVal value As String)
            strSubject = value
        End Set
    End Property

    Public Property _intAssignmentMark() As Integer
        Get
            Return intAssignment
        End Get
        Set(ByVal value As Integer)
            intAssignment = value
        End Set
    End Property

    Public Property _intTestMark() As Integer
        Get
            Return intTestMark
        End Get
        Set(ByVal value As Integer)
            intTestMark = value
        End Set
    End Property

    Public Property _intPracticalMark() As Integer
        Get
            Return intPracticalMark
        End Get
        Set(ByVal value As Integer)
            intPracticalMark = value
        End Set
    End Property

    Public Property _intInternalMark() As Integer
        Get
            Return intInternalMark
        End Get
        Set(ByVal value As Integer)
            intInternalMark = value
        End Set
    End Property

    Public Property _intFormalMark() As Integer
        Get
            Return intFormalMark
        End Get
        Set(ByVal value As Integer)
            intFormalMark = value
        End Set
    End Property

    Public Property _strFirstName() As String
        Get
            Return strName
        End Get
        Set(ByVal value As String)
            strName = value
        End Set
    End Property

    'Method/Function
    Function CalcFinalMark() As Decimal

        Return intAssignment * 0.1 + intFormalMark * 0.1 + intPracticalMark * 0.2 + intInternalMark * 0.6

    End Function

    Function DetermineRating() As String
        Dim strRating As String
        If CalcFinalMark() < 50 Then
            strRating = "Your Marks Are Very Much Comedy"
        Else
            strRating = "Competent"

        End If
        Return strRating
    End Function
End Class
