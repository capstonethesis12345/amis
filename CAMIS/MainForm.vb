Public Class MainForm
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
        If tUsername.Text = vbNullString AndAlso tPassword.Text = vbNullString Then
            showError(erTextbox)
        ElseIf (tUsername.Text IsNot vbNullString AndAlso tPassword.Text = vbNullString) Then

        End If
    End Sub
    Private Sub showError(ByVal errPicture As PictureBox)
        errPicture.Visible = True
    End Sub
End Class
