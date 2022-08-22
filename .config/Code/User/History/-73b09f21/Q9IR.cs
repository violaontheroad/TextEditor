internal class Program
{
    private static void Main(string[] args)
    {
        Menu();
    }

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
            text += Environment.NewLine;
        }
        while(Console.ReadKey().Key != ConsoleKey.Escape);

        Console.Write(text);
    }

}