Module formDesigns
    'Public ParentForm As Form = frmMain
    Function formMain(ByVal MainForms As Object)
        MainForms.IsMdiContainer = True
        'MainForm.MdiParent = MainForm
        Return 0
    End Function
    Sub openFull(ByRef objForm As Form)
        With objForm
            ' . = True
            .MdiParent = frmMain.ActiveForm
            .FormBorderStyle = FormBorderStyle.None
            .Dock = DockStyle.Fill
            .Show()
        End With
    End Sub
    Public Sub ClearTextBoxes(ByRef objForm As Form, Optional ByVal ctlcol As Control.ControlCollection = Nothing)
        If ctlcol Is Nothing Then ctlcol = objForm.Controls
        For Each ctl As Control In ctlcol
            If TypeOf (ctl) Is TextBox Then
                DirectCast(ctl, TextBox).Clear()
            Else
                If TypeOf (ctl) Is ComboBox Then
                    DirectCast(ctl, ComboBox).Text = ""
                End If
                If Not ctl.Controls Is Nothing OrElse ctl.Controls.Count <> 0 Then
                    ClearTextBoxes(objForm, ctl.Controls)
                End If
            End If
        Next

    End Sub
    Public Sub showHolder(ByVal oTxtPlace As Object, ByVal oHolder As Object)
        If oTxtPlace.Text = "" Then
            oHolder.Visible = True
        Else
            oHolder.Visible = False
        End If
    End Sub
    Public Sub toCenter(ByVal height As Integer, ByVal width As Integer, ByVal PanelHolder As Panel)
        Dim top As Integer
        Dim left As Integer
        top = (height / 2) - (PanelHolder.Height / 2)
        left = (width / 2) - (PanelHolder.Width / 2)
        PanelHolder.Top = top
        PanelHolder.Left = left
    End Sub
End Module
