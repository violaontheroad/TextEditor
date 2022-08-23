using System.IO;
internal class Program
{
    private static void Main(string[] args)
    {
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

            switch (option)
            {
                case 0: Environment.Exit(0); break;
                case 1: Open(); break;
                case 2: Edit(); break;
            }
        }

        static void Open()
        {
            Console.Clear();
            Console.WriteLine("Qual caminho do arquivo?");
            string path = Console.ReadLine();

            using (var file = new StreamReader(path)) // ler o arquivo
            {
                string text = file.ReadToEnd(); // ler o texto do arquivo até o final
                Console.WriteLine(text);
            } 
            Console.WriteLine("");
            Console.ReadLine();
            Menu();
         }

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
            while (Console.ReadKey().Key != ConsoleKey.Escape); // ConsoleKey.Escape = tecla ESC

            Salvar(text);
        }
    
        static void Salvar(string text)
        {
            Console.Clear();
            Console.WriteLine("Qual caminho para salvar o arquivo?");
            var path = Console.ReadLine();

            using(var file = new StreamWriter(path)) // salvar o arquivo
            {
                file.Write(text);
            }

            Console.WriteLine($"Arquivo {path} salvo com sucesso");
            Menu();

        }
    }
}