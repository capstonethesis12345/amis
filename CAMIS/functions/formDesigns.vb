Module formDesigns

    Function formMain(ByVal MainForm As Object)
        MainForm.IsMdiContainer = True
        'MainForm.MdiParent = MainForm
        Return 0
    End Function
    Sub openFull(ByRef objForm As Form)
        With objForm
            ' . = True
            .MdiParent = frmMain
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
End Module
