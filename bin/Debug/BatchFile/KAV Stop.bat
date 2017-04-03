@ECHO off 
cls 
color 0A 
ECHO                  停止卡巴斯基服务
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 
sc config klnagent start= demand
sc config avp start= demand
net stop klnagent
net stop avp
pause
ECHO ========================================================== 
