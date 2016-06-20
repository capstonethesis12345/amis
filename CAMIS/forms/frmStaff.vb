
Imports MySql.Data.MySqlClient

'EMPLOYMENT STATUS
'0=discharge
'1=Job Order
'2=Regular
'3=Provision
'4=Contractual
Public Class frmStaff
    Private isEditStaff As Boolean = False
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
        isEditStaff = True
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
        textboxes = {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}
        clearField(textboxes)
        lblStatus.Text = "Adding New Employee"
        CheckBox1.Checked = False
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim isError As Boolean = False
        Dim empStatus As New TextBox 'create a temporary object textbox to store string inorder to transfer a data into function itemnew() or itemupdate()
        'create search if fname and lastname or md has existed
        If txtEmployeeNo.Text = vbNullString Then
            isEditStaff = False
        Else
            isEditStaff = True
        End If
        SqlRefresh = "SELECT  e.Empid 
                        from Employees e
                            LEFT JOIN Users u
                            ON u.EmpID=e.Empid
                        where e.namefirst like @namefirst and e.namelast like @namelast and e.namemiddle like @namemiddle"
        msgShow = False 'PREVENT OCCURANCE OF MESSAGEBOX SHOW
        SqlReFill("Employees", Nothing, "ShowValueInTextbox", {"namefirst", "namelast", "namemiddle"}, {txtFirstname, txtLastname, txtMI}, {txtEmployeeNo})

        If txtEmployStatus.SelectedIndex = 0 Then
            empStatus.Text = 1
        Else
            empStatus.Text = 0
        End If


        If txtEmployeeNo.Text = vbNullString Then
            'Adding
            If txtFirstname.Text = vbNullString Or txtLastname.Text = vbNullString Or txtMI.Text = vbNullString Then
                MessageBox.Show("Inadequate information needed.")


            Else
                'MessageBox.Show("insert information")

                If isEditStaff = False Then
                    msgShow = True
                    'CHECK if user is not in use
                    msgShow = False
                    Dim user As String = getIDFunction("select username from users where username like @0", "users", {txtUsername.Text})
                    ' MessageBox.Show(user)
                    If CheckBox1.Checked = True Then

                        If txtUsername.Text = vbNullString Then
                            MessageBox.Show("Username is required")
                            isError = True
                            Exit Sub
                        End If
                        If txtUsername.Text = txtPassword.Text Then
                            MessageBox.Show("Password and confirmation do not match")
                            isError = True
                            Exit Sub
                        End If

                        If isError = False Then
                            MessageBox.Show("Insert to users table")
                            MessageBox.Show("Insert to employees table")
                        End If


                    Else
                        SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
                        itemNew("Employees",
                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                    {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus},
                    ListView1)

                    End If

                Else
                    MessageBox.Show("Update")
                End If


            End If
        Else
            If isEditStaff = True Then
                msgShow = True

                If CheckBox1.Checked = True Then
                    If txtUsername.Text = vbNullString Then
                        MessageBox.Show("Fillup username first")
                        isError = True
                        Exit Sub
                    End If
                    If txtFunction.Text = vbNullString Then
                        MessageBox.Show("Select function first")
                        isError = True
                        Exit Sub
                    End If
                    If txtConfirmPWD.Text = txtPassword.Text And txtPassword.Text <> vbNullString Then

                        If isError = False Then
                            MessageBox.Show("Update user login")
                            SqlRefresh = sStaff
                            itemUpdate("employees", {"Gender", "BirthDate", "BirthAddress", "MaritalStatus", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact"},
                           {txtGender, txtBirthDate, txtBirthAddress, txtMaritalStatus, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo}, "EmpID", txtEmployeeNo.Text)
                            itemNew("users", {"Empid", "Username", "Password", "Function"}, {txtEmployeeNo, txtUsername, txtPassword, txtFunction})
                        End If
                    Else
                        If txtPassword.Text = vbNullString Then
                            MessageBox.Show("Empty password not allowed")
                            isError = True
                            Exit Sub
                        End If
                        If Not txtPassword.Text = txtConfirmPWD.Text Then
                            MessageBox.Show("Password and confirmation do not match please try again.")
                            txtConfirmPWD.Text = ""
                            txtPassword.Text = ""
                            isError = True
                        Else
                            MessageBox.Show("Password and confirm acccepted")
                        End If
                    End If

                Else
                    MessageBox.Show("delete user login")

                    SqlRefresh = sStaff
                    itemUpdate("employees", {"Gender", "BirthDate", "BirthAddress", "MaritalStatus", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact"},
                           {txtGender, txtBirthDate, txtBirthAddress, txtMaritalStatus, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo}, "EmpID", txtEmployeeNo.Text)


                End If



                '     SqlRefresh = sStaff
                '      itemUpdate("Employees", {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                '           {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus}, "Empid", txtEmployeeNo.Text, ListView1)
            Else
                If MessageBox.Show("Employee already existed on the database. " & vbNewLine & "Do you want to reload information?", "Notice", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    MessageBox.Show("reload information")
                    '     SqlRefresh = "SELECT   e.NameFirst,     e.NameMiddle,   e.NameLast, ifnull(e.Gender,''),    ifnull(e.BirthDate,''),ifnull(e.BirthAddress,''),ifnull(e.AddressStreet,''),ifnull(e.AddressBarangay,''),ifnull(e.AddressMunCity,''),ifnull(e.AddressProvince,''),ifnull(e.AddressZip,''),ifnull(e.Contact,''),ifnull(e.maritalstatus,'')maritalstatus,ifnull(e.EmpImage,'') from Employees e
                    '    Left JOIN Users u
                    '   On u.EmpID=e.Empid
                    '  where e.empid=@empid"
                    ' msgShow = False 'PREVENT OCCURANCE OF MESSAGEBOX SHOW
                    'textboxes = {txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtMaritalStatus, PictureBox1}
                    'SqlReFill("Employees", Nothing, "ShowValueInTextbox", {"empid"}, {txtEmployeeNo}, textboxes)
                    reloadinfo()
                Else
                    clearField(textboxes)
                End If
            End If


        End If






    End Sub
    Sub reloadinfo()
        textboxes = {txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}

        clearField(textboxes)
        clearField({txtPassword, txtConfirmPWD})
        Try
            'txtEmployeeNo.Text = ListView1.SelectedItems(0).Text.ToString
            'StatusSet = ""
            'ErrMessageText = ""

            SqlRefresh = "SELECT e.NameFirst, e.NameMiddle, e.NameLast, IFNULL( e.Gender,  '' ) , IFNULL( e.BirthDate,  '' ) , IFNULL( e.BirthAddress,  '' ) , IFNULL( e.AddressStreet,  '' ) , IFNULL( e.AddressBarangay,  '' ) , IFNULL( e.AddressMunCity,  '' ) , IFNULL( e.AddressProvince,  '' ) , IFNULL( e.AddressZip,  '' ) , IFNULL( e.Contact,  '' ) , IFNULL( u.Username,  '' ) , IFNULL( e.EmploymentStatus,  '' ) EmploymentStatus, IFNULL( e.maritalstatus,  '' ) maritalstatus, IFNULL( e.EmpImage,  '' ) , IFNULL(  `u`.`Function` ,  '' ) role, IFNULL(  `u`.`Password` ,  '' ) Ucode
FROM Employees e
LEFT JOIN Users u ON u.EmpID = e.Empid
WHERE e.empid LIKE  @empid"
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

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub
End Class