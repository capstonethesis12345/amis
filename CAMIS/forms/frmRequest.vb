Imports MySql.Data

Public Class frmRequest
    Public Sub New()
        InitializeComponent()
        Try
            objForm = Me
            SqlRefresh = "select prnum,description,amount,purpose,datetime,status from requisition"
            SqlReFill("requisition", ListView1)
        Catch ex As Exception
            MessageBox.Show("Error in establishing connection " & ex.Message.ToString, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        StatusSet = "New"
        Dim sNew As New frmAddUpdateRequisition()
        sNew.ShowDialog()
        sNew = Nothing
    End Sub
    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnDecline.Click
        If ListView1.SelectedItems.Count = 0 Then
            MessageBox.Show("Select item first", "Selection not identified", MessageBoxButtons.OK, MessageBoxIcon.Hand)
        Else

        End If
    End Sub
    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Close()
    End Sub

    Private Sub ListView1_ItemSelectionChanged(sender As Object, e As ListViewItemSelectionChangedEventArgs) Handles ListView1.ItemSelectionChanged

    End Sub

    Private Sub ListView1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListView1.ItemSelectionChanged, ListView1.SelectedIndexChanged
        Dim status As String = ListView1.FocusedItem.SubItems(5).Text.ToString
        If account = "Administrator" Then
            If status = "Pending" Then
                btnAccept.Visible = True
                btnDecline.Visible = True
            Else
                btnAccept.Visible = False
                btnDecline.Visible = False
            End If
        Else
            btnAccept.Visible = False
            btnDecline.Visible = False
        End If
    End Sub

    Private Sub btnAccept_Click(sender As Object, e As EventArgs) Handles btnAccept.Click
        strReferenceColumn = "prnum"
        StatusSet = "Update"
        Dim d As Date = Now
        strReferenceID = ListView1.FocusedItem.SubItems(0).Text
        SqlUpdateNew("requisition", Me.ListView1, {"Status"}, {"Accepted " & frmMain.lblDate.Text & " " & frmMain.lblTimer.Text})
    End Sub
End Class