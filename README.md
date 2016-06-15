# amis
This is a software development application made for our capstone project
Proposed and developed by Marlo, Isagani, Jeffrey, and Romerey

Functions involved in the data are the following:
-------------------------------------------------
This will open form fully maximize inside an mdi container
openFull([FORMNAME to Open])
-------------------------------------------------


Function below are the auto generates sql for insert,update and delete
itemNew(TableName As String, 
        arrTableColumn As String(), 
        arrTextBox As Object(), 
        [Optional] ObjListDisplay As Object)
        
[optional] ObjListDisplay if not nothing will auto refresh an object listview
in line with (sqlRefresh) for autoquery sql is needed

e.g.
sqlRefresh="SQL REFRESH STATEMENT"
itemNew(TableName As String, 
        arrTableColumn As String(), 
        arrTextBox As Object(), 
        [Optional] ObjListDisplay As Object)
