@ECHO off 
cls 
color 0A 
ECHO        SQL Server 2005 Express Edition 服务启动器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

net start MSSQL$SQLEXPRESS
net start SQLWriter

pause
ECHO ========================================================== 