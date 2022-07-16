namespace Seminar7
{
    class Decisions
    {
        public static void ReturnElement(int[,] incomingArray)
        {
            try
            {
                Console.WriteLine(
                    "\tПожалуйста введите индексы позиции элемента в двумерном массиве в ввиде m,n \n"
                        + "\tгде m - номер строки начиная с 1, а n - номер столбца начиная с 1\n"
                );
                Console.Write("\tm,n = ");
                string? indexOfElement = Console.ReadLine();
                if (!String.IsNullOrEmpty(indexOfElement))
                {
                    string[] numbers = indexOfElement.Split(',');
                    int[] indexis = ConvertToIntArray(numbers);
                    if (
                        indexis.Length == 2
                        && indexis[0] <= incomingArray.GetLength(0)
                        && indexis[1] <= incomingArray.GetLength(1)
                    )
                    {
                        Console.WriteLine(
                            $"\n\tЗначение элемента, согласно введенной позиции = {incomingArray[indexis[0] - 1, indexis[1] - 1]}"
                        );
                    }
                    else
                        Console.WriteLine("\n\tВы ввели не существующие индексы позиции элемента!");
                }
            }
            catch
            {
                throw;
            }
        }

        private static int[] ConvertToIntArray(string[] arrayOfNumbers)
        {
            int[] coordinates = new int[arrayOfNumbers.Length];
            for (int i = 0; i < arrayOfNumbers.Length; i++)
            {
                coordinates[i] = Convert.ToInt32(arrayOfNumbers[i].ToString());
            }
            return coordinates;
        }

        public static List<double> ArithmeticMeanInColumn(int[,] incomingArray)
        {
            int height = incomingArray.GetLength(0);
            int length = incomingArray.GetLength(1);
            List<double> listOfArithmeticMeans = new List<double>();
            for (int i = 0; i < length; i++)
            {
                double result = 0.0;
                for (int j = 0; j < height; j++)
                {
                    result += incomingArray[j, i];
                }
                result /= incomingArray.GetLength(0);
                listOfArithmeticMeans.Add(result);
            }
            return listOfArithmeticMeans;
        }
    }
}
