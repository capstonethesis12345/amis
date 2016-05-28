Module ProgramFunctions
    Sub clearField(ByVal objectNames As Object())
        Try
            For Each txt In objectNames
                Dim ctrl As Control = txt
                If TypeOf (ctrl) Is PictureBox Then
                    txt.Image = Nothing
                ElseIf TypeOf (ctrl) Is ComboBox Then
                    txt.Text = Nothing

                Else
                    txt.text = ""
                End If

            Next
        Catch ex As Exception
            MessageBox.Show("All textfield were empty already.")
        End Try
    End Sub
    Sub openImage(ByVal openDialog As Object, ByVal pictureBox As Object)
        Dim resizedImage As Image
        Dim strFile As String = ""
        If openDialog.ShowDialog = Windows.Forms.DialogResult.OK Then
            pictureBox.Image = Nothing
            strFile = openDialog.FileName
            pictureBox.BackgroundImage = Image.FromFile(strFile)
            Dim newSize As New Size(110, 110)
            resizedImage = New Bitmap(pictureBox.BackgroundImage, newSize)
            pictureBox.BackgroundImage = resizedImage
            pictureBox.BackgroundImageLayout = ImageLayout.Center
            pictureBox.Visible = True
            'This script is needed for update and add of images
            '----------------------------------------------------------
            Dim mstream As New System.IO.MemoryStream()
            pictureBox.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
            arrImage = mstream.GetBuffer()
            '=============================================================
        End If
    End Sub
End Module
