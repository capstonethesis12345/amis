Public Class frmExpenses
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

    End Sub
    Private Sub MetroButton1_Click(sender As Object, e As EventArgs) Handles MetroButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim rdate As DateTime = DateTime.Now
        Dim tdate As New TextBox
        tdate.Text = rdate.ToString("yyyy-MM-dd HH:mm:ss")
        If lID.Text = vbNullString Then
            itemNew("expenses", {"title", "amount", "date_created", "notes", "empid"}, {cbTitle, tbamount, tdate, rtnotes, lEmpID})
        Else
            'regDate.ToString("yyyy-MM-dd HH:mm:ss")
            itemUpdate("expenses", {"amount", "notes", "date_created"}, {tbamount, rtnotes, tdate}, "id", lID.Text)
        End If

    End Sub


    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        lID.Text = ListView1.SelectedItems(0).Text.ToString
        cbTitle.Text = ListView1.SelectedItems(0).SubItems(1).Text
        tbamount.Text = ListView1.SelectedItems(0).SubItems(2).Text
        tdate_created.Text = ListView1.SelectedItems(0).SubItems(3).Text
        rtnotes.Text = ListView1.SelectedItems(0).SubItems(4).Text

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lID.Text = ""
        tdate_created.Text = ""
        cbTitle.Text = ""
        rtnotes.Text = ""
        tbamount.Text = ""
    End Sub

    Private Sub tbamount_TextChanged(sender As Object, e As EventArgs) Handles tbamount.TextChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub Panel3_Paint(sender As Object, e As PaintEventArgs) Handles Panel3.Paint

    End Sub

    Private Sub rtnotes_TextChanged(sender As Object, e As EventArgs) Handles rtnotes.TextChanged

    End Sub

    Private Sub frmExpenses_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim c As Integer = Integer.Parse(getIDFunction("select count(expense_id) from expenses", "countExpense"))
        If c > 0 Then
            SqlRefresh = "select expense_id,title,amount,date_created,notes from expenses"
            SqlFill(SqlRefresh, ListView1)
        End If
        lEmpID.Text = vEmp
    End Sub
End Class