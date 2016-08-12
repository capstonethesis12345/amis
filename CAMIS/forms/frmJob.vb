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





    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            txtSalary.Text = Double.Parse(txtSalary.Text)
            SqlRefresh = "select * from `job`"
            itemNew("`job`", {"`JobDescription`", "`Salary`"}, {txtDescription, txtSalary}, ListView1)
        Catch ex As Exception
            If txtSalary.Text = vbNullString Then
                txtSalary.WaterMark = "!"
                txtSalary.WaterMarkColor = Color.Red
            End If
            If txtDescription.Text = vbNullString Then
                txtDescription.WaterMark = "!Description"
                txtDescription.WaterMarkColor = Color.Red
            End If
        End Try

    End Sub

    Private Sub btnClose_Click_1(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub frmJob_Leave(sender As Object, e As EventArgs) Handles Me.Leave
        Me.Close()
    End Sub

End Class