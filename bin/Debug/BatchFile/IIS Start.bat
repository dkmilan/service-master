@ECHO off 
cls 
color 0A 
ECHO        Internet Information Service 服务启动器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

net start iisadmin
net start smtpsvc
net start w3svc

pause
ECHO ========================================================== 