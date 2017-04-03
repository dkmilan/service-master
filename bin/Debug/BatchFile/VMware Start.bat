@ECHO off 
cls 
color 0A 
ECHO        VMware Net Service 服务启动器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

net start vmnetdhcp
net start "vmware nat service"

pause
ECHO ========================================================== 