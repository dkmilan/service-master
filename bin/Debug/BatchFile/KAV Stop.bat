@ECHO off 
cls 
color 0A 
ECHO                  ֹͣ����˹������
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 
sc config klnagent start= demand
sc config avp start= demand
net stop klnagent
net stop avp
pause
ECHO ========================================================== 
