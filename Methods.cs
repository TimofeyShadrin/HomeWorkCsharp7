namespace Seminar7
{
    class Methods
    {
        public static double[,] GetRandomDoubleArray(
            byte height,
            byte length,
            int minDigit,
            int maxDigit
        )
        {
            double[,] randomArray = new double[height, length];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    int integerValue = new Random().Next(minDigit, maxDigit);
                    double doubleValue = new Random().Next(0, 100);
                    randomArray[i, j] = integerValue + doubleValue / 100;
                }
            }
            return randomArray;
        }

        public static int[,] GetRandomIntArray(byte height, byte length, int minDigit, int maxDigit)
        {
            int[,] randomArray = new int[height, length];
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < length; j++)
                {
                    randomArray[i, j] = new Random().Next(minDigit, maxDigit);
                }
            }
            return randomArray;
        }

        public static void PrintList(List<double> listOfArithmeticMeans)
        {
            Console.Write("\n\n\tСреднее арифметическое каждого столбца: ");
            int length = listOfArithmeticMeans.Count;
            for (int i = 0; i < length - 1; i++)
                Console.Write($"{Math.Round(listOfArithmeticMeans[i], 2)}; ");
            Console.Write($"{Math.Round(listOfArithmeticMeans[length - 1], 2)}.\n");
        }

        public static bool ChoiseEscOrEnter(bool answer)
        {
            Console.WriteLine("\n\tВаш ввод не соответствует требованиям!");
            Console.Write(
                "\n\tПожалуста нажмите любую клавишу для повторения операции\n"
                    + "\tили Escape для выхода в основное меню: "
            );
            if (Console.ReadKey(true).Key == ConsoleKey.Escape)
            {
                Console.WriteLine("\n");
                return answer = true;
            }
            else
                return answer = false;
        }

        public static int[,] FillConditionForRandomArray()
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
                "\n\tПожалуйста введите минимальное значение элемента\n" + "\tв виде целого числа: "
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
                return randomIntArray;
            }
            else
                return null;
        }

        public static double[,] FillConditionForDoubleRandomArray()
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
                "\n\tПожалуйста введите минимальное значение элемента\n" + "\tв виде целого числа: "
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
                return randomDoubleArray;
            }
            else
                return null;
        }
    }
}
