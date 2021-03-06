﻿
Imports MySql.Data.MySqlClient


Public Class frmStaff
    Private isEditStaff As Boolean = False
    Private ischanged As Boolean = False
    Dim usrPass, usrName As New TextBox
    Private haserror As Boolean = False
    Dim sStaff As String = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
    Dim charactersAllowed As String = " abcdefghijklmnopqrstuvwxyz1234567890"
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = sStaff
            SqlReFill("Employees", ListView1)
            SqlRefresh = "select jobdescription from job"
            SqlReFill("jobs", txtJobs, "ShowValueInComboBox")
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection " & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        pbEmployeeStatus.Left = txtEmployStatus.Left - 1
        pbEmployeeStatus.Top = txtEmployStatus.Top - 1
        pbEmployeeStatus.Width = txtEmployStatus.Width + 2
        pbEmployeeStatus.Height = txtEmployStatus.Height + 2
        pbEmployeeStatus.Visible = False

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
        textboxes = {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, txtFunction}

        clearField(textboxes)
        clearField({txtPassword, txtConfirmPWD})
        txtEmployeeNo.Text = ListView1.SelectedItems(0).Text.ToString
        reloadinfo()

    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        PictureBox1.Visible = False
        textboxes = {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}
        clearField(textboxes)
        lblStatus.Text = "Adding New Employee"
        CheckBox1.Checked = False
    End Sub
    Private Sub checkHasError()
        If Integer.Parse(getIDFunction("Select ifnull(count(`Username`),0) from `users` where `Username` Like @0", "Username", {txtUsername.Text})) <> 0 And txtUsername.Text <> getStrData("select username from users where empid like @0", "userCheck", {txtEmployeeNo.Text}) Then
            MessageBox.Show("User name already existed. Choose another one.")
            haserror = True
            Exit Sub
        End If
        If txtPassword.Text <> txtConfirmPWD.Text Then
            MessageBox.Show("Password and confirmation do not match, please try again.")
            haserror = True
            Exit Sub
        End If

    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        txtEmployeeNo.Text = fillFirstLastMiName(txtFirstname.Text, txtLastname.Text, txtMI.Text)
        If ifempty(txtLastname) = True Or ifempty(txtFirstname) Or ifempty(txtMI) Or ifcomboempty(txtEmployStatus) = True Or txtEmployStatus.Text = vbNullString Then
            If txtEmployStatus.Text = vbNullString Then
                pbEmployeeStatus.Visible = True
            End If
            Exit Sub
        End If


        If txtEmployeeNo.Text = vbNullString Then
                isEditStaff = False
                If CheckBox1.Checked = True Then
                    checkHasError()
                    If haserror = False Then
                        insertStaffUser()
                    Else
                        Exit Sub
                    End If
                    Exit Sub
                Else
                    insertStaff()
                End If
            Else
                If isEditStaff = False Then
                    MessageBox.Show("Editable on 93 =" & isEditStaff)
                    If (MessageBox.Show("Staff details already existed, do you want to load information?", "Stop", MessageBoxButtons.YesNo) = DialogResult.No) Then
                        txtEmployeeNo.Text = ""
                        Exit Sub
                    Else
                        reloadinfo()
                    End If
                Else
                    checkHasError()
                    If haserror = False Then
                        usersUpdateDelete()
                    Else
                        MessageBox.Show("Error occured on 104")
                        haserror = False
                        Exit Sub
                    End If
                End If
            End If
        haserror = False
    End Sub
    Private Sub usersUpdateDelete()
        Dim userDuplicationCheck As Integer = Integer.Parse(getIDFunction("Select ifnull(count(`Username`),0) from `users` where `Username` Like @0", "Username", {txtUsername.Text}))
        If CheckBox1.Checked = True Then
            MessageBox.Show("CHeckbox enabled ")
            If txtUsername.Text = vbNullString Then
                MessageBox.Show("Fillup username first")
                haserror = True
                Exit Sub
            End If
            If txtFunction.Text = vbNullString Then
                MessageBox.Show("Select function first")
                haserror = True
                Exit Sub
            End If
            If txtConfirmPWD.Text = txtPassword.Text And txtPassword.Text <> vbNullString Then
                'MessageBox.Show("Ready for adding user.")
                If haserror = True Then
                    MessageBox.Show("Error found. line 119")
                Else
                    MessageBox.Show("Ready adding user.")

                    Dim isExists As Integer = Integer.Parse(getIDFunction("select ifnull(empid,0) from users where empid like @0", "Empid", {txtEmployeeNo.Text}))
                    If isExists = 0 Then
                        MessageBox.Show("Inserting user access ")
                        If txtUsername.Text = vbNullString Then
                            MessageBox.Show("Username required")
                            haserror = True
                        End If
                        If Not txtPassword.Text = txtConfirmPWD.Text Then
                            haserror = True
                            MessageBox.Show("Username and confirmation do not match.")
                        End If

                        ' MessageBox.Show("Available User" & userDuplicationCheck.ToString)
                        If userDuplicationCheck = 0 Then
                            itemNew("users", {"Empid", "Username", "Password", "Function"}, {txtEmployeeNo, txtUsername, txtPassword, txtFunction})

                        End If

                    Else
                        If txtUsername.Text = vbNullString Then
                            MessageBox.Show("Empty username not allowed")
                            Exit Sub
                        Else
                            MessageBox.Show("Update user")
                            itemUpdate("users", {"Function", "Username", "Password"}, {txtFunction, txtUsername, txtPassword}, "empid", txtEmployeeNo.Text)
                        End If


                    End If


                    'SqlRefresh = sStaff
                    SqlRefresh = sStaff
                    MessageBox.Show("update employees")
                    EmpItemUpdate()


                End If
            Else
                If txtPassword.Text = vbNullString Then
                    MessageBox.Show("Empty password not allowed")
                    haserror = True
                    Exit Sub
                End If
                If Not txtPassword.Text = txtConfirmPWD.Text Then
                    MessageBox.Show("Password and confirmation do not match please try again.")
                    txtConfirmPWD.Text = ""
                    txtPassword.Text = ""
                    haserror = True
                Else
                    MessageBox.Show("Password and confirm acccepted")
                End If
            End If

        Else
            'MessageBox.Show("delete user login")
            msgShow = False
            EmpItemUpdate()
            itemDelete("`users`", {"EmpID"}, {txtEmployeeNo})
        End If
    End Sub
    Private Sub insertStaff()
        Dim empStatus As New TextBox
        Select Case txtEmployStatus.SelectedIndex
            Case Is = 0
                empStatus.Text = 0
                Exit Select
            Case Is = 1
                empStatus.Text = 1
                Exit Select
            Case Is = 2
                empStatus.Text = 2
                Exit Select
            Case Is = 3
                empStatus.Text = 3
                Exit Select
            Case Is = 4
                empStatus.Text = 4
                Exit Select
        End Select
        SqlRefresh = "Select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from `employees` e left join `users` u on u.empid=e.empid order by e.empid asc"
        msgShow = True
        ErrMessageText = "Unable to insert employees on line 93"
        'set marital status to integer

        Dim maritalIndex As New TextBox
        If txtMaritalStatus.Text = "Single" Then
            maritalIndex.Text = 0
        ElseIf (txtMaritalStatus.SelectedIndex = 1) Then
            maritalIndex.Text = 1
        ElseIf (txtMaritalStatus.SelectedIndex = 2) Then
            maritalIndex.Text = 2
        End If
        itemNew("employees",
                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus", "EmploymentStarted"},
                   {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, maritalIndex, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus, txtEmpStarted},
                                    ListView1)
    End Sub
    Private Sub updateStaffUser()
        Dim ms As New TextBox
        ms.Text = txtMaritalStatus.SelectedIndex
        itemUpdate("employees", {"Gender", "BirthDate", "BirthAddress", "MaritalStatus", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStarted", "EmpImage"},
                           {txtGender, txtBirthDate, txtBirthAddress, ms, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtEmpStarted, PictureBox1}, "EmpID", txtEmployeeNo.Text)

    End Sub
    Private Sub insertStaffUser()
        Dim empStatus As New TextBox
        Select Case txtEmployStatus.SelectedIndex
            Case Is = 0
                empStatus.Text = 0
                Exit Select
            Case Is = 1
                empStatus.Text = 1
                Exit Select
            Case Is = 2
                empStatus.Text = 2
                Exit Select
            Case Is = 3
                empStatus.Text = 3
                Exit Select
            Case Is = 4
                empStatus.Text = 4
                Exit Select
        End Select
        SqlRefresh = "Select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from `employees` e left join `users` u on u.empid=e.empid order by e.empid asc"
        msgShow = True
        ErrMessageText = "Unable to insert employees on line 93"
        itemNew("employees",
                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus", "EmploymentStarted"},
                   {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus, txtEmpStarted},
                                    ListView1)
        Dim getEmpID As New TextBox
        getEmpID.Text = Integer.Parse(getIDFunction("select ifnull(empid,0) from `employees` where namefirst like @0 and namelast like @1 and namemiddle like @2", "Empid", {txtFirstname.Text, txtLastname.Text, txtMI.Text}))
        msgShow = True
        ErrMessageText = "Unable to insert users on line 101"
        itemNew("users", {"Empid", "Username", "Password", "Function"}, {getEmpID, txtUsername, txtPassword, txtFunction})

    End Sub
    Private Function fillFirstLastMiName(ByVal fname As String, ByVal lname As String, ByVal mname As String) As String
        SqlRefresh = "SELECT e.Empid from `employees` e LEFT JOIN `users` u On u.EmpID=e.Empid where e.namefirst Like @0 And e.namelast Like @1 And e.namemiddle Like @2"
        Try
            msgShow = False
            Return getStrData(SqlRefresh, "dExisted", {fname, lname, mname}).ToString
        Catch ex As Exception
            Return vbNullString
        End Try


    End Function
    Private Sub btnSaves_Click(sender As Object, e As EventArgs)
        Dim isError As Boolean = False
        Dim empStatus As New TextBox 'create a temporary object textbox to store string inorder to transfer a data into function itemnew() or itemupdate()
        'create search if fname and lastname or md has existed
        If txtEmployeeNo.Text = vbNullString Then

        Else
            isEditStaff = True
        End If

        SqlRefresh = "Select  e.Empid from `employees` e LEFT JOIN `users` u " &
                     "On u.EmpID=e.Empid where e.namefirst Like @namefirst And e.namelast Like @namelast And e.namemiddle Like @namemiddle"

        'msgShow = True 'PREVENT OCCURANCE OF MESSAGEBOX SHOW
        'ErrMessageText = "Error On line 78"
        'SqlReFill("employees", Nothing, "ShowValueInTextbox", {"namefirst", "namelast", "namemiddle"}, {txtFirstname, txtLastname, txtMI}, {txtEmployeeNo})

        ' If txtEmployStatus.SelectedIndex = 0 Then
        ' empStatus.Text = 1
        ' Else
        ' empStatus.Text = 0
        ' End If
        Select Case txtEmployStatus.SelectedIndex
            Case Is = 0
                empStatus.Text = 0
                Exit Select
            Case Is = 1
                empStatus.Text = 1
                Exit Select
            Case Is = 2
                empStatus.Text = 2
                Exit Select
            Case Is = 3
                empStatus.Text = 3
                Exit Select
            Case Is = 4
                empStatus.Text = 4
                Exit Select

        End Select

        Dim userDuplicationCheck As Integer = Integer.Parse(getIDFunction("Select ifnull(count(`Username`),0) from `users` where `Username` Like @0", "Username", {txtUsername.Text}))
        If Not userDuplicationCheck = 0 And CheckBox1.Checked = True And ischanged = True Then
            isError = True
            MessageBox.Show("Username Not avaiable." & " Line 106")
            Exit Sub
        End If
        If txtEmployeeNo.Text = vbNullString Then 'Adding new user
            isEditStaff = False
            'Adding
            If txtFirstname.Text = vbNullString Or txtLastname.Text = vbNullString Or txtMI.Text = vbNullString Then
                MessageBox.Show("Inadequate information needed.")
                Exit Sub
            Else





                'MessageBox.Show("insert information")

                If isEditStaff = False Then
                    msgShow = True
                    ErrMessageText = "Error On line 120"
                    'CHECK if user is not in use
                    ' Dim cntUser As String = getStrData("Select count(username) from users where username Like @0", "users", {txtUsername.Text})
                    'If cntUser = 1 Then
                    ' Dim user As String = getIDFunction("Select username from users where username Like @0", "users", {txtUsername.Text})
                    ' Else

                    'End If

                    ' MessageBox.Show(user)
                    If CheckBox1.Checked = True Then

                        If txtUsername.Text = vbNullString Then
                            MessageBox.Show("Username Is required")
                            isError = True
                            Exit Sub
                        End If
                        If Not txtConfirmPWD.Text = txtPassword.Text Then
                            MessageBox.Show("Password And confirmation Do Not match")
                            isError = True
                            Exit Sub
                        End If

                        If isError = False Then
                            If CheckBox1.Checked = True Then
                                If txtFunction.Text = vbNullString Then
                                    isError = True
                                    MessageBox.Show("Select role first")
                                    Exit Sub
                                End If
                                If txtUsername.Text = vbNullString Then
                                    isError = True
                                    MessageBox.Show("Fillup username first")
                                    Exit Sub
                                End If
                                If txtPassword.Text <> txtConfirmPWD.Text Then
                                    isError = True
                                    MessageBox.Show("line 131 Password And confirmation Do Not match")
                                    Exit Sub
                                End If
                                If isError = False Then
                                    MessageBox.Show("Insert To employees table")
                                    Dim ms As New TextBox
                                    ms.Text = txtMaritalStatus.SelectedIndex

                                    SqlRefresh = "Select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
                                    itemNew("Employees",
                                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus", "EmploymentStarted"},
                                    {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus, txtEmpStarted},
                                    ListView1)
                                    Dim getEmpID As New TextBox
                                    getEmpID.Text = Integer.Parse(getIDFunction("select ifnull(empid,0) from employees where namefirst like @0 and namelast like @1 and namemiddle like @2", "Empid", {txtFirstname.Text, txtLastname.Text, txtMI.Text}))
                                    MessageBox.Show("Insert to users table with " & getEmpID.ToString)
                                    itemNew("usersinsert", {"Empid", "Username", "Password", "Function"}, {getEmpID, txtUsername, txtPassword, txtFunction})

                                End If
                            Else

                                MessageBox.Show("Insert to employees table")
                            End If

                        End If


                    Else
                        'MessageBox.Show("Inserting data")
                        If userDuplicationCheck = 0 Then
                            Dim ms As New TextBox
                            ms.Text = txtMaritalStatus.SelectedIndex

                            SqlRefresh = "select e.empid,concat(e.namelast,', ',e.namefirst,' ',e.namemiddle) from employees e left join users u on u.empid=e.empid order by e.empid asc"
                            itemNew("Employees",
                   {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                    {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, ms, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus},
                    ListView1)
                            MessageBox.Show("Inserting User access")
                            itemNew("users", {"Empid", "Username", "Password", "Function"}, {txtEmployeeNo, txtUsername, txtPassword, txtFunction})

                        End If

                        'WE WILL not get the empNO

                    End If

                Else
                    MessageBox.Show("Update")
                End If


            End If
        Else  'Updating inputed user
            MessageBox.Show("isEditStaff = " & isEditStaff.ToString)
            If isEditStaff = True Then
                msgShow = True

                If CheckBox1.Checked = True Then
                    MessageBox.Show("CHeckbox enabled ")
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
                        'MessageBox.Show("Ready for adding user.")
                        If isError = True Then
                            MessageBox.Show("Error found. like 435")
                        Else
                            MessageBox.Show("Ready adding user.")

                            Dim isExists As Integer = Integer.Parse(getIDFunction("select ifnull(empid,0) from users where empid like @0", "Empid", {txtEmployeeNo.Text}))
                            If isExists = 0 Then
                                MessageBox.Show("Inserting user access ")
                                If txtUsername.Text = vbNullString Then
                                    MessageBox.Show("Username required")
                                    isError = True
                                End If
                                If Not txtPassword.Text = txtConfirmPWD.Text Then
                                    isError = True
                                    MessageBox.Show("Username and confirmation do not match.")
                                End If

                                ' MessageBox.Show("Available User" & userDuplicationCheck.ToString)
                                If userDuplicationCheck = 0 Then
                                    itemNew("users", {"Empid", "Username", "Password", "Function"}, {txtEmployeeNo, txtUsername, txtPassword, txtFunction})

                                End If

                            Else
                                If txtUsername.Text = vbNullString Then
                                    MessageBox.Show("Empty username not allowed")
                                    Exit Sub
                                Else
                                    MessageBox.Show("Update user")
                                    itemUpdate("users", {"Function", "Username", "Password"}, {txtFunction, txtUsername, txtPassword}, "empid", txtEmployeeNo.Text)
                                End If


                            End If


                            'SqlRefresh = sStaff
                            SqlRefresh = sStaff
                            MessageBox.Show("update employees")
                            EmpItemUpdate()


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
                    'MessageBox.Show("delete user login")
                    msgShow = False
                    EmpItemUpdate()
                    itemDelete("`users`", {"EmpID"}, {txtEmployeeNo})
                End If



                '     SqlRefresh = sStaff
                '      itemUpdate("Employees", {"NameFirst", "NameMiddle", "NameLast", "BirthDate", "Gender", "MaritalStatus", "EmpImage", "BirthAddress", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStatus"},
                '           {txtFirstname, txtMI, txtLastname, txtBirthDate, txtGender, txtMaritalStatus, PictureBox1, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, empStatus}, "Empid", txtEmployeeNo.Text, ListView1)
            Else
                If MessageBox.Show("Employee already existed on the database. " & vbNewLine & "Do you want to reload information?", "Notice", MessageBoxButtons.OKCancel) = DialogResult.OK Then
                    MessageBox.Show("Employee already existed in the system")
                    reloadinfo()
                Else
                    clearField(textboxes)
                End If
            End If


        End If



        ischanged = False


    End Sub
    Sub EmpItemUpdate()
        Dim ms As New TextBox
        ms.Text = txtMaritalStatus.SelectedIndex
        itemUpdate("employees", {"Gender", "BirthDate", "BirthAddress", "MaritalStatus", "AddressStreet", "AddressBarangay", "AddressMunCity", "AddressProvince", "AddressZip", "Contact", "EmploymentStarted", "EmpImage"},
                           {txtGender, txtBirthDate, txtBirthAddress, MS, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtEmpStarted, PictureBox1}, "EmpID", txtEmployeeNo.Text)

    End Sub
    Sub reloadinfo()
        textboxes = {txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, txtUsername, txtEmployStatus, txtMaritalStatus, PictureBox1, txtFunction}

        clearField(textboxes)
        clearField({txtPassword, txtConfirmPWD})
        Try
            '  txtEmployeeNo.Text = ListView1.SelectedItems(0).Text.ToString
            'StatusSet = ""
            'ErrMessageText = ""

            SqlRefresh = "SELECT  e.Empid, e.NameFirst, e.NameMiddle,e.NameLast, IFNULL( IF( e.gender =  'M', 0, IF( e.gender =  'F', 1 , -1 ) ) , -1 ) gender,ifnull(e.BirthDate,'')BirthDate,ifnull(e.BirthAddress,'')BirthAddress,ifnull(e.AddressStreet,'')AddressStreet,ifnull(e.AddressBarangay,'')AddressBarangay,ifnull(e.AddressMunCity,'')AddressMunCity,ifnull(e.AddressProvince,'')AddressProvince,ifnull(e.AddressZip,'')AddressZip,ifnull(e.Contact,'')Contact,ifnull(e.EmpImage,'')EmpImage,if(employmentstarted='0000-00-00',curdate(),employmentstarted)employmentstarted,ifnull(e.employmentstatus,-1)employmentstatus,ifnull(e.maritalstatus,0)maritalstatus,ifnull(u.Username,''),ifnull(`u`.`Function`,'')role,ifnull(`u`.`Password`,'')Ucode,ifnull(`u`.`Username`,'')Uname from `employees` e  LEFT JOIN `users` u ON u.EmpID=e.Empid where e.empid=@empid"
            msgShow = False 'PREVENT OCCURANCE OF MESSAGEBOX SHOW
            SqlReFill("Employees", Nothing, "ShowValueInTextbox", {"empid"}, {txtEmployeeNo}, {txtEmployeeNo, txtFirstname, txtMI, txtLastname, txtGender, txtBirthDate, txtBirthAddress, txtStreet, txtBarangay, txtCity, txtProvince, txtZip, txtContractNo, PictureBox1, txtEmpStarted})

            'COMMENTED CODED IS TO ACCESS MANUAL INFORMATION F DATASET TABLE.
            ' Dim mstatus As String = ds.Tables("employees").Rows(0).Item("maritalstatus").ToString
            txtGender.SelectedIndex = ds.Tables("Employees").Rows(0).Item("gender")
            'Single
            'Married
            'Widow
            Select Case ds.Tables("Employees").Rows(0).Item("maritalstatus")
                Case Is = "Single"
                    txtMaritalStatus.SelectedIndex = 0
                    Exit Select
                Case Is = "Married"
                    txtMaritalStatus.SelectedIndex = 1
                    Exit Select
                Case Is = "Widow"
                    txtMaritalStatus.SelectedIndex = 2
                    Exit Select
            End Select



            Dim empStatus As String = ds.Tables("Employees").Rows(0).Item("EmploymentStatus").ToString
            Dim empAccess As String = ds.Tables("Employees").Rows(0).Item("role").ToString
            ' MessageBox.Show(empAccess)
            usrPass = New TextBox
            usrPass.Text = ds.Tables("Employees").Rows(0).Item("Ucode").ToString
            txtPassword.Text = usrPass.Text
            txtConfirmPWD.Text = usrPass.Text
            txtUsername.Text = ds.Tables("Employees").Rows(0).Item("Uname").ToString

            If empAccess = "" Then
                CheckBox1.Checked = False
                GroupBox3.Enabled = False
            Else
                CheckBox1.Checked = True
                GroupBox3.Enabled = True
            End If
            'NOW WE WILL SET EMPLOYMENT STATUS BASED ON THE FOLLOWING
            'EMPLOYMENT STATUS
            '0=Job Order
            '1=Regular
            '2=Provisionary
            '3=Contractual
            '4=Resigned
            '5=Dismissed

            If empStatus = "0" Then
                txtEmployStatus.SelectedIndex = 0
            ElseIf (empStatus = "1") Then
                txtEmployStatus.SelectedIndex = 1
            ElseIf (empStatus = "2") Then
                txtEmployStatus.SelectedIndex = 2
            ElseIf (empStatus = "3") Then
                txtEmployStatus.SelectedIndex = 3
            ElseIf (empStatus = "4") Then
                txtEmployStatus.SelectedIndex = 4
            ElseIf (empStatus = "5") Then
                txtEmployStatus.SelectedIndex = 5
            End If


            'SHOW ACCESS ROLES AS BASED ON ROLE ACCESS WHETHER ADMIN MANAGER OR CASHIER
            Select Case empAccess
                Case Is = "Admin"
                    txtFunction.SelectedIndex = 0
                Case Is = "Manager"
                    txtFunction.SelectedIndex = 1
                Case Is = "Cashier"
                    txtFunction.SelectedIndex = 2
                Case Is = "Cook"
                    txtFunction.SelectedIndex = 3
                Case Else
                    txtFunction.SelectedIndex = -1
            End Select
            If Not txtEmployeeNo.Text = vbNullString Then
                lblStatus.Text = "Updating existed employee"
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
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

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.KeyUp
        ischanged = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Try
            frmJob.ShowDialog()
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        End Try

    End Sub

    Private Sub txtLastname_TextChanged(sender As Object, e As EventArgs)

        txtLastname = metrocasenumbers(txtLastname)

    End Sub

    Private Sub txtFirstname_TextChanged(sender As Object, e As EventArgs)
        txtFirstname = metrocaseletters(txtFirstname)
    End Sub

    Private Sub txtMI_TextChanged(sender As Object, e As EventArgs)
        txtMI = metrocaseletters(txtMI)
    End Sub

    Private Sub txtContractNo_TextChanged(sender As Object, e As EventArgs) Handles txtContractNo.TextChanged
        txtContractNo = casenumbers(txtContractNo)
    End Sub


    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtConfirmPWD.KeyUp
        If txtConfirmPWD IsNot vbNullString Then
            If txtConfirmPWD.Text = txtPassword.Text Then
                usrPass.Text = txtPassword.Text
            End If

        End If
    End Sub

    Private Sub txtEmployStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtEmployStatus.SelectedIndexChanged
        If Not txtEmployStatus.Text = vbNullString Then
            pbEmployeeStatus.Visible = False
        End If
    End Sub

End Class