@ECHO off 
cls 
color 0A 
ECHO        ����˹�� ����ʼ����
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

sc config klnagent start= auto
sc config avp start= auto
net start klnagent
net start avp
pause
ECHO ========================================================== 
