using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Lib_4;

namespace Prakt1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        // Сгенерировать числа и найти минимальное
        private void btnGenerateAndGetMin_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int n = Convert.ToInt32(tbNumbersCount.Text);
                Class1.GenerateAndGetMin(n, out int min, out string numbers); // Генерируем случайные числа и находим минимальное
                tbNumbers.Text = numbers; // Выводим сгенерированные числа
                tbMin.Text = min.ToString(); // Выводим минимальное число
            }
            catch
            {
                MessageBox.Show("Введите правильные значения", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        // Выход
        private void btnExit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        // О программе
        private void btnInfo_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Практическая работа №1\n" +
                "Разработчик: Антонишин Кирилл Сергеевич\n" +
                "Найти минимум из n целых случайных чисел X, распределенных в диапазоне от 10 до 40. " +
                "Вывести на экран на одной строке сгенерированные числа, на другой строке результат." +
                "Изменено для практической работы №4", "О программе", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
