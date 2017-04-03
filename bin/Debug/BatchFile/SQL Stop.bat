@ECHO off 
cls 
color 0A 
ECHO        SQL Server 2005 Express Edition 服务关闭器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

sc config MSSQL$SQLEXPRESS start= demand
sc config SQLWriter start= demand
net stop MSSQL$SQLEXPRESS
net stop SQLWriter

pause
ECHO ========================================================== 