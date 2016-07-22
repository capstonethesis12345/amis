Public Class frmDTR
    Dim sRefresh As String = "select d.dtrid,d.empid,concat(e.namefirst, '',e.namelast),datetimein,datetimeout,dtrstatus from jobdtr d inner join employees e on d.empid=e.empid"

    Private Sub frmDTR_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblId.Text = "0"
        SqlRefresh = sRefresh
        SqlReFill("jobdtr", ListView1)
        SqlRefresh = "select namefirst from employees"
        ' SqlReFill("empfill", txtEmpN)

    End Sub

    Private Sub MetroTextButton2_Click(sender As Object, e As EventArgs) Handles MetroTextButton2.Click
        Me.Dispose()
    End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        lblId.Text = ListView1.SelectedItems(0).Text.ToString
    End Sub
    Private Sub lblId_TextChanged(sender As Object, e As EventArgs) Handles lblId.TextChanged
        ' Dim id As String = getStrData("select ")
        Dim datas As String = getStrData("select if(count(empid)>0,empid,0)empid,ifnull(datetimein,'')datetimein,ifnull(datetimeout,'')datetimeout,ifnull(dtrstatus,'')dtrstatus from jobdtr where dtrid like @0", "dtrtime", {lblId.Text})
        'MessageBox.Show(datas(0))
        'If Not datas = "0" Then
        'txtEmpID.Text = ds.Tables("dtrtime").Rows(0).Item("empid").ToString
        'MessageBox.Show(ds.Tables("dtrtime").Rows(0).Item("empid").ToString())
        txtEmpId.Text = ds.Tables("dtrtime").Rows(0).Item("empid").ToString()
        txtTimein.Text = ds.Tables("dtrtime").Rows(0).Item("datetimein").ToString()
        txtTimeOut.Text = ds.Tables("dtrtime").Rows(0).Item("datetimeout").ToString()
        If txtTimeOut.Text = "" Then
            btnTimeout.Visible = True
        Else
            btnTimeout.Visible = False
        End If
        Select Case ds.Tables("dtrtime").Rows(0).Item("dtrstatus").ToString()
            Case Is = "0"
                r1.Checked = True
                Exit Select
            Case Is = "1"
                r2.Checked = True
                Exit Select
            Case Is = "2"
                r3.Checked = True
                Exit Select
        End Select

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnTimeout.Click
        Dim dtr As New frmDTRsystem()
        dtr.txtEmpid.Text = txtEmpId.Text
        dtr.txtEmpid.ReadOnly = True
        dtr.ShowDialog()
        SqlRefresh = sRefresh
        SqlReFill("jobdtr", ListView1)
    End Sub
End Class