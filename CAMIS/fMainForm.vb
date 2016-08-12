Public Class fMainForm
    Public loading As Boolean = False

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.KeyPreview = True    'we will implement shortcut keys
    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        toCenter(Me.Height, Me.Width, Panel1)
    End Sub

    Private Sub MainForm_MaximumSizeChanged(sender As Object, e As EventArgs) Handles Me.SizeChanged
        If Panel1.Size.Width < Me.Size.Width AndAlso Panel1.Size.Height < Me.Size.Height Then
            toCenter(Me.Height, Me.Width, Panel1)
        Else
            Me.Height = Panel1.Size.Height
            Me.Width = Panel1.Size.Width
        End If

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        tUsername.Focus()

        hideError(erTextboxUser)
        hideError(erTextboxPass)
        If tUsername.Text = vbNullString AndAlso tPassword.Text = vbNullString Then
            showError(erTextboxUser)
            showError(erTextboxPass)
            tUsername.Focus()
            Exit Sub
        ElseIf (tUsername.Text = vbNullString AndAlso tPassword.Text IsNot vbNullString) Then
            showError(erTextboxUser)
            tUsername.Focus()
            Exit Sub
        ElseIf (tUsername.Text IsNot vbNullString AndAlso tPassword.Text = vbNullString) Then
            showError(erTextboxPass)
            tPassword.Focus()
            Exit Sub
        Else
            'Set user and password 
            'match inputed user and password

            PictureBox2.Visible = True

            status = logmein()

            'Dim thread1 As New System.Threading.Thread(AddressOf logulogmeinser)

            '            thread1.Start()
            '
            '           thread1.Join()

            'MessageBox.Show(vEmp)
            'If status = "Admin" Then

            'ElseIf status = "Cashier" Then
            ' PictureBox2.Visible = False
            ' Else

        End If
        Select Case status
            Case Is = "Admin"
                PictureBox2.Visible = False
                Dim fmain As New frmMain(status)
                fmain.Show()
                Me.Hide()
                Exit Select
            Case Is = "Manager"
                PictureBox2.Visible = False
                Dim fmain As New frmMain(status)
                fmain.Show()
                Me.Hide()
                Exit Select
            Case Is = "Cashier"
                PictureBox2.Visible = False
                Dim pos As New frmSalesTransaction()
                pos.Show()
                Me.Hide()
            Case Is = "Cook"
                PictureBox2.Visible = False
                'Dim ingredients As New frmFood()
                'ingredients.Show()
                'Me.Hide()
                Dim ingredients As New frmMain(status)
                ingredients.ShowDialog()
                Me.Hide()
                Exit Select
            Case Else

                PictureBox2.Visible = False
                MetroLabel1.Visible = True
                Timer1.Start()
        End Select

        'PictureBox2.Visible = True

        'If Not txtFunction.Text = vbNullString Then
        '         PictureBox2.Visible = False
        '     Dim fmain As New frmMain(txtFunction.Text)
        '  fmain.Show()
        '
        '           Me.Hide()
        '      End If
        '  End If
    End Sub

    Sub getLogUser()
        txtFunction.Text = status
    End Sub
    Private Function logmein()
        Dim fnc As New TextBox
        getData()
        SqlRefresh = "SELECT Function,empid,username,password,count(empid)countUser FROM `users` WHERE  Username like @0 and  Password like @1 group by empid"
        ErrMessageText = "Incorrect username and password"
        Timer1.Start()

        'If ds.Tables("Users").Rows(0).Item("countUser").ToString = 0 Then

        'End If
        Try
            SqlReFill("Users", Nothing, "ShowValueInTextbox", {"0", "1"}, {tUsername, tPassword}, {fnc})
            If ds.Tables.Count > 0 Then
                If ds.Tables("Users").Rows(0).Item("countUser").ToString = 1 Then
                    Dim usr As String = ds.Tables("Users").Rows(0).Item("username").ToString
                    Dim psd As String = ds.Tables("Users").Rows(0).Item("password").ToString
                    If usr = tUsername.Text And psd = tPassword.Text Then
                        vEmp = ds.Tables("Users").Rows(0).Item("empid").ToString
                        fnc.Text = ds.Tables("Users").Rows(0).Item("Function").ToString
                        vUser = ds.Tables("Users").Rows(0).Item("username").ToString
                    Else
                        fnc.Text = ""
                    End If
                End If
            End If

        Catch ex As Exception
            If Not ex.Message.ToString = "There is no row at position 0." Then
                MessageBox.Show(ex.Message.ToString)
            End If
        End Try



        Return fnc.Text
    End Function

    Private Sub showError(ByVal errPicture As PictureBox)
        errPicture.Visible = True
    End Sub
    Private Sub hideError(ByVal errPicture As PictureBox)
        errPicture.Visible = False
    End Sub

    Private Sub MainForm_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'This will result for a shortcut keys implementation
        If e.Alt And e.KeyCode = Keys.F12 Then
            frmDatabase.ShowDialog()
        ElseIf (e.Alt) And e.KeyCode = Keys.f11 Then
            frmDTRsystem.ShowDialog()
        ElseIf e.Alt And e.KeyCode = Keys.F4 Then
            Application.Exit()
        End If
    End Sub

    Private Sub txtFunction_TextChanged(sender As Object, e As EventArgs) Handles txtFunction.TextChanged
        If status = "Admin" Then
            PictureBox2.Visible = False
            Dim fmain As New frmMain(txtFunction.Text)
            fmain.Show()
            Me.Hide()
        ElseIf status = "Cashier" Then
            PictureBox2.Visible = False
        Else

        End If
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MetroLabel1.Visible = False
        Timer1.Stop()
    End Sub
End Class
