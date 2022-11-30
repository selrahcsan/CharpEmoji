using Spectre.Console;

Console.Clear();

AnsiConsole.Status()
    .Start("Emojis Populares", ctx => 
    {
        
        AnsiConsole.MarkupLine("\nAlien :alien:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Raiva :angry_face:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Bebe :baby:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Rindo :beaming_face_with_smiling_eyes:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Cerveja :beer_mug:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Gato :cat_face:");
        Thread.Sleep(1000);
        
        AnsiConsole.MarkupLine("Outros modelos de Emojis em :");
        AnsiConsole.MarkupLine( ":backhand_index_pointing_right: https://spectreconsole.net/appendix/emojis :backhand_index_pointing_left:");
    });
