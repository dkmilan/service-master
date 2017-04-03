@ECHO off 
cls 
color 0A 
ECHO        卡巴斯基 服务开始工具
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

sc config klnagent start= auto
sc config avp start= auto
net start klnagent
net start avp
pause
ECHO ========================================================== 
