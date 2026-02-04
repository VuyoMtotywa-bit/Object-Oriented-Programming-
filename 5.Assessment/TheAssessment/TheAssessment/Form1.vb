'Name:Vuyo
'Surname:Mtotywa
'Date:17/02/2025
'Project:no5





Public Class Form1
    Private Sub btnProgress_Click(sender As Object, e As EventArgs) Handles btnProgress.Click
        'Instantiation
        Dim objAssessment As New clsAssessment
        'Initialization
        objAssessment._strStudentNumber = txtStudentNo.Text
        objAssessment._strFirstName = txtName.Text
        objAssessment._strSubject = cboSubject.Text
        objAssessment._intAssignmentMark = CInt(txtAssignment.Text)
        objAssessment._intFormalMark = CInt(txtFormalTest.Text)
        objAssessment._intPracticalMark = CInt(txtPractical.Text)
        objAssessment._intInternalMark = CInt(txtInternalCollegeExam.Text)

        'Invoke/Calling
        lblName.Text = objAssessment._strFirstName.ToString()
        lblStudentNo.Text = objAssessment._strStudentNumber.ToString()
        lblSubject.Text = objAssessment._strSubject.ToString()
        lblFinalMark.Text = objAssessment.CalcFinalMark().ToString("N2")
        lblRating.Text = objAssessment.DetermineRating().ToString()



    End Sub
End Class
