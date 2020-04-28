Imports System.IO
'@antivruses i am not a virus i am just an programm that launches MINECRAFT!
Module Start

    Sub Main()
        Dim ver = "2.0.0.1"
        Console.Title = $"MC-JE:PE VB Editon Ver:{ver} Made With ♥ By Games_Crack"
        echo($"MC-JE:PE VB EDITON Ver:{ver} complete rewrite")
        echo("Report buggs to ""https://github.com/Games-Crack/MCJEPE""")
        Console.CursorVisible = False
        Console.ForegroundColor = ConsoleColor.Yellow
        splash()
        Console.ForegroundColor = ConsoleColor.Red
        echo("THIS IS BETA SOFTWARE WITHOUT ANY WARRENTY")
        Dim cd = Directory.GetCurrentDirectory()
        Dim gf = cd + "\appdata\roaming"
        If Not Directory.Exists($"{gf}") Then Command("if not exist %cd%\appdata mkdir appdata\roaming && mkdir appdata\local && mkdir appdata\locallow && mkdir bin\ && mkdir appdata\roaming\.minecraft\")
        If Not File.Exists($"{cd}\bin\Minecraft.exe") Then
            'echo("the setup isnt implemented jet")
            'Throw New NotImplementedException()
            echo("Download ""Minecraft.exe"" and i will open the folder to copy it into")
            Command("start https://www.minecraft.net/en-us/download/alternative/ && start explorer.exe .\bin\")
            echo("giving you a minute to download the programm will exit after you copied into the bin folder the setup is finished")
            echo("then you can close!")
            Threading.Thread.Sleep(30000)
            End
        End If
        Environment.SetEnvironmentVariable("appdata", $"{gf}")
        Environment.SetEnvironmentVariable("localappdata", $"{cd + "\appdata\locallow\"}")
        Environment.SetEnvironmentVariable("USERPROFILE", $"{cd}")
        echo("Starting Minecraft")
        Command("start %cd%\bin\Minecraft.exe")
        echo("All done!")
        Threading.Thread.Sleep(5000)
        Console.ForegroundColor = ConsoleColor.Gray
        End
    End Sub

    'for executing a command in an invisble cmd!
    Private Sub Command(c)
        Dim cmdProcess As New Process
        With cmdProcess
            Dim m = $"/C {c}"
            .StartInfo = New ProcessStartInfo("cmd.exe", m)

            With .StartInfo
                .CreateNoWindow = True
                .UseShellExecute = False
                .RedirectStandardOutput = True
            End With
            .Start()
            .WaitForExit()
        End With

    End Sub

    'Makes An Echo like the cmd command but in the debugger too 
    Private Sub echo(i)
        Console.WriteLine(i)
        Debug.Print(i)
    End Sub

    'splash screen at the start
    Private Sub splash()
        echo("
                 License For MC-JE: PE(This Programm Or software)
                               MIT License

           ""Minecraft"" Is a trademark of Mojang Synergies AB

   *                                     (                                                     
 (  `       (                            )\ )                                                  
 )\))(      )\            (    (        (()/(   (                                              
((_)()\   (((_)           )\   )\        /(_))  )\                                             
(_()((_)  )\___          ((_) ((_)   _  (_))   ((_)                                            
|  \/  | ((/ __|   ___   _ | | | __| (_) | _ \  | __|                                           
| |\/| |  | (__   |___| | || | | _|   _  |  _/  | _|                                            
|_|  |_|   \___|         \__/  |___| (_) |_|    |___|                                           
                                                                                               
                                                                                               
   (             (                                              (                           )  
 ( )\   (        )\ )        )      )       (                   )\    (        )         ( /(  
 )((_)  )\ )    (()/(     ( /(     (       ))\   (            (((_)   )(    ( /(    (    )\()) 
((_)_  (()/(     /(_))_   )(_))    )\  '  /((_)  )\           )\___  (()\   )(_))   )\  ((_)\  
 | _ )  )(_))   (_)) __| ((_)_   _((_))  (_))   ((_)         ((/ __|  ((_) ((_)_   ((_) | |(_) 
 | _ \ | || |     | (_ | / _` | | '  \() / -_)  (_-<          | (__  | '_| / _` | / _|  | / /  
 |___/  \_, |      \___| \__,_| |_|_|_|  \___|  /__/  _____    \___| |_|   \__,_| \__|  |_\_\  
        |__/                                         |_____|                                   
")
    End Sub

End Module
