
Imports MySql.Data.MySqlClient


Public Class frmStaff
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e,users u where u.empid=e.empid"
            SqlReFill("employees", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection " & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try



    End Sub
    Dim textboxes As Object()

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Close()


    End Sub

    '  Private Sub btnUpdate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '      StatusSet = "Update"
    '  If ListView1.SelectedItems.Count = 0 Then
    '          MessageBox.Show("Select item first", "Selection not identified", MessageBoxButtons.OK, MessageBoxIcon.Hand)
    '  Else
    '  Dim update As New frmAddUpdateStaff()
    '         update.txtRequisitionNo.Text = ListView1.FocusedItem.Text
    '         update.ShowDialog()
    ' End If
    '  End Sub
    Private Sub ListView1_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles ListView1.MouseDoubleClick
        PictureBox1.Visible = True
        Dim obj As Object = Nothing

        textboxes = {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtAssigned, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}
        clearField(textboxes)
        Try
            txtEmployeeNo.Text = ListView1.SelectedItems(0).Text.ToString
            'StatusSet = ""
            'ErrMessageText = ""

            SqlRefresh = "SELECT  e.Empid, e.NameFirst, e.NameMiddle,e.NameLast,ifnull(e.Gender,''),ifnull(e.BirthDate,''),ifnull(e.BirthAddress,''),ifnull(e.AddressStreet,''),ifnull(e.AddressBarangay,''),ifnull(e.AddressMunCity,''),ifnull(e.AddressProvince,''),ifnull(e.AddressZip,''),ifnull(e.Contact,''),'',ifnull(u.Username,''),ifnull(e.EmploymentStatus,'')EmploymentStatus,ifnull(e.maritalstatus,'')maritalstatus,ifnull(e.EmpImage,''),ifnull(`u`.`Function`,'')role from Employees e
                            LEFT JOIN Users u
                            ON u.EmpID=e.Empid
                        where e.empid=@empid"
            msgShow = False
            SqlReFill("employees", Nothing, "ShowValueInTextbox", {"empid"}, {txtEmployeeNo}, textboxes)
            'COMMENTED CODED IS TO ACCESS MANUAL INFORMATION F DATASET TABLE.
            ' Dim mstatus As String = ds.Tables("employees").Rows(0).Item("maritalstatus").ToString
            Dim empStatus As String = ds.Tables("employees").Rows(0).Item("EmploymentStatus").ToString
            MessageBox.Show(empStatus)

            If Not txtUsername.Text = vbNullString Then
                CheckBox1.Checked = True
            End If
            If Not txtEmployeeNo.Text = vbNullString Then
                lblStatus.Text = "Updating existed employee"
            End If
        Catch ex As Exception

        End Try

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PictureBox1.Visible = False
        clearField(textboxes)
        lblStatus.Text = "Adding New Employee"
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e,users u where u.empid=e.empid"
        If txtEmployeeNo.Text = vbNullString Then 'basihan nato kung available ang employee no if not add if available update ra.
            ' StatusSet = "New" 'predicesor for adding a values


        Else
            'itemUpdate("Employees", ListView1, {"NameFirst", "NameMiddle", "NameLast", "Gender", "BirthDate", "BirthAddress", "MaritalStatus",
            '                                     "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact",
            '                                     "EmploymentStatus", "EmpImage"},
            '                                    {txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtMaritalStatus,
            'txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtEmployStatus, PictureBox1},
            '"EmpID", txtEmployeeNo.Text)
            ErrMessageText = "Fillup all empty "
            itemUpdate("Employees", ListView1,
                       {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact"},
                       {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo},
                       "EmpID", txtEmployeeNo.Text.ToString)

            ' StatusSet = "Update" 'predicessor for updating a values
            'strReferenceColumn = "empid" ' referrencial column entity
            'strReferenceID = txtEmployeeNo.Text 'values related to what needs to update
        End If
        ' SqlUpdateNew("employees", ListView1, {"username", "password", "namefirst", "namemiddle", "namelast", "gender", "birthdate", "BirthAddress", "MaritalStatus", "addressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "JobPosition", "JobRate", "JobCommission", "JobAssign", "EmploymentStatus", "empimage"},
        '                                    {txtUsername, txtPassword, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtMaritalStatus, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtPosition, txtRate, txtCommision, txtAssigned, txtEmployStatus, PictureBox1})

    End Sub

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        openImage(OpenFileDialog1, PictureBox1)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        txtSearch.Visible = True
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        SqlRefresh = "select empid, concat(namelast,', ',namefirst,' ',namemiddle) from employees where empid like @search or namelast like @search or namefirst like @search"
            StatusSet = "Search"
        ListView1.Items.Clear()
        SqlReFill("employees", ListView1, Nothing, {"search"}, {txtSearch})
        StatusSet = ""
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "DISABLE ACCESS TO APPLICATION"
            GroupBox3.Enabled = True
        Else
            CheckBox1.Text = "ENABLE ACCESS TO APPLICATION"
            GroupBox3.Enabled = False
        End If
    End Sub

End Class