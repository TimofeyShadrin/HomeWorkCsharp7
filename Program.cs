namespace Seminar7
{
    class Program
    {
        public static int answer = 0;

        public static void Main(string[] args)
        {
            Navigation();
        }

        public static void Navigation()
        {
            while (true)
            {
                ConsoleKeyInfo choise;
                if (answer == 0)
                {
                    Console.Clear();
                    Menu.Box(3, 4, 100, 4);
                    Menu.Intro();
                    choise = Console.ReadKey();
                    if (choise.Key == ConsoleKey.DownArrow)
                        answer = 1;
                    else if (choise.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Task47.ReturnTask47();
                        answer = 0;
                    }
                    else
                        continue;
                }
                else if (answer == 1)
                {
                    Console.Clear();
                    Menu.Box(3, 8, 100, 4);
                    Menu.Intro();
                    choise = Console.ReadKey();
                    if (choise.Key == ConsoleKey.DownArrow)
                        answer = 2;
                    else if (choise.Key == ConsoleKey.UpArrow)
                        answer = 0;
                    else if (choise.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Task50.ReturnTask50();
                        answer = 0;
                    }
                    else
                        continue;
                }
                else if (answer == 2)
                {
                    Console.Clear();
                    Menu.Box(3, 12, 100, 4);
                    Menu.Intro();
                    choise = Console.ReadKey();
                    if (choise.Key == ConsoleKey.DownArrow)
                        answer = 3;
                    else if (choise.Key == ConsoleKey.UpArrow)
                        answer = 1;
                    else if (choise.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        Task52.ReturnTask52();
                        answer = 0;
                    }
                    else
                        continue;
                }
                else if (answer == 3)
                {
                    Console.Clear();
                    Menu.Box(3, 16, 100, 4);
                    Menu.Intro();
                    choise = Console.ReadKey();
                    if (choise.Key == ConsoleKey.UpArrow)
                        answer = 2;
                    else if (choise.Key == ConsoleKey.Enter)
                    {
                        Console.Clear();
                        break;
                    }
                    else
                        continue;
                }
            }
        }
    }
}
