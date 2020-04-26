@echo off
title MC-JE:PE (C)2020 Games_Crack Report bugs to My Github Project

:ASCIIart
color 0E
:::     License For MC-JE:PE (This Programm or software)
:::                       MIT License
::: 
:::           "Minecraft" is a trademark of Mojang Synergies AB
:::
:::   *                                     (                                                     
::: (  `       (                            )\ )                                                  
::: )\))(      )\            (    (        (()/(   (                                              
:::((_)()\   (((_)   ___     )\   )\        /(_))  )\                                             
:::(_()((_)  )\___  |___|   ((_) ((_)   _  (_))   ((_)                                            
:::|  \/  | ((/ __|        _ | | | __| (_) | _ \  | __|                                           
:::| |\/| |  | (__        | || | | _|   _  |  _/  | _|                                            
:::|_|  |_|   \___|        \__/  |___| (_) |_|    |___|                                           
:::                                                                                               
:::                                                                                               
:::   (             (                                              (                           )  
::: ( )\   (        )\ )        )      )       (                   )\    (        )         ( /(  
::: )((_)  )\ )    (()/(     ( /(     (       ))\   (            (((_)   )(    ( /(    (    )\()) 
:::((_)_  (()/(     /(_))_   )(_))    )\  '  /((_)  )\           )\___  (()\   )(_))   )\  ((_)\  
::: | _ )  )(_))   (_)) __| ((_)_   _((_))  (_))   ((_)         ((/ __|  ((_) ((_)_   ((_) | |(_) 
::: | _ \ | || |     | (_ | / _` | | '  \() / -_)  (_-<          | (__  | '_| / _` | / _|  | / /  
::: |___/  \_, |      \___| \__,_| |_|_|_|  \___|  /__/  _____    \___| |_|   \__,_| \__|  |_\_\  
:::        |__/                                         |_____|                                   
:::
for /f "delims=: tokens=*" %%A in ('findstr /b ::: "%~f0"') do @echo(%%A
if exist %cd%\bin\Minecraft.exe goto start
echo.
echo.
echo Version 1.0.5.9 Report Buggs to Games_Crack
echo it seems like you run this for the first time or you deleted "%cd%\bin\Minecraft.exe"
echo i will create the directory for you but you have to download the Minecraft.exe file not the Minecraft.msi
echo and copy it into "%cd%\bin\" 
echo i cant do it for you because of the minecraft license 
mkdir "%cd%\appdata\roaming\" >nul
mkdir "%cd%\appdata\local\" >nul
mkdir "%cd%\appdata\locallow\" >nul
mkdir "%cd%\bin\" >nul
echo i will open an explorer and a webstie for you to install
echo after you pressed a button the programm will restart
start explorer .\bin\
start https://www.minecraft.net/en-us/download/alternative/
pause 
echo delete me if you want to reinstall >instaled.txt
:start
setlocal
set "USERPROFILE=%cd%"
set "APPDATA=%cd%\appdata\roaming\"
start %cd%\bin\Minecraft.exe --workDir:"%cd%\data\.minecraft\"
endlocal
echo im displaying the help even if all was right!
echo job done! Have Fun In Minecraft
echo you can close now
powershell -command Start-Sleep -Seconds 60
title
exit /b