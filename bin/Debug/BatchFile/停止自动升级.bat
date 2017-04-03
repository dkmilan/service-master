@ECHO off 
cls 
color 0A 
ECHO        Windows Update 服务关闭器
ECHO ========================================================== 
pause
ECHO 程序运行中，请稍等。。。。。。 

sc config wuauserv start= demand
sc config BITS start= demand
net stop wuauserv
net stop BITS
pause
ECHO ========================================================== 
