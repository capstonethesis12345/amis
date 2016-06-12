﻿Imports MySql.Data.MySqlClient
Imports database
Module SQLConn
    Public ServerMySQL As String
    Public PortMySQL As String
    Public UserNameMySQL As String
    Public PwdMySQL As String
    Public DBNameMySQL As String
    Public Remember As String
    Public sqL As String
    Public ds As DataSet
    Public cmd As MySqlCommand
    Public dr As MySqlDataReader
    Public da As MySqlDataAdapter
    Public conn As New MySqlConnection
    Public StatusSet As String
    Public SqlRefresh As String

    Sub getData()
        Dim AppName As String = Application.ProductName
        Try
            DBNameMySQL = GetSetting(AppName, "DBSection", "DB_Name", "temp")
            ServerMySQL = GetSetting(AppName, "DBSection", "DB_IP", "temp")
            PortMySQL = GetSetting(AppName, "DBSection", "DB_Port", "temp")
            UserNameMySQL = GetSetting(AppName, "DBSection", "DB_User", "temp")
            PwdMySQL = GetSetting(AppName, "DBSection", "DB_Password", "temp")
            Remember = GetSetting(AppName, "DBSection", "LogUser", "temp")
            conn.ConnectionString = "server=" & ServerMySQL & ";port=" & PortMySQL & ";database=" & DBNameMySQL & ";uid=" & UserNameMySQL & ";pwd=" & PwdMySQL
        Catch ex As Exception
            MsgBox("System registry was not established, you can set/save " &
            "these settings by pressing F1", MsgBoxStyle.Information)
        End Try
    End Sub
    Public Sub ConnDB()
        Try
            conn.Open()
        Catch ex As Exception
            MsgBox("The system failed to establish a connection", MsgBoxStyle.Information, "Database Settings")
        End Try
    End Sub
    Public Sub CheckConnection()
        Try
            conn.Open()
            conn.Dispose()
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve database please contact system administrator")
        End Try
    End Sub
    Public Sub DisconnDB()
        conn.Close()
        conn.Dispose()
    End Sub
    Sub SaveData()
        Dim AppName As String = Application.ProductName
        SaveSetting(AppName, "DBSection", "DB_Name", DBNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_IP", ServerMySQL)
        SaveSetting(AppName, "DBSection", "DB_Port", PortMySQL)
        SaveSetting(AppName, "DBSection", "DB_User", UserNameMySQL)
        SaveSetting(AppName, "DBSection", "DB_Password", PwdMySQL)
        MsgBox("Database connection settings are saved.", MsgBoxStyle.Information)
    End Sub
    'option for database generator
    Dim process As Integer = 0
    Sub generateDB(ByVal appname As String, ByVal user As String, ByVal pass As String)

        Dim x As New createDB(appname, user, pass)
        Dim y As String()
        y = x.createDB()
        Dim len As Integer = y.Count - 1
        'MessageBox.Show(len.ToString)
        Dim i As Integer = 0
        Dim progress As Integer = 100 / (len - 1)
        For Each dataY In y
            Try
                ConnDB()
                cmd = New MySqlCommand(dataY, conn)
                cmd.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Unable to generate database in prograss #" & i.ToString, "Connection not establish")
            Finally
                DisconnDB()
            End Try
            frmDatabase.ProgressBar1.Value += process
            i += 1
        Next
        frmDatabase.ProgressBar1.Value = 100
        MessageBox.Show("Database created successfully")
    End Sub
End Module

