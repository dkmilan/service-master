@ECHO off 
cls 
color 0A 
ECHO        Internet Information Service 服务关闭器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

sc config iisadmin start= demand
sc config w3svc start= demand
sc config smtpsvc start= demand
net stop iisadmin /y
net stop w3svc

pause
ECHO ========================================================== 