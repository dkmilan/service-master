@ECHO off 
cls 
color 0A 
ECHO        Windows Update ����������
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ�����������

sc config wuauserv start= auto
sc config BITS start= auto
net start wuauserv
net start BITS

pause
ECHO ========================================================== 
