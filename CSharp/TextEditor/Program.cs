// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Menu();

 static void Menu()
    {
        Console.Clear();
        Console.WriteLine("What do you want to do?");
        Console.WriteLine("1 - Open a file");
        Console.WriteLine("2 - Create a new file");       
        Console.WriteLine("0 - Exit");
        short option = short.Parse(Console.ReadLine());

        switch(option)
        {   
            case 0: System.Environment.Exit(0); break;
            case 1: Open(); break;
            case 2: Edit(); break;
        }
    }

    static void Open(){}

    static void Edit()
    {
        Console.Clear();
        Console.WriteLine("Digite seu texto abaixo (or ESC to exit)");
        Console.WriteLine("----------------------------------------");
        string text = "";

        do 
        {
            text += Console.ReadLine();
            text += Environment.NewLine; // quebrar a linha no fim de cada leitura
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape); // ConsoleKey.Escape = tecla ESC

        Console.Write(text);
    }