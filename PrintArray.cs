namespace Seminar7
{
    class PrintArray
    {
        private static int FindMaxSize(double[,] incomingArray)
        {
            int MaxSizeOfElement = 0;
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    string temp = Math.Round(incomingArray[i, j], 2).ToString();
                    if (temp.Length > MaxSizeOfElement)
                        MaxSizeOfElement = temp.Length;
                }
            }
            return MaxSizeOfElement;
        }

        private static int FindMaxSize(int[,] incomingArray)
        {
            int MaxSizeOfElement = 0;
            for (int i = 0; i < incomingArray.GetLength(0); i++)
            {
                for (int j = 0; j < incomingArray.GetLength(1); j++)
                {
                    string temp = incomingArray[i, j].ToString();
                    if (temp.Length > MaxSizeOfElement)
                        MaxSizeOfElement = temp.Length;
                }
            }
            return MaxSizeOfElement;
        }

        private static string QuantityWhitespaces(string elementOfArray, int MaxSizeOfElement)
        {
            string whitespaces = string.Empty;
            int diffOfLength = MaxSizeOfElement - elementOfArray.Length;
            for (byte i = 0; i < diffOfLength; i++)
            {
                whitespaces += " ";
            }
            return whitespaces;
        }

        public static void PrintCurrentArray(double[,] incomingArray)
        {
            Console.WriteLine("\n\tКомпьютер создал следующий двумерный массив:");
            int MaxSizeOfElement = FindMaxSize(incomingArray);
            if (incomingArray.GetLength(0) > 0 && incomingArray.GetLength(1) > 0)
            {
                for (int i = 0; i < incomingArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write("\t");
                    for (int j = 0; j < incomingArray.GetLength(1); j++)
                    {
                        string whitespaces = QuantityWhitespaces(
                            Math.Round(incomingArray[i, j], 2).ToString(),
                            MaxSizeOfElement
                        );
                        Console.Write(
                            $"{whitespaces}{Math.Round(incomingArray[i, j], 2).ToString()}  "
                        );
                    }
                }
            }
            else
            {
                Console.WriteLine(
                    "\n\tИзвините, но с пустым массивом не возможно провести требуемые операции!"
                );
            }
            Console.WriteLine("\t");
        }

        public static void PrintCurrentArray(int[,] incomingArray)
        {
            Console.WriteLine("\n\tКомпьютер создал следующий двумерный массив:");
            int MaxSizeOfElement = FindMaxSize(incomingArray);
            if (incomingArray.GetLength(0) > 0 && incomingArray.GetLength(1) > 0)
            {
                for (int i = 0; i < incomingArray.GetLength(0); i++)
                {
                    Console.WriteLine();
                    Console.Write("\t");
                    for (int j = 0; j < incomingArray.GetLength(1); j++)
                    {
                        string whitespaces = QuantityWhitespaces(
                            incomingArray[i, j].ToString(),
                            MaxSizeOfElement
                        );
                        Console.Write($"{whitespaces}{incomingArray[i, j].ToString()}  ");
                    }
                }
            }
            else
            {
                Console.WriteLine(
                    "\n\tИзвините, но с пустым массивом не возможно провести требуемые операции!"
                );
            }
        }
    }
}
