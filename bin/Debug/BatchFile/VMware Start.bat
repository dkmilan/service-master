@ECHO off 
cls 
color 0A 
ECHO        VMware Net Service ����������
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

net start vmnetdhcp
net start "vmware nat service"

pause
ECHO ========================================================== 