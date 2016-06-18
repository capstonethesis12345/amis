
Imports System.Data.OleDb

Public Class frmEmpList

    Private Sub LoadEmp()
        SqlRefresh = "select empid from employees"
        SqlReFill("employees", ListView1)
    End Sub

    Private Sub frmEmpList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadEmp()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        '   frmPayroll.txtEmpID.Text = dgw.CurrentRow.Cells(0).Value
        '  frmPayroll.lblName.Text = dgw.CurrentRow.Cells(1).Value
        '   Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        '  Dim strSearch As String
        '  strSearch = InputBox("Enter Last Name :")

        ' Try
        '     strSQL = "SELECT Lastname, EmployeeID, LastName & ', ' & FirstName & ' ' & MI as Name FROM Employee WHERE LASTNAME LIKE '" & strSearch & "%'"
        ' Conn_DB()
        '    cmd = New OleDbCommand(strSQL, conn)
        '     dr = cmd.ExecuteReader(CommandBehavior.CloseConnection)

        '  dgw.Rows.Clear()
        ' Do While dr.Read = True
        '         dgw.Rows.Add(dr("EmployeeID"), dr("Name"))
        ' Loop
        '  Catch ex As Exception
        '     MsgBox(ex.Message)
        '  Finally
        '  cmd.Dispose()
        '   conn.Close()
        '  End Try
    End Sub

    Private Sub dgw_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)

    End Sub

    Private Sub dgw_CellDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        '   frmPayroll.txtEmpID.Text = dgw.CurrentRow.Cells(0).Value
        '   frmPayroll.lblName.Text = dgw.CurrentRow.Cells(1).Value
        '    Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub
End Class