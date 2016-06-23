Public Class fMainForm
    Public loading As Boolean = False
    Dim status As String
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
        hideError(erTextboxUser)
        hideError(erTextboxPass)
        If tUsername.Text = vbNullString AndAlso tPassword.Text = vbNullString Then
            showError(erTextboxUser)
            showError(erTextboxPass)
            tUsername.Focus()
        ElseIf (tUsername.Text = vbNullString AndAlso tPassword.Text IsNot vbNullString) Then
            showError(erTextboxUser)
            tUsername.Focus()
        ElseIf (tUsername.Text IsNot vbNullString AndAlso tPassword.Text = vbNullString) Then
            showError(erTextboxPass)
            tPassword.Focus()
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
                Dim fmain As New frmMain(txtFunction.Text)
                fmain.Show()
                Me.Hide()
                Exit Select
            Case Is = "Manager"
                PictureBox2.Visible = False
                Dim fmain As New frmMain(txtFunction.Text)
                fmain.Show()
                Me.Hide()
                Exit Select
            Case Is = "Cashier"
                PictureBox2.Visible = False
                Dim pos As New frmSales()
                pos.Show()
                Me.Hide()

                Exit Select
                Case Else
                    PictureBox2.Visible = False
                    MetroLabel1.Visible = True
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
        SqlRefresh = "SELECT Function,empid,username,password,count(empid)countUser FROM `Users` WHERE  Username like @0 and  Password like @1"
        ErrMessageText = "Incorrect username and password"

        SqlReFill("Users", Nothing, "ShowValueInTextbox", {"0", "1"}, {tUsername, tPassword}, {fnc})
        'If ds.Tables("Users").Rows(0).Item("countUser").ToString = 0 Then

        'End If
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

End Class
