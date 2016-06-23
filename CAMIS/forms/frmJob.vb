Public Class frmJob
    Dim fill As String = "select jobgradeid,jobdescription,salary from job"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = fill
        SqlReFill("jobs", ListView1)
        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click
        Dim id As New TextBox

        If txtID.Text = vbNullString Then
            id.Text = "Null"
            SqlRefresh = fill
            itemNew("job", {"jobgradeid", "JobDescription", "Salary"}, {id, txtDescription, txtSalary})
        Else
            SqlRefresh = fill
            itemUpdate("job", {"JobDescription", "Salary"}, {txtDescription, txtSalary}, "JobGradeid", txtID.Text, ListView1)
        End If

    End Sub

    Private Sub MetroTextButton1_Leave(sender As Object, e As EventArgs) Handles MetroTextButton1.Leave
        Me.Dispose()
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Hide()
    End Sub
End Class