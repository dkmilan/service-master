@ECHO off 
cls 
color 0A 
ECHO        VMware Net Service ����ر�
ECHO ========================================================== 
pause
ECHO ���������У����Եȡ����������� 

net stop vmnetdhcp
net stop "vmware nat service"

pause
ECHO ========================================================== 