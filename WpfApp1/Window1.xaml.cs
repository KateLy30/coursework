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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = t_name.Text;
            string phone = t_phone.Text;
            DateTime date = DateTime.Parse (t_date.Text);
            int table = int.Parse (t_table.Text);   
            MainWindow mainWindow = new MainWindow();
            mainWindow.Add(name, phone, date, table);
            mainWindow.Show();
            Hide();
        }
    }
}
