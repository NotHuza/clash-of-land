echo off
echo  _________ ,__                ,__     ,____                       ,___
echo  \_   ___ \!  ! _____    _____!  !__  !    !   _____    ____    __! _/
echo  /    \  \/!  ! \__  \  /  ___/  !  \ !    !   \__  \  /    \  / __ !
echo  \     \___!  !__/ __ \_\___ \!   Y  \!    !___ / __ \!   !  \/ /_/ ! 
echo   \______  /____(____  /____  {___!  /!_______ (____  /___!  /\____ ! 
echo          \/          \/     \/     \/         \/    \/     \/      \/ 
echo.
color 0a
echo Clash Land-Restarter  
echo. 
echo Your Clash Land is being restarted, Please wait. . .
timeout /t 20
taskkill /f /im CLS_v2018.exe 
cls   
echo Success!   
echo.   
echo Your Clash Land is now starting. . . 
timeout /t 30
start CLS_v2018.exe
exit
