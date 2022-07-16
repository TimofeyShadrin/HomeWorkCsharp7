namespace Seminar7
{
    class Task47
    {
        public static void ReturnTask47()
        {
            while (true)
            {
                Console.Clear();
                try
                {
                    Console.Write(
                        "\n\tПожалуйста введите количество строк\n"
                            + "\tв виде целого числа для создания двумерного массива,\n"
                            + "\tзаполненного случайными вещественными числами: "
                    );
                    string? height = Console.ReadLine();
                    Console.Write(
                        "\n\tПожалуйста введите количество столбцов\n"
                            + "\tв виде целого числа для создания двумерного массива,\n"
                            + "\tзаполненного случайными вещественными числами: "
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
                        double[,] randomDoubleArray = Methods.GetRandomDoubleArray(
                            indexOfHeight,
                            indexOfLength,
                            minValue,
                            maxValue
                        );
                        PrintArray.PrintCurrentArray(randomDoubleArray);
                        if (
                            randomDoubleArray.GetLength(0) > 0 && randomDoubleArray.GetLength(1) > 0
                        )
                        {
                            Console.Write(
                                "\n\tПожалуста нажмите любую клавишу для возврата в основное меню: "
                            );
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("\tВаш ввод не соответствует требованиям!");
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
