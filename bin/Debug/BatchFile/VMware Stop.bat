@ECHO off 
cls 
color 0A 
ECHO        VMware Net Service 服务关闭
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

net stop vmnetdhcp
net stop "vmware nat service"

pause
ECHO ========================================================== 