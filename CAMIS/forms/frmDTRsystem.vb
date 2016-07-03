Public Class frmDTRsystem
    Sub New()
        getData()
        ' This call is required by the designer.
        InitializeComponent()
        'lblTImer.Text = Date.Now.ToString("hh:mm:ss")
        ' Add any initialization after the InitializeComponent() call.
        Timer1.Start()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim isempExist As Integer = getIDFunction("select count(empid)from jobdtr where empid like @0", "isExisted", {txtEmpid.Text})
        If isempExist = 0 Then
            'MessageBox.Show("1")

            msgShow = False
            itemNew("jobdtr", {"datetimein", "empid"}, {lblTImer, txtEmpid})
            MessageBox.Show("Time-in")
        Else

            msgShow = False
            getDSData("select dtrid,datetimein,ifnull(datetimeout,0),empid from jobdtr where empid like @0 order by dtrid desc limit 0,1", "checkTime", {txtEmpid.Text})
            If (ds.Tables("checkTime").Rows(0).Item(2).ToString = "0") Then
                Dim dtrid As New TextBox
                dtrid.Text = ds.Tables("checkTime").Rows(0).Item(0).ToString
                itemUpdate("jobdtr", {"datetimeout"}, {lblTImer}, "dtrid", dtrid.Text)
                MessageBox.Show("Time-out")
            Else
                MessageBox.Show("Time-In")
                itemNew("jobdtr", {"datetimein", "empid"}, {lblTImer, txtEmpid})
            End If
            'MessageBox.Show(hasTimeId.ToString)
        End If
        Me.Dispose()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTImer.Text = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
    End Sub
End Class