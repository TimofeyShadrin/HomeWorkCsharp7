namespace Seminar7
{
    class Task50
    {
        public static void ReturnTask50()
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write(
                        "\n\tПожалуйста введите количество строк\n"
                            + "\tв виде целого числа для создания двумерного массива,\n"
                            + "\tзаполненного случайными целыми числами: "
                    );
                    string? height = Console.ReadLine();
                    Console.Write(
                        "\n\tПожалуйста введите количество столбцов\n"
                            + "\tв виде целого числа для создания двумерного массива,\n"
                            + "\tзаполненного случайными целыми числами: "
                    );
                    string? length = Console.ReadLine();
                    Console.Write(
                        "\n\tПожалуйста введите минимальное значение элемента\n"
                            + "\tв виде целого числа: "
                    );
                    string? minDigit = Console.ReadLine();
                    Console.Write(
                        "\n\tПожалуйста введите максимальное значение элемента\n"
                            + "\tв виде целого числа: "
                    );
                    string? maxDigit = Console.ReadLine();
                    if (
                        !String.IsNullOrEmpty(height)
                        && !String.IsNullOrEmpty(length)
                        && !String.IsNullOrEmpty(minDigit)
                        && !String.IsNullOrEmpty(maxDigit)
                    )
                    {
                        byte indexOfHeight = Convert.ToByte(height.ToString());
                        byte indexOfLength = Convert.ToByte(length.ToString());
                        int minValue = Convert.ToInt32(minDigit.ToString());
                        int maxValue = Convert.ToInt32(maxDigit.ToString());
                        int[,] randomIntArray = Methods.GetRandomIntArray(
                            indexOfHeight,
                            indexOfLength,
                            minValue,
                            maxValue
                        );
                        PrintArray.PrintCurrentArray(randomIntArray);
                        if (randomIntArray.GetLength(0) > 0 && randomIntArray.GetLength(1) > 0)
                        {
                            Console.WriteLine("\n");
                            Decisions.ReturnElement(randomIntArray);
                            Console.Write(
                                "\n\tПожалуста нажмите любую клавишу для возврата в основное меню: "
                            );
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\n\tВаш ввод не соответствует требованиям!");
                            Console.Write(
                                "\n\tПожалуста нажмите любую клавишу для повторения операции\n"
                                    + "\tили Escape для выхода в основное меню: "
                            );
                            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                            {
                                Console.WriteLine("\n");
                                break;
                            }
                        }
                    }
                    else
                    {
                        Console.WriteLine("\n\tВаш ввод не соответствует требованиям!");
                        Console.Write(
                            "\n\tПожалуста нажмите любую клавишу для повторения операции\n"
                                + "\tили Escape для выхода в основное меню: "
                        );
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            Console.WriteLine("\n");
                            break;
                        }
                    }
                }
                catch
                {
                    Console.WriteLine("\n\tВаш ввод не соответствует требованиям!");
                    Console.Write(
                        "\n\tПожалуста нажмите любую клавишу для повторения операции\n"
                            + "\tили Escape для выхода в основное меню: "
                    );
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        Console.WriteLine("\n");
                        break;
                    }
                }
            }
        }
    }
}
