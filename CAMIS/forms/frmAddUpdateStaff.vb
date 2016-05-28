Imports MySql.Data.MySqlClient
Public Class frmAddUpdateStaff
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frmAddUpdateStaff_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFormUpdateNew = Me
        cmd.Parameters.Clear()
        ds.Clear()
        Select Case StatusSet
            Case Is = "New"
                lblTitle.Text = "Add new purchase requisition."
            Case Is = "Update"
                lblTitle.Text = "Update existing data."
                Dim r As String = SqlRefresh
                SqlRefresh = "select namefirst,namemiddle,namelast,addressstreet,addressbarangay," & _
                    "addressmulcity,addressprovince,addresszip,contact,jobposition," & _
                    "jobrate,jobcommission,jobassign,username,password from employees where empid=@empid"
                'SqlRefresh = "select categoryname,categorydescription from category where categoryid=@categoryid"
                Dim txtboxes As Object() = {txtFirstname, txtMI, txtLastname, txtStreet, txtBarangay, _
                                            txtCity, txtProvince, txtZip, txtContractNo, txtRole, _
                                            txtRate, txtCommision, txtAssigned, txtUsername, txtPassword}
                SqlReFill("employees", Nothing, "ShowValueInTextbox", {"empid"}, {txtRequisitionNo}, txtboxes)
                SqlRefresh = r
        End Select
    End Sub
    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        strReferenceID = Me.txtRequisitionNo.Text
        strReferenceColumn = "EmpID"
        Dim arrCol() As String = {"username", "namefirst", "namemiddle", "namelast", "addressstreet", "addressbarangay", "addressmulcity", "addressprovince", "addresszip", "jobposition", "jobrate", "jobassign", "contact", "password", "jobcommission"}
        Dim oarrTextBox() As Object = {txtUsername.Text, txtFirstname.Text, txtMI.Text, txtLastname.Text, txtStreet.Text, txtBarangay.Text, txtCity.Text, txtProvince.Text, txtZip.Text, txtRole.Text, txtRate.Text, txtAssigned.Text, txtContractNo.Text, txtPassword.Text, txtCommision.Text}
        SqlUpdateNew("Employees", frmStaff.ListView1, arrCol, oarrTextBox)
        Me.Close()
    End Sub
End Class