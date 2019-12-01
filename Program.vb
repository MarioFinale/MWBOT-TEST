Imports System
Imports MWBot

Module Program
    Sub Main(args As String())
        MWBot.net.WikiBot.Bot.StartUpCheck()
        Console.WriteLine("Press any key to exit...")
        Console.ReadKey()
    End Sub
End Module
