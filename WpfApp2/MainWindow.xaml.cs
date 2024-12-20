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

namespace SumOfMultiples
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
               
                int[] numbers = InputTextBox.Text.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                                                 .Select(s => int.Parse(s.Trim()))
                                                 .ToArray();

             
                long sum = numbers.Where(num => num % 7 == 0).Sum();

                ResultTextBlock.Text = $"Результат: {sum}";
            }
            catch (FormatException)
            {
                MessageBox.Show("Ошибка: Введены некорректные данные.  Введите числа через запятую.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }
    }
}