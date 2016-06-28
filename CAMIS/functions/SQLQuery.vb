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
    Public d As Date = Date.Today
    Public todate As String = d.ToString("yyyy-MM-dd")
    Public vEmp As String
    Public vUser As String

    Public Sub itemAutoComplete(ByVal DataSetName As String, ByVal objAutoCompleteTextBox As Object)
        Try

            ConnDB()
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd = New MySqlCommand(SqlRefresh, conn)
            da.SelectCommand = cmd
            da.Fill(ds, DataSetName)
            For Each dsRow In ds.Tables(DataSetName).Rows
                objAutoCompleteTextBox.AutoCompleteCustomSource.Add(dsRow.Item(0).ToString)
            Next
        Catch ex As Exception
            MessageBox.Show("Unable to set autocomplete")
        Finally
            DisconnDB()
        End Try
    End Sub
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
                        'MessageBox.Show(arrImage.Count.ToString)
                        If arrImage.Count = 0 Then

                            txt.Image = My.Resources.empty_profile11
                            msgShow = True
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
                If msgShow = True Then
                    MessageBox.Show(ErrMessageText)
                    ErrMessageText = ""
                    msgShow = True
                End If
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
    Function getStrData(ByVal sql As String, ByVal dsname As String, Optional ByVal parameterValue As String() = Nothing, Optional isSalesID As Boolean = Nothing)

        Dim id As String = ""
        Try
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd.CommandType = CommandType.Text

            If parameterValue IsNot Nothing Then
                Dim i As Integer = 0
                For Each param In parameterValue
                    cmd.Parameters.AddWithValue("@" & i.ToString, parameterValue(i))
                    i += 1
                Next
            End If
            da.SelectCommand = cmd
            da.Fill(ds, dsname)
            'count total columns'

            id = ds.Tables(dsname).Rows(0).Item(0).ToString

            ' MessageBox.Show(ds.Tables(0).Rows.Count.ToString)
            ' End If
            ' id = ds.Tables(dsname).Rows(0).Item(0).ToString
        Catch ex As Exception
            ' MessageBox.Show("Unable to retreve id")
            If msgShow = True Then
                MessageBox.Show("Error on getting ID :" & ex.Message.ToString, "Waring notice")
            End If
        Finally
            DisconnDB()
        End Try
        Return id
    End Function

    Function getIDFunction(ByVal sql As String, ByVal dsname As String, Optional ByVal parameterValue As String() = Nothing, Optional isSalesID As Boolean = Nothing)

        Dim id As Integer
        Try
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd.CommandType = CommandType.Text

            If parameterValue IsNot Nothing Then
                Dim i As Integer = 0
                For Each param In parameterValue
                    cmd.Parameters.AddWithValue("@" & i.ToString, parameterValue(i))
                    i += 1
                Next
            End If
            da.SelectCommand = cmd
            da.Fill(ds, dsname)

            id = ds.Tables(dsname).Rows(0).Item(0).ToString

            ' MessageBox.Show(ds.Tables(0).Rows.Count.ToString)
            ' End If
            ' id = ds.Tables(dsname).Rows(0).Item(0).ToString
        Catch ex As Exception
            ' MessageBox.Show("Unable to retreve id")
            If msgShow = True Then
                MessageBox.Show("Error on getting ID :" & ex.Message.ToString & vbNullString & ErrMessageText, "Waring notice")
            End If
        Finally
            DisconnDB()
        End Try
        Return id
    End Function
    Function getValue(ByVal sql As String, ByVal dsname As String, Optional ByVal parameterValue As String() = Nothing, Optional isSalesID As Boolean = Nothing)
        Dim id As String
        Try
            ConnDB()
            cmd = New MySqlCommand(sql, conn)
            da = New MySqlDataAdapter
            ds = New DataSet()
            cmd.CommandType = CommandType.Text

            If parameterValue IsNot Nothing Then
                Dim i As Integer = 0
                For Each param In parameterValue
                    cmd.Parameters.AddWithValue("@" & i.ToString, parameterValue(i))
                    i += 1
                Next
            End If
            da.SelectCommand = cmd
            da.Fill(ds, dsname)

            id = ds.Tables(dsname).Rows(0).Item(0).ToString

            ' MessageBox.Show(ds.Tables(0).Rows.Count.ToString)
            ' End If
            ' id = ds.Tables(dsname).Rows(0).Item(0).ToString
        Catch ex As Exception
            ' MessageBox.Show("Unable to retreve id")
            If msgShow = True Then
                MessageBox.Show("Error on getting ID :" & ex.Message.ToString, "Waring notice")
            End If
        Finally
            DisconnDB()
        End Try
        Return id
    End Function

    Public Sub SqlAdd(ByVal Sql As String, Optional ByVal arrTextBox As Object() = Nothing)
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

            'ObjListDisplay.Items.Clear()

            If msgShow = True Then
                MessageBox.Show("Success")
            End If
            msgShow = True

            'SqlReFill(DataSetName, ObjListDisplay)

        Catch ex As Exception
            If msgShow = True Then


                If ex.GetType.ToString = "MySql.Data.MySqlClient.MySqlException" Then
                    err = True
                    MessageBox.Show("Duplicate id and name are already available." & ErrMessageText, "Excited ID,Name not allowed")

                Else
                    MessageBox.Show(ex.GetType.ToString, "Error addting data")
                End If
                ErrMessageText = ""
            End If
            'MessageBox.Show("Unable to add Values " & ex.Message.ToString & " --" & ex.GetType.ToString & "--", "Error")
        Finally
            cmd.Dispose()
            conn.Close()
        End Try
    End Sub

    Public Sub SqlUpdate(ByVal strSql As String, ByVal DSName As String, arrTextBox As Object(), ByVal referenceValue As String)
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
            cmd.Parameters.AddWithValue("@ref", referenceValue)
            cmd.ExecuteNonQuery()
            'ObjListDisplay.Items.Clear()
            'SqlReFill(DSName, ObjListDisplay)
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


    Public Sub itemUpdate(ByVal TableName As String, ByVal arrTableColumn As String(), ByVal arrObjects As Object(), ByVal ColumnReference As String, ByVal referenceValue As String, Optional ByVal ObjListDisplay As Object = Nothing)
        sqL = "Update " & TableName & " Set "
        Dim i As Integer = 0
        For Each arrCol In arrTableColumn
            sqL &= arrCol & "=@" & i & ","
            i += 1
        Next
        sqL = sqL.Remove(sqL.Length - 1)
        sqL &= " Where " & ColumnReference & " = @ref"

        SqlUpdate(sqL, TableName, arrObjects, referenceValue)
        If ObjListDisplay IsNot Nothing Then
            'ObjListDisplay.clear()
            SqlReFill(TableName, ObjListDisplay)
        End If

    End Sub
    Public Sub itemNew(ByVal TableName As String, ByVal arrTableColumn As String(), ByVal arrTextBox As Object(), Optional ByVal ObjListDisplay As Object = Nothing)
        ' ClearTextBoxes(objFormUpdateNew)
        Dim strSql = "INSERT INTO " & TableName & "("
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
        SqlAdd(strSql, arrTextBox)
        If ObjListDisplay IsNot Nothing Then
            'ObjListDisplay.clear()
            SqlReFill(TableName, ObjListDisplay)
        End If

        ' StatusSet = ""
    End Sub

    Public Sub itemDelete(ByVal TableName As String, ByVal arrTableColumn As String(), ByVal arrTextBox As Object())
        Dim i As Integer = 0
        For Each arrCol In arrTableColumn
            sqL = "DELETE FROM " & TableName & " WHERE " &
                arrCol & "=@" & i.ToString
            Try
                ConnDB()
                cmd = New MySqlCommand(sqL, conn)
                cmd.Parameters.AddWithValue("@" & i.ToString, arrTextBox(i).Text)
                cmd.ExecuteNonQuery()
                MessageBox.Show("Success user deleted")
            Catch ex As Exception
                MessageBox.Show("Error")
            Finally
                DisconnDB()
            End Try

            i += 1
        Next
    End Sub
    Public Sub SqlUpdateNew(ByVal DatasetName As String, ByRef ObjListDisplay As Object, ByVal arrTableColumn As String(), ByVal arrTextBox As Object())
        ' ObjListDisplay.items.clear()
        Select Case StatusSet
            Case "Update"

            Case "New"

            Case "Delete"

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
