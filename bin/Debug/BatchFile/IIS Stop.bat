@ECHO off 
cls 
color 0A 
ECHO        Internet Information Service ����ر���
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

sc config iisadmin start= demand
sc config w3svc start= demand
sc config smtpsvc start= demand
net stop iisadmin /y
net stop w3svc

pause
ECHO ========================================================== 