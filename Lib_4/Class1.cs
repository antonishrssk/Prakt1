using System;

namespace Lib_4
{
    public class Class1
    {
        // ��������� ��������� ����� � ���������� ������������ �����
        // n - ���������� ��������� �����
        // �������� ��������: min - ����������� �����, numbers - ������ ��������� �����
        public static void GenerateAndGetMin(int n, out int min, out string numbers)
        {
            int x;
            numbers = "";
            min = 41;

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                x = rnd.Next(10, 41); // ���������� ��������� �����
                numbers += x.ToString() + ' ';
                if (x < min) min = x;
            }
        }
    }
}
