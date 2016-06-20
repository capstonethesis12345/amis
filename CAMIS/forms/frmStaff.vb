
Imports MySql.Data.MySqlClient


Public Class frmStaff
    Dim usrPass As New TextBox
    Dim sStaff As String = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = sStaff
            SqlReFill("Employees", ListView1)

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

        textboxes = {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}

        clearField(textboxes)
        clearField({txtPassword, txtConfirmPWD})
        Try
            txtEmployeeNo.Text = ListView1.SelectedItems(0).Text.ToString
            'StatusSet = ""
            'ErrMessageText = ""

            SqlRefresh = "SELECT  e.Empid, e.NameFirst, e.NameMiddle,e.NameLast,ifnull(e.Gender,''),ifnull(e.BirthDate,''),ifnull(e.BirthAddress,''),ifnull(e.AddressStreet,''),ifnull(e.AddressBarangay,''),ifnull(e.AddressMunCity,''),ifnull(e.AddressProvince,''),ifnull(e.AddressZip,''),ifnull(e.Contact,''),ifnull(u.Username,''),ifnull(e.EmploymentStatus,'')EmploymentStatus,ifnull(e.maritalstatus,'')maritalstatus,ifnull(e.EmpImage,''),ifnull(`u`.`Function`,'')role,ifnull(`u`.`Password`,'')Ucode from Employees e
                            LEFT JOIN Users u
                            ON u.EmpID=e.Empid
                        where e.empid=@empid"
            msgShow = False 'PREVENT OCCURANCE OF MESSAGEBOX SHOW
            SqlReFill("Employees", Nothing, "ShowValueInTextbox", {"empid"}, {txtEmployeeNo}, textboxes)

            'COMMENTED CODED IS TO ACCESS MANUAL INFORMATION F DATASET TABLE.
            ' Dim mstatus As String = ds.Tables("employees").Rows(0).Item("maritalstatus").ToString
            Dim empStatus As String = ds.Tables("Employees").Rows(0).Item("EmploymentStatus").ToString
            Dim empAccess As String = ds.Tables("Employees").Rows(0).Item("role").ToString
            usrPass = New TextBox
            usrPass.Text = ds.Tables("Employees").Rows(0).Item("Ucode").ToString

            'NOW WE WILL SET EMPLOYMENT STATUS BASED ON THE 1 = EMPLOYED AND 0 AS NOT EMPLOYED
            If empStatus = 1 Then
                txtEmployStatus.SelectedIndex = 0
            Else
                txtEmployStatus.SelectedIndex = 1
            End If

            'SHOW ACCESS ROLES AS BASED ON ROLE ACCESS WHETHER ADMIN MANAGER OR CASHIER
            Select Case empAccess
                Case Is = "Admin"
                    CheckBox1.Checked = True
                Case Is = "Manager"
                    CheckBox1.Checked = True
                Case Is = "Cashier"
                    CheckBox1.Checked = True
                Case Else
                    CheckBox1.Checked = False
            End Select


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
        CheckBox1.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        'this will query athe following refresh upon insert and update

        ' SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from Employees e left join users u on u.empid=e.empid"

        Dim empStatus As New TextBox 'create a temporary object textbox to store string inorder to transfer a data into function itemnew() or itemupdate()
        'We will now set employment status if employed set text to 1 if not 0
        If txtEmployStatus.SelectedIndex = 0 Then
            empStatus.Text = 1
        Else
            empStatus.Text = 0
        End If

        msgShow = False
        If txtEmployeeNo.Text IsNot vbNullString Then 'basihan nato kung available ang employee no if not add if available update ra.
            MessageBox.Show("")
            SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
            itemNew("Employees",
                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                    {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus},
                    ListView1)

        Else


            ErrMessageText = "Fillup all empty "
            SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"

            itemUpdate("Employees",
                       {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                       {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus},
                       "EmpID", txtEmployeeNo.Text.ToString,
                       ListView1)
        End If

        'BELOW CODES INITIATE IF USERS HAS ABILITY TO INSERT ACCESSIBLE SOFTWARE AND ITS FUNCTIONS
        msgShow = True
        If CheckBox1.Checked = True Then

            MessageBox.Show("Input information first")

            '     If (txtUsername.Text Is vbNullString) Then
            '     
            ' Else
            '     If Not txtPassword.Text = txtConfirmPWD.Text Then
            '     MessageBox.Show("Password and Confirmation doesn't match. Please Try again")
            '     Exit Sub
            ' Else
            '    itemUpdate("Users", {"EmpID", "Username", "Password", "Function"}, {txtEmployeeNo, txtUsername, usrPass, txtFunction}, "EmpID", txtEmployeeNo.Text)
            ''End If
            '
            '       End If
            '       Else
            '          itemDelete("Users", {"EmpID"}, {txtEmployeeNo})
        End If


    End Sub

    Private Sub btnOpenImage_Click(sender As Object, e As EventArgs) Handles btnOpenImage.Click
        openImage(OpenFileDialog1, PictureBox1)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        txtSearch.Visible = True
        txtSearch.Focus()
    End Sub

    Private Sub txtSearch_KeyUp(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyUp
        SqlRefresh = "select empid, concat(namelast,', ',namefirst,' ',namemiddle) from Employees where empid like @search or namelast like @search or namefirst like @search"
        StatusSet = "Search"
        ListView1.Items.Clear()
        SqlReFill("Employees", ListView1, Nothing, {"search"}, {txtSearch})
        StatusSet = ""
    End Sub

    Private Sub txtSearch_Click(sender As Object, e As EventArgs) Handles txtSearch.Click

    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            CheckBox1.Text = "ENABLE ACCESS TO APPLICATION"
            GroupBox3.Enabled = True
        Else
            CheckBox1.Text = "DISABLE ACCESS TO APPLICATION"
            GroupBox3.Enabled = False
        End If
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPWD.KeyUp
        If txtConfirmPWD IsNot vbNullString Then
            If txtConfirmPWD.Text = txtPassword.Text Then
                usrPass.Text = txtPassword.Text
            End If
        End If
    End Sub
End Class