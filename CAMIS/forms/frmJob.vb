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




    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim n As New TextBox
        n.Text = vbNullString
        SqlRefresh = "select * from `job`"
        itemNew("`job`", {"`JobGradeID`", "`JobDescription`", "`Salary`"}, {n, txtDescription, txtSalary}, ListView1)
    End Sub
End Class