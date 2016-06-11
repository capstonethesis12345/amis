
Imports MySql.Data.MySqlClient
Public Class frmAddUpdateRequisition
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub frmAddUpdateRequisition_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        objFormUpdateNew = Me
        cmd.Parameters.Clear()
        ds.Clear()
        Select Case StatusSet
            Case Is = "New"
                lblTitle.Text = "Add new Purchase Requisition."
            Case Is = "Update"
                lblTitle.Text = "Update existing data."
                SqlRefresh = "select categoryname,categorydescription from category where categoryid=@categoryid"
                SqlReFill("category", Nothing, "ShowValueInTextbox", {"categoryid"}, {txtRequisitionNo}, {txtAmount, txtStatus})
        End Select
    End Sub
    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        'strReferenceID = Me.txtRequisitionNo.Text
        strReferenceColumn = "prnum"
        Dim d As Date = Now
        SqlUpdateNew("Requisition", frmRequest.ListView1, _
                     {"Description", "Amount", "Purpose", "Status", "DateTime"}, _
                    {txtDescription.Text, txtAmount.Text, txtPurpose.Text, "Pending", frmMain.lblDate.Text & " " & frmMain.lblTimer.Text})
        Me.Close()
    End Sub
End Class