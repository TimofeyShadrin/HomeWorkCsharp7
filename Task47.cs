namespace Seminar7
{
    class Task47
    {
        public static void ReturnTask47()
        {
            bool answer = false;
            while (true)
            {
                Console.Clear();
                try
                {
                    double[,] randomDoubleArray = Methods.FillConditionForDoubleRandomArray();
                    PrintArray.PrintCurrentArray(randomDoubleArray);
                    if (
                        randomDoubleArray.GetLength(0) > 0 && randomDoubleArray.GetLength(1) > 0
                        && randomDoubleArray != null
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
                        answer = Methods.ChoiseEscOrEnter(answer);
                        if (answer == true)
                            break;
                    }
                }
                catch
                {
                    answer = Methods.ChoiseEscOrEnter(answer);
                    if (answer == true)
                        break;
                }
            }
        }
    }
}
