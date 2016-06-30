Public Class frmDTR
    Dim sRefresh As String = "select d.dtrid,d.empid,concat(e.namefirst, '',e.namelast),datetimein,datetimeout from jobdtr d inner join employees e on d.empid=e.empid"
    Private Sub frmDTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlRefresh = sRefresh
        SqlReFill("jobdtr", ListView1)
        SqlRefresh = "select namefirst from employees"
        SqlReFill("empfill", txtEmpNum)
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click

    End Sub

    Private Sub txtDateTime_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTime.ValueChanged

    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        Me.Dispose()
    End Sub
End Class