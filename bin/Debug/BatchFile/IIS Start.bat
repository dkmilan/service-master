@ECHO off 
cls 
color 0A 
ECHO        Internet Information Service ����������
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

net start iisadmin
net start smtpsvc
net start w3svc

pause
ECHO ========================================================== 