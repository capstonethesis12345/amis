# amis
This is a software development application made for our capstone project
Proposed and developed by Marlo, Isagani, Jeffrey, and Romerey

Functions involved in the data are the following:
-------------------------------------------------

openFull([FORMNAME to Open])
-------------------------------------------------
This will open form fully maximize inside an mdi container



------------------------------------------------
itemNew([TableStringName], [arrStringTableColumn], [arrOBJECTTextBox] , [Optional ObjListDisplay])
-----------------------------------------------
[optional] ObjListDisplay if not nothing will auto refresh an object listview
in line with (sqlRefresh) for autoquery sql is needed

e.g.
sqlRefresh="SQL REFRESH STATEMENT"
itemNew(TableName As String, 
        arrTableColumn As String(), 
        arrTextBox As Object(), 
        [Optional] ObjListDisplay As Object)
        
-----------------------------------------------------
getIDFunction([sqlstr with @ parameters], [strDSname], [arrStrParameterValue], [Optional spBoolean])
-------------------------------------
this getidFunction will only returns a single values
mostly used to get ID's.
