using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace WpfApp1
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
        public  string Password { get; set; }
        private string userPassword;
        private void b_1_Click(object sender, RoutedEventArgs e)
        {
            if (Password == null)
            {
                Password = "900800";
            }
            text_kod.Text += text_kod.Text = "*";
            Button button = (Button)sender;
            userPassword  += (string)button.Content;
            if (userPassword  == Password)
            {
                Hide();
                Window1 window1 = new Window1();
                window1.Show();
            }
            else if (text_kod.Text.Length >= 6)
            {
                userPassword = "";
                text_kod.Clear();
                MessageBox.Show("Код не верный!");
            }

        }
    }
}
