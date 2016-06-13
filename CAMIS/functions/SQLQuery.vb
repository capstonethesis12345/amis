Imports MySql.Data.MySqlClient

Module SQLQuery
    Public arrValues As String()
    Dim strValue As String
    Public objForm As Form
    Public objFormUpdateNew As Object
    Public strReferenceValue As String           'Reference sa updates
    Public strReferenceColumn As String        'Reference sa updates
    Public logged As Boolean = False
    Public arrSqlLoad As String() = {}
    Public arrImage() As Byte
    Public err As Boolean = False
    Public msgShow As Boolean = True
    Public pageMax As Integer = 5
    Public ErrMessageText As String = ""

    Public Sub SqlFill(ByVal sql As String, ByVal dsName As String, Optional ByVal lvObj As Object = Nothing, Optional autoComplete As Object = Nothing)
        'para mas dali maquery no matter many rows or columns in a signle query this script will display
        Try
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
            'Dim lv As ListViewItem
            'For Each dsRow In ds.Tables(dsName).Rows
            ' lv = New ListViewItem(dsRow.Item(0).ToString)
            ' For i As Integer = 1 To ds.Tables(dsName).Columns.Count - 1
            ' lv.SubItems.Add(dsRow.Item(i).ToString)
            ' Next
            'lvObj.Items.Add(lv)   System.Windows.Forms.Label
            'Dim ctrl As  = lvObj
            If TypeOf (lvObj) Is System.Windows.Forms.ComboBox Then
                For Each dsRow In ds.Tables(dsName).Rows
                    lvObj.Items.Add(dsRow.Item(0).ToString)
                Next
                'MessageBox.Show("Control")
                ' ElseIf TypeOf (lvObj) Is System.Windows.Forms.Label Then
                ' For Each dsrow In ds.Tables(dsName).Rows
                ' lvObj.text = dsrow.text
                ' Next
                '    MessageBox.Show("Label")
            ElseIf (TypeOf (lvObj) Is System.Windows.Forms.DataGridView) Then
                MessageBox.Show("Inserting value on datagrid view")
            End If
            If autoComplete IsNot Nothing Then
                For Each dsRow In ds.Tables(dsName).Rows
                    autoComplete.AutoCompleteCustomSource.Add(dsRow.Item(0).ToString)
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString)
        Finally
            DisconnDB()
        End Try

        'Next

    End Sub
    Public Sub Trigger(ByVal sql As String)
        Try
            ConnDB()
            da = New MySqlDataAdapter
            cmd.Connection = conn
            cmd.CommandType = CommandType.Text
            cmd.CommandText = sql
            cmd.ExecuteNonQuery()

        Catch ex As Exception
            MessageBox.Show("Sql statement was incorrect format")
        Finally
            DisconnDB()
        End Try
    End Sub
    Public Sub SqlReFill(ByVal sDSName As String,
                         Optional ByVal objDisplay As Object = Nothing,
                         Optional ByVal showTxtboxValue As String = Nothing,
                         Optional ByVal parameters As String() = Nothing,
                         Optional ByVal parameterValues As Object = Nothing,
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
            Dim s As Integer = 0
            For Each param In parameters
                cmd.Parameters.AddWithValue("@" & param, parameterValues(s).Text & "%")
                s += 1
            Next

            s = 0
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
                objDisplay.items.clear()
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
                'MessageBox.Show("Error on retreiving values on sqlRefill " & ex.Message.ToString, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

                MessageBox.Show(ErrMessageText)
                ErrMessageText = ""
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


    Function getID(ByVal sql As String, ByVal dsname As String, Optional ByVal sp As Boolean = Nothing)
        Dim id As Integer = "1"
        Try
            ConnDB()
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds, dsname)
            'MessageBox.Show(ds.Tables(dsname).Rows.Count.ToString)
            ' If ds.Tables(dsname).Rows.Count > 0 Then
            ' MessageBox.Show(ds.Tables(0).Rows.Count.ToString)
            ' End If
            If (sp = Nothing) Then
                If ds.Tables(dsname).Rows(0).Item(0).ToString = "" Then
                    id = 1
                ElseIf (ds.Tables(dsname).Rows(0).Item(0).ToString = 1) Then
                    id = id + 1
                Else
                    id = ds.Tables(dsname).Rows(0).Item(0) + 1
                End If
            Else
                If IsDBNull(ds.Tables(dsname).Rows(0).Item(0)) = False Then
                    id = ds.Tables(dsname).Rows(0).Item(0)
                Else
                    id = 1
                End If

            End If

        Catch ex As Exception
            ' MessageBox.Show("Unable to retreve id")
        Finally
            DisconnDB()
        End Try
        Return id
    End Function
    Function getValue(ByVal sql As String)
        Dim id As String = ""
        Try
            ConnDB()
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd = New MySqlCommand(sql, conn)
            da.SelectCommand = cmd
            da.Fill(ds, "value")
            'MessageBox.Show(ds.Tables(dsname).Rows.Count.ToString)
            ' If ds.Tables(dsname).Rows.Count > 0 Then
            ' MessageBox.Show(ds.Tables(0).Rows.Count.ToString)
            ' End If
            id = ds.Tables(0).Rows(0).Item(0).ToString
        Catch ex As Exception
            ' MessageBox.Show("Unable to retreve id")
        Finally
            DisconnDB()
        End Try
        Return id
    End Function

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
                    cmd.Parameters.AddWithValue("@" & p.ToString, txtBox.Text)
                Else
                    Try
                        cmd.Parameters.AddWithValue("@" & p.ToString, txtBox.Text)
                    Catch ex As Exception
                        cmd.Parameters.AddWithValue("@" & p.ToString, txtBox)
                    End Try



                End If
                p += 1
            Next
            cmd.ExecuteNonQuery()
            ObjListDisplay.Items.Clear()
            If msgShow = True Then
                MessageBox.Show("Success")
            End If
            msgShow = True
            SqlReFill(DataSetName, ObjListDisplay)

        Catch ex As Exception
            If ex.GetType.ToString = "MySql.Data.MySqlClient.MySqlException" Then
                err = True
                MessageBox.Show("Duplicate id and name are already available.", "Excited ID,Name not allowed")

            Else
                MessageBox.Show(ex.GetType.ToString, "Error addting data")
            End If
            'MessageBox.Show("Unable to add Values " & ex.Message.ToString & " --" & ex.GetType.ToString & "--", "Error")
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
                'MessageBox.Show((TypeOf txtBox Is String).ToString)
                If TypeOf (ctrl) Is PictureBox Then
                    ' this initiate picture saving some script are located at openImage() Repaired updated image and stock image
                    cmd.Parameters.AddWithValue("@" & p.ToString, arrImage)
                Else
                    cmd.Parameters.AddWithValue("@" & p.ToString, txtBox.Text)
                End If
                p += 1
            Next
            cmd.Parameters.AddWithValue("@ref", strReferenceValue)
            cmd.ExecuteNonQuery()
            ObjListDisplay.Items.Clear()
            SqlReFill(DSName, ObjListDisplay)
            If msgShow = True Then
                MessageBox.Show("Success")
            End If
            msgShow = True
            'MsgBox("Staff record successfully updated", MsgBoxStyle.Information, "Update Staff")
        Catch ex As Exception
            MessageBox.Show("SqlUpdate as error " & ex.Message.ToString, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SqlUpdateNew(ByVal DatasetName As String, ByRef ObjListDisplay As Object, ByVal arrTableColumn As String(), ByVal arrTextBox As Object())
        ' ObjListDisplay.items.clear()
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
            Case "Delete"
                Dim i As Integer = 0
                For Each arrCol In arrTableColumn
                    sqL = "DELETE FROM " & DatasetName & " WHERE " &
                        arrCol & "=@" & i.ToString
                    'SqlUpdate(sqL, ObjListDisplay, DatasetName, arrTextBox)
                    'Try
                    ' ConnDB()
                    ' cmd = New MySqlCommand(sqL, conn)
                    ' cmd.Parameters.AddWithValue("@" & arrCol, arrTextBox(i).text)
                    ' cmd.ExecuteNonQuery()
                    ' MessageBox.Show("Purchase canceled")
                    ' Catch ex As Exception
                    ' MessageBox.Show("Error update")
                    ' Finally
                    'DisconnDB()
                    'End Try
                    Try
                        ConnDB()
                        cmd = New MySqlCommand(sqL, conn)

                        cmd.Parameters.AddWithValue("@" & i.ToString, arrTextBox(i).Text)


                        cmd.ExecuteNonQuery()

                    Catch ex As Exception
                        MessageBox.Show("Error")
                    Finally
                        DisconnDB()
                    End Try

                    i += 1
                Next
                ' MessageBox.Show("Cancelled Success.")
                ' MessageBox.Show(sqL)
                StatusSet = ""
            Case Else
                MessageBox.Show("Setting up status was not set, Please report to administrator", "Program error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Select
    End Sub
    'adding pages
    Public Function pageData(ByVal qryCount As String, ByVal objCombo As ComboBox, ByVal rowCountHolder As Integer)
        Dim page As Integer = 1
        Try
            ConnDB()
            'count rows
            cmd = New MySqlCommand(qryCount, conn)
            Dim RowCount As Integer = cmd.ExecuteScalar()
            rowCountHolder = RowCount
            cmd = Nothing
            If (RowCount > pageMax) Then
                page = Int(RowCount / pageMax)
                If (RowCount Mod pageMax > 0) Then
                    page += 1
                End If
            End If
            If (page > 1) Then
                For i = 1 To page
                    objCombo.Items.Add(i.ToString)
                Next
            Else
                objCombo.Items.Add(1)
            End If
        Catch ex As Exception
            MessageBox.Show("Contact system administrator check your database information,ERROR on pagedata")
        Finally
            DisconnDB()
        End Try
        Return rowCountHolder
    End Function
End Module
