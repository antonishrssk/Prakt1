using System;

namespace Lib_4
{
    public class Class1
    {
        // Генерация случайных чисел и нахождение минимального числа
        // n - количество случайных чисел
        // Выходные значения: min - минимальное число, numbers - список случайных чисел
        public static void GenerateAndGetMin(int n, out int min, out string numbers)
        {
            int x;
            numbers = "";
            min = 41;

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                x = rnd.Next(10, 41); // Генерируем случайное число
                numbers += x.ToString() + ' ';
                if (x < min) min = x;
            }
        }
    }
}
