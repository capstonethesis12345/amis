Imports MySql.Data.MySqlClient
Public Class frmPayment

    Private Sub AddPayment()
        Try
            'sqL = "INSERT INTO PAYMENT(InvoiceNo, Cash, PChange) VALUES('" & frmPOS.lblInvoice.Text & "', '" & txtCash.Text.Replace(",", "") & "', '" & txtChange.Text.Replace(",", "") & "')"
            ConnDB()
            cmd = New MySqlCommand(sqL, conn)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox(ex.ToString)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Private Sub frmPayment_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Location = New Point(515, 470)
        ' txtTA.Text = frmPOS.lblTotalAmount.Text
    End Sub

    Private Sub txtCash_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtCash.KeyPress
        If e.KeyChar = ControlChars.Cr Then
            If Val(txtTA.Text.Replace(",", "") > Val(txtCash.Text.Replace(",", ""))) Then
                MsgBox("Insuficient cash to paid the total amount", MsgBoxStyle.Exclamation, "payment")
                txtCash.Focus()
            Else
                AddPayment()
                '  frmPOS.AddTransaction()
                '  frmPOS.AddTransactionDetails()
                '  frmPOS.UpdateProductQuantity()
                frmPrintReceipt.Show()
                MsgBox("Transaction completed. Press OK for a new transaction.", MsgBoxStyle.Information, "Transaction")
                '    frmPOS.NewTransaction()
                Me.Close()
            End If
        End If
    End Sub

    Private Sub txtCash_TextChanged1(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCash.TextChanged
        txtChange.Text = Format(Val(txtCash.Text.Replace(",", "")) - Val(txtTA.Text.Replace(",", "")), "#,##0.00")
    End Sub

    Private Sub Panel1_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles Panel1.Paint

    End Sub
End Class