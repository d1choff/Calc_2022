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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private double GetResult(double Num1, double Num2)
        {
            double Result = 0;
            switch (cbEnterAction.SelectedIndex)
            {
                case 0:
                    Result = Num1 + Num2;
                    break;
                case 1:
                    Result = Num1 - Num2;
                    break;
                case 2:
                    Result = Num1 * Num2;
                    break;
                case 3:
                    Result = Num1 / Num2;
                    break;
            }
            return Result;
        }

        private void tbNum1_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void tbNum2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0));
        }

        private void btnGetResult_Click(object sender, RoutedEventArgs e)
        {
            if(cbEnterAction.SelectedIndex == -1)
            {
                MessageBox.Show("Выбирите математическое действие!");
            }

            if(!(string.IsNullOrWhiteSpace(tbNum1.Text)) && !(string.IsNullOrWhiteSpace(tbNum2.Text)))
            {
                double result = GetResult(double.Parse(tbNum1.Text), double.Parse(tbNum2.Text));
                tbNumResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Введите число в поле!");
            }

        }
    }
}
