Imports MySql.Data.MySqlClient

Module SQLQuery
    Public arrValues As String()
    Dim strValue As String
    Public objForm As Form
    Public objFormUpdateNew As Object
    Public strReferenceID As String           'Reference sa updates
    Public strReferenceColumn As String        'Reference sa updates
    Public logged As Boolean = False
    Public arrSqlLoad As String() = {}
    Public arrImage() As Byte

    Public Sub SqlFill(ByVal sql As String, ByVal dsName As String, ByVal lvObj As Object)
        'para mas dali maquery no matter many rows or columns in a signle query this script will display
        ConnDB()
        lvObj.Items.Clear()
        cmd = New MySqlCommand
        da = New MySqlDataAdapter
        ds = New DataSet()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = sql
        da.SelectCommand = cmd
        da.Fill(ds, dsName)
        Dim lv As ListViewItem
        For Each dsRow In ds.Tables(dsName).Rows
            lv = New ListViewItem(dsRow.Item(0).ToString)
            For i As Integer = 1 To ds.Tables(dsName).Columns.Count - 1
                lv.SubItems.Add(dsRow.Item(i).ToString)
            Next
            lvObj.Items.Add(lv)
        Next
        DisconnDB()
    End Sub
    Public Sub SqlReFill(ByVal sDSName As String, _
                         Optional ByVal objDisplay As Object = Nothing, _
                         Optional ByVal showTxtboxValue As String = Nothing, _
                         Optional ByVal parameters As String() = Nothing, _
                         Optional ByVal parameterValues As Object = Nothing, _
                         Optional ByVal txtBoxes As Object() = Nothing)
        'para mas dali maquery no matter many rows or columns in a signle query this script will display
        cmd = New MySqlCommand
        da = New MySqlDataAdapter
        ds = New DataSet()
        cmd.Connection = conn
        cmd.CommandType = CommandType.Text
        cmd.CommandText = SqlRefresh
        'objDisplay.Items.Clear()
        If StatusSet = "Search" Then
            Dim i As Integer = 0
            For Each param In parameters
                cmd.Parameters.AddWithValue("@" & param, "%" & parameterValues(i).Text & "%")
                i += 1
            Next
            ' MessageBox.Show(SqlRefresh)
            '  da.SelectCommand = cmd
            '  Try
            '  da.Fill(ds, sDSName)
            '  For Each r In ds.Tables(sDSName).Rows
            ' txtBoxes(0).Items.Add(r)
            '' Next
            ' Catch ex As Exception
            ' MessageBox.Show("Unablet to add to combobox " & ex.Message.ToString)
            ' End Try
            ' End
        End If
        If showTxtboxValue = Nothing Then ' to display only to all listview objects
            da.SelectCommand = cmd
            Try
                da.Fill(ds, sDSName)
                Dim lv As ListViewItem

                For Each dsRow In ds.Tables(sDSName).Rows
                    lv = New ListViewItem(dsRow.Item(0).ToString)
                    For i As Integer = 1 To ds.Tables(sDSName).Columns.Count - 1
                        lv.SubItems.Add(dsRow.Item(i).ToString)
                    Next
                    objDisplay.Items.Add(lv)
                Next

            Catch ex As Exception
                MessageBox.Show("Context Refill Error on sqlqueries " & ex.Message, " Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf (showTxtboxValue = "ShowValueInTextbox") Then 'to display only to txtboxes for updates
            Try
                Dim i As Integer = 0
                For Each param In parameters
                    cmd.Parameters.AddWithValue("@" & param, parameterValues(i).Text)
                    i += 1
                Next
                da.SelectCommand = cmd
                da.Fill(ds, sDSName)
                i = 0
                For Each txt In txtBoxes
                    Dim ctrl As Control = txt
                    If TypeOf (ctrl) Is PictureBox Then
                        arrImage = ds.Tables(sDSName).Rows(0).Item(i)
                        If arrImage.Length = 0 Then
                            MessageBox.Show("Empty Image")
                        Else
                            Dim mstream As New System.IO.MemoryStream(arrImage)
                            txt.Image = Image.FromStream(mstream)
                        End If

                    Else
                        txt.Text = ds.Tables(sDSName).Rows(0).Item(i).ToString
                    End If

                    i += 1
                Next
                i = 0

            Catch ex As Exception
                MessageBox.Show("Error on retreiving values on sqlRefill " & ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        ElseIf (showTxtboxValue = "ShowValueInComboBox") Then
            da.SelectCommand = cmd
            da.Fill(ds, sDSName)
            For Each row In ds.Tables(sDSName).Rows
                objDisplay.items.add(row.Item(0).ToString)
            Next
        End If
        showTxtboxValue = Nothing
    End Sub
    Public Sub SqlLoad(ByVal sql As String, ByVal dsName As String, ByVal param As String, Optional ByVal txtParam As Object = Nothing)
        'sql = "SELECT * FROM STAFF WHERE StaffID = '" & frmStaff.ListView1.FocusedItem.Text & "'"
        Try
            ConnDB()
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd = New MySqlCommand(sql, conn)
            cmd.Parameters.AddWithValue("@" & param, txtParam)
            da.SelectCommand = cmd
            da.Fill(ds, dsName)
            Dim i As Integer = 0
            MessageBox.Show(ds.Tables(dsName).Rows.Count.ToString)
            DisconnDB()
        Catch ex As Exception
            MessageBox.Show("Unable to establish connection " & ex.Message, "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            DisconnDB()
        End Try
    End Sub

    Public Sub SqlAdd(ByVal Sql As String, Optional ByVal DataSetName As String = Nothing, Optional ByVal ObjListDisplay As Object = Nothing, Optional ByVal arrTextBox As Object() = Nothing)
        Try
            ConnDB()
            cmd = New MySqlCommand(Sql, conn)
            Dim p As Integer = 0
            For Each txtBox In arrTextBox
                Dim ctrl As Control = txtBox
                If TypeOf (ctrl) Is PictureBox Then ' this initiate picture saving
                    'MessageBox.Show("Picture Initiated")
                    Dim mstream As New System.IO.MemoryStream()
                    txtBox.BackgroundImage.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                    arrImage = mstream.GetBuffer()
                    cmd.Parameters.AddWithValue("@" & p.ToString, arrImage)

                ElseIf (TypeOf (ctrl) Is CheckBox) Then
                    If txtBox.checked = True Then
                        cmd.Parameters.AddWithValue("@" & p.ToString, "Available")
                    Else
                        cmd.Parameters.AddWithValue("@" & p.ToString, "OutOfStock")
                    End If
                Else
                    cmd.Parameters.AddWithValue("@" & p.ToString, txtBox.Text)
                End If
                p += 1
            Next
            cmd.ExecuteNonQuery()
            ObjListDisplay.Items.Clear()
            SqlReFill(DataSetName, ObjListDisplay)
            MsgBox("New staff successfully added.", MsgBoxStyle.Information, "Add Staff")
        Catch ex As Exception
            MessageBox.Show("Unable to add Values " & ex.Message.ToString & " " & ex.GetType.ToString, "Error")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SqlUpdate(ByVal strSql As String, ByRef ObjListDisplay As Object, ByVal DSName As String, arrTextBox As Object())
        Try
            ConnDB()
            cmd = New MySqlCommand(strSql, conn)
            Dim p As Integer = 0
            For Each txtBox In arrTextBox
                Dim ctrl As Control = txtBox
                If TypeOf (ctrl) Is PictureBox Then
                    ' this initiate picture saving some script are located at openImage() Repaired updated image and stock image
                    cmd.Parameters.AddWithValue("@" & p.ToString, arrImage)
                Else
                    cmd.Parameters.AddWithValue("@" & p.ToString, txtBox.Text)
                End If
                p += 1
            Next
            cmd.Parameters.AddWithValue("@ref", strReferenceID)
            cmd.ExecuteNonQuery()
            ObjListDisplay.Items.Clear()
            SqlReFill(DSName, ObjListDisplay)
            MsgBox("Staff record successfully updated", MsgBoxStyle.Information, "Update Staff")
        Catch ex As Exception
            MessageBox.Show("SqlUpdate as error " & ex.Message.ToString, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SqlUpdateNew(ByVal DatasetName As String, ByRef ObjListDisplay As Object, ByVal arrTableColumn As String(), ByVal arrTextBox As Object())
        Select Case StatusSet
            Case "Update"
                sqL = "Update " & DatasetName & " Set "
                Dim i As Integer = 0
                For Each arrCol In arrTableColumn
                    sqL &= arrCol & "=@" & i & ","
                    i += 1
                Next
                sqL = sqL.Remove(sqL.Length - 1)
                sqL &= " Where " & strReferenceColumn & " = @ref"

                SqlUpdate(sqL, ObjListDisplay, DatasetName, arrTextBox)
                StatusSet = ""
            Case "New"
                ' ClearTextBoxes(objFormUpdateNew)
                Dim strSql = "INSERT INTO " & DatasetName & "("
                For Each arrCol In arrTableColumn
                    strSql &= arrCol & ","
                Next
                strSql = strSql.Remove(strSql.Length - 1)
                strSql &= ") values("
                Dim p As Integer = 0
                For Each txt In arrTextBox
                    strSql &= "@" & p.ToString & ","
                    p += 1
                Next
                strSql = strSql.Remove(strSql.Length - 1)
                strSql &= ")"
                SqlAdd(strSql, DatasetName, ObjListDisplay, arrTextBox)
                StatusSet = ""
            Case Else
                MessageBox.Show("Setting up status was not set, Please report to administrator", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub

End Module
