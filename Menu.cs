namespace Seminar7
{
    class Menu
    {
        public static void Intro()
        {
            Console.WriteLine(
                "\n\t Приветствую! Выберете пожалуйста задачу для проверки!\n"
                    + "\t\t Для этого используйте клавишы вверх и вниз, затем подтвердите его кнопкой Enter.\n"
                    //+ "\t\t Для выхода из программы нажмите Escape.\n"
                    + "\n\n"
                    + "\t1. Задача No 47:\n"
                    + "\t\t Задайте двумерный массив размером m x n,\n"
                    + "\t\t заполненный случайными вещественными числами.\n"
                    + "\n"
                    + "\t2. Задача No 50:\n"
                    + "\t\t Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,\n"
                    + "\t\t и возвращает значение этого элемента или же указание, что такого элемента нет.\n"
                    + "\n"
                    + "\t3. Задача No 52:\n"
                    + "\t\t Задайте двумерный массив из целых чисел.\n"
                    + "\t\t Найдите среднее арифметическое элементов в каждом столбце.\n"
                    + "\n\n"
                    + "\t Выход из программы"
            );
            Console.WriteLine("\n\n");
        }

        private static void HorizontalLine(int left, int top, int length)
        {
            Console.SetCursorPosition(left, top);
            Console.Write("+");
            for (int i = 0; i < length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");
        }

        private static void VerticalLine(int left, int top, int height)
        {
            for (int i = 0; i <= height; i++)
            {
                Console.SetCursorPosition(left, top + i);
                Console.Write("|");
            }
        }

        public static void Box(int left, int top, int lenght, int height)
        {
            HorizontalLine(left, top, lenght);
            VerticalLine(left, top + 1, height - 1);
            VerticalLine(left + lenght + 1, top + 1, height - 1);
            HorizontalLine(left, top + height, lenght);
            Console.SetCursorPosition(0, 0);
        }
    }
}
