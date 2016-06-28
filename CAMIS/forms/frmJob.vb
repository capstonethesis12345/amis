Public Class frmJob
    Dim fill As String = "select JobGradeID,JobDescription,Salary from `job`"
    Sub New()
        getData()
        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = fill
        SqlReFill("fillJob", ListView1)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs)
        Dim id As New TextBox

        If txtID.Text = vbNullString Then
            id.Text = "Null"
            SqlRefresh = fill
            itemNew("job", {"JobDescription", "Salary"}, {id, txtDescription, txtSalary})
        Else
            SqlRefresh = fill
            itemUpdate("job", {"JobDescription", "Salary"}, {txtDescription, txtSalary}, "JobGradeid", txtID.Text, ListView1)
        End If

    End Sub

    Private Sub MetroTextButton1_Leave(sender As Object, e As EventArgs)
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SqlRefresh = "select jobdescription, jobsalary from job"
        itemNew("job", {"jobdescription", "jobsalary"}, {txtDescription, txtSalary})
    End Sub
End Class