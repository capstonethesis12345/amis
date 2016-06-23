Public Class frmFood
    Dim siRefresh As String = "select barcode,description,price from items where itemtype like 1"
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        SqlRefresh = siRefresh
        SqlReFill("foodingredient", ListView3)
        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Private Sub frmFood_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SqlRefresh = siRefresh
        Dim t As New TextBox
        t.Text = 1
        itemNew("Items", {"Barcode", "Description", "Price", "ItemType"}, {txtBarcode, txtMenuName, txtPrice, t})
    End Sub
End Class