Imports MySql.Data.MySqlClient
'Public Class clsDAL
'Public Connection As New MySqlConnection("server=localhost;database=posisdb;uid=root;pwd=")

'End Class
Class frmPOS
    Public objDal As New MySqlConnection("server=localhost;database=posisdb;uid=root;pwd=")
    Public strSQL As String
    Private Sub frmPOS_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

           ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.ExecuteNonQuery()
            'sqL = "Select max(InvoiceNo)+1 from transactions " & txtInvoiceNo.Text & ""
            cmd.CommandText = "Select max(InvoiceNo)+1 from transactions "
            cmd.Connection = conn
            dr = cmd.ExecuteReader()
            'cmd.ExecuteNonQuery()

            ' dr.Read()
            'txtInvoiceNo.Text = dr.Item("InvoiceNo")

            ' dr.Close()
       
            txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy")

            ' txtInvoiceNo.Text = dr("InvoiceNo").ToString()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            conn.Close()
            conn.Dispose()
      
        End Try
        'txtTransNo.Text = objDal.GetSingleField("Select max(transid)+1 from transactions")
    End Sub

    Private Sub txtItemNo_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtItemNo.KeyDown

        If e.KeyValue = 13 Then

            If String.IsNullOrEmpty(txtItemNo.Text) Then Exit Sub
            'sqL = "Select * from product where ProductNo=" & txtItemNo.Text & ""

            sqL = "Select * from product where ProductNo=" & txtItemNo.Text & ""
            cmd = New MySqlCommand(sqL, conn)
            ' dr = cmd.ExecuteReader()
            ' cmd.ExecuteNonQuery()
            ' conn.Open()
            '  Dim dr As DataRow = (sqL)
            If (dr Is Nothing) Then Throw New Exception("Invalid Item No")
           ' conn.Open()
            txtName.Text = dr("Description").ToString()
            txtPrice.Text = Double.Parse(dr("UnitPrice").ToString()).ToString("#,##0.00")
            txtQty.Focus()

            conn.Close()
        End If

    End Sub
    Private Sub ComputeTotal()
        Dim db As Double
        For Each ls As ListViewItem In ListItems.Items
            db += Double.Parse(ls.SubItems(3).Text)
        Next
        txtTotal.Text = db.ToString("#,##0.00")
    End Sub
    Private Sub txtQty_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtQty.KeyDown
        Try
            If e.KeyValue = 13 Then
                If String.IsNullOrEmpty(txtQty.Text) Then Return
                Dim ls As ListViewItem = Nothing
                'checks if itemno is already in the list
                For Each ls2 As ListViewItem In ListItems.Items
                    If (ls2.Tag = txtItemNo.Text) Then
                        ls = ls2
                    End If
                Next

                If (ls Is Nothing) Then 'if item no is not found on the list
                    ls = New ListViewItem
                    ls.Text = txtName.Text
                    ls.Tag = txtItemNo.Text
                    ls.SubItems.Add(txtQty.Text)
                    ls.SubItems.Add(txtPrice.Text)
                    ls.SubItems.Add((txtQty.Text * txtPrice.Text).ToString("#,##0.00"))
                    ListItems.Items.Add(ls)
                Else ' if found, updates quantity
                    ls.SubItems(1).Text = ((Double.Parse(txtQty.Text) + Double.Parse(ls.SubItems(1).Text)))
                    ls.SubItems(3).Text = ((ls.SubItems(1).Text * ls.SubItems(2).Text).ToString("#,##0.00"))
                End If
                ComputeTotal() 'compute total
                'clear textboxes
                txtItemNo.Text = ""
                txtName.Text = ""
                txtPrice.Text = ""
                txtQty.Text = ""
                txtItemNo.Focus()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ListItems_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ListItems.KeyDown
        Try
            If e.KeyValue = 46 Then 'if delete button is pressed
                If ListItems.Items.Count = 0 Then Exit Sub 'if there are no items in the list it will exit this code
                ListItems.Items.Remove(ListItems.SelectedItems(0)) 'removes and selected item in the list
                ComputeTotal() 'comput total
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CancelTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelTransactionToolStripMenuItem.Click
        For Each ctr As Control In Me.Controls
            If ctr.GetType() Is GetType(TextBox) Then
                ctr.Text = ""
            End If
        Next
        txtDate.Text = DateTime.Now.ToString("MM/dd/yyyy")
        frmPOS_Load(Nothing, Nothing)
        ListItems.Items.Clear()
    End Sub

    Private Sub SaveTransactionToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveTransactionToolStripMenuItem.Click
        Try

            If ListItems.Items.Count = 0 Then Return
            If String.IsNullOrEmpty(txtPaid.Text) Then Throw New Exception("No amount paid entered")
            txtPaid_KeyDown(Nothing, New KeyEventArgs(Keys.Enter))
            If String.IsNullOrEmpty(txtChange.Text) Then Throw New Exception("No amount paid entered")
            ConnDB()
            sqL = "insert into transactiondetails (InvoiceNo,ItemPrice,ProductNo,Quantity) values(" & txtInvoiceNo.Text & "," & txtTotal.Text & "," & txtPaid.Text & "," & txtChange.Text & ")"
            cmd = New MySqlCommand(sqL, conn)
            dr = cmd.ExecuteReader()
            'objDal.ExecuteQuery(strSQL)
            For Each ls As ListViewItem In ListItems.Items
                sqL = "insert into transactions (InvoiceNo,NonVatTotal,StaffID,TDate,TotalAmount,TTime)values (" & txtInvoiceNo.Text & "," & ls.Tag & ",'" & ls.SubItems(0).Text & "," & ls.SubItems(1).Text & "'," & ls.SubItems(2).Text & ", " & ls.SubItems(3).Text & ")"
                cmd = New MySqlCommand(sqL, conn)
                dr = cmd.ExecuteReader()
                ' objDal.ExecuteQuery(strSQL)
            Next
            Call CancelTransactionToolStripMenuItem_Click(Nothing, Nothing)

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub txtPaid_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPaid.KeyDown
        Try
            If e.KeyValue = 13 Then
                If Double.Parse(txtTotal.Text) > Double.Parse(txtPaid.Text) Then
                    txtPaid.SelectAll()
                    Throw New Exception("Insufficiend Amount paid")
                End If
                txtChange.Text = Double.Parse(txtPaid.Text) - Double.Parse(txtTotal.Text)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub txtItemNo_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtItemNo.TextChanged

    End Sub

    Private Sub ListItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListItems.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        frmPrintReceipt.ShowDialog()
    End Sub

End Class