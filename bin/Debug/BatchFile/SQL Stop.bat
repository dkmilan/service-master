@ECHO off 
cls 
color 0A 
ECHO        SQL Server 2005 Express Edition ����ر���
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

sc config MSSQL$SQLEXPRESS start= demand
sc config SQLWriter start= demand
net stop MSSQL$SQLEXPRESS
net stop SQLWriter

pause
ECHO ========================================================== 