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
            Console.Write("\n\tСреднее арифметическое каждого столбца: ");
            int length = listOfArithmeticMeans.Count;
            for (int i = 0; i < length - 1; i++)
                Console.Write($"{Math.Round(listOfArithmeticMeans[i], 2)}; ");
            Console.Write($"{Math.Round(listOfArithmeticMeans[length - 1], 2)}.\n");
        }
    }
}
