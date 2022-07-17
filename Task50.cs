namespace Seminar7
{
    class Task50
    {
        public static void ReturnTask50()
        {
            bool answer = false;
            while (true)
            {
                Console.Clear();
                try
                {
                    int[,] randomIntArray = Methods.FillConditionForRandomArray();
                    PrintArray.PrintCurrentArray(randomIntArray);
                    if (
                        randomIntArray.GetLength(0) > 0 && randomIntArray.GetLength(1) > 0
                        && randomIntArray != null
                    )
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
