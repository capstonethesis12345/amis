Public Class frmDTR
    Dim sRefresh As String = "select dtrid,empid,datetimein,datetimeout from jobdtr"
    Private Sub frmDTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SqlRefresh = sRefresh
        SqlReFill("jobdtr", ListView1)
    End Sub

    Private Sub MetroTextButton1_Click(sender As Object, e As EventArgs) Handles MetroTextButton1.Click

    End Sub

    Private Sub txtDateTime_ValueChanged(sender As Object, e As EventArgs) Handles txtDateTime.ValueChanged

    End Sub
End Class