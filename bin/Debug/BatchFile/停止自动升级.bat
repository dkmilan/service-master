@ECHO off 
cls 
color 0A 
ECHO        Windows Update ����ر���
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

sc config wuauserv start= demand
sc config BITS start= demand
net stop wuauserv
net stop BITS
pause
ECHO ========================================================== 
