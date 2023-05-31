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

namespace ITMO_Course_WinCS_WPF_Lab1_1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            button.IsEnabled = false;
            button1.IsEnabled = false;
        }

        private void cmdExecute_Click(object sender, RoutedEventArgs e)
        {
            int i = 2;

            MessageBox.Show("Рш ШЕЬЩ");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamWriter sw = new
                    System.IO.StreamWriter("D:\\Anton.txt");
                sw.WriteLine(textBox.Text);
                sw.Close();
                button1.IsEnabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader("D:\\Anton.txt");
                label.Content = "Приветствую Вас, уважаемый " + sr.ReadToEnd();
                sr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            button.IsEnabled = true;
        }
    }
}
