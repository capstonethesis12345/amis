Public Class frmDTRsystem
    Sub New()
        getData()
        ' This call is required by the designer.
        InitializeComponent()
        'lblTImer.Text = Date.Now.ToString("hh:mm:ss")
        ' Add any initialization after the InitializeComponent() call.
        Timer1.Start()
        lblStatus.Text = ""
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim nowDate As New TextBox
        nowDate.Text = Date.Now.ToString("yyyy-MM-dd H:mm:ss")
        If txtEmpid.Text = vbNullString Then
            lblStatus.Text = "*Employee ID required"
            Timer2.Start()
            Exit Sub
        End If

        'check if loged in
        'if not insert new 
        'if already logged in logout

        Dim isempExist As Integer = getIDFunction("SELECT last_insert_id(dtrid),datetimein,datetimeout FROM jobdtr j where empid like @0 order by dtrid desc limit 0,1", "dtrLoging", {txtEmpid.Text})
        If ds.Tables.Count > 0 Then
            If ds.Tables("dtrLoging").Rows(0).Item(2).ToString = vbNullString Then

                If MessageBox.Show("You are about to time-out?", "Time-out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    itemUpdate("jobdtr", {"datetimeout"}, {nowDate}, "dtrid", isempExist.ToString)

                    Me.Dispose()
                End If
            Else
                If MessageBox.Show("You are about to time-in?", "Time-in", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    itemNew("jobdtr", {"datetimein", "empid"}, {nowDate, txtEmpid})

                    Me.Dispose()
                End If
                'insert to timein
            End If
        End If
        'If isempExist = 0 Then
        '    'MessageBox.Show("1")

        '    msgShow = False
        '    If MessageBox.Show("You are about to time-in?", "Time-in", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '        itemNew("jobdtr", {"datetimein", "empid"}, {nowDate, txtEmpid})

        '        Me.Dispose()
        '    End If
        'Else

        '    msgShow = False
        '    getDSData("select dtrid,datetimein,ifnull(datetimeout,0),empid from jobdtr where empid like @0 order by dtrid desc limit 0,1", "checkTime", {txtEmpid.Text})
        '    If (ds.Tables("checkTime").Rows(0).Item(2).ToString = "0") Then
        '        Dim dtrid As New TextBox
        '        dtrid.Text = ds.Tables("checkTime").Rows(0).Item(0).ToString
        '        If MessageBox.Show("You are about to time-out?", "Time-out", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '            itemUpdate("jobdtr", {"datetimeout"}, {nowDate}, "dtrid", dtrid.Text)

        '            Me.Dispose()
        '        End If
        '        'MessageBox.Show("Time-out")
        '    Else
        '        '       MessageBox.Show("Time-In")
        '        If MessageBox.Show("You are about to time-in?", "Time-in", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
        '            itemNew("jobdtr", {"datetimein", "empid"}, {nowDate, txtEmpid})

        '            Me.Dispose()
        '        End If
        '    End If
        '    'MessageBox.Show(hasTimeId.ToString)
        'End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblTImer.Text = Date.Now.ToString("yyyy-MM-dd hh:mm:ss")
    End Sub

    Private Sub frmDTRsystem_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        lblStatus.Visible = False
        Timer2.Stop()
    End Sub
End Class