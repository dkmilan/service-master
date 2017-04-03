@ECHO off 
cls 
color 0A 
ECHO        Windows Update 服务启动器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。

sc config wuauserv start= auto
sc config BITS start= auto
net start wuauserv
net start BITS

pause
ECHO ========================================================== 
