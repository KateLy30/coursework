using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
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
            Button button = sender as Button;
            Window_reservation window_Reservation = new Window_reservation();
            if (button != null)
            {
                foreach (var item in Window_reservation.reservations)
                {
                    if (item.Table.ToString() == button.Content.ToString())
                    {
                        MessageBox.Show($"Стол: {button.Content}\nДата и время бронирования: {item.Date}");
                    }
                }
            } 
        } 

        private void Button_Click_Exit(object sender, RoutedEventArgs e)
        {
            Hide();
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
        }

        private void b_reservation_Click(object sender, RoutedEventArgs e)
        {
            Hide();
            Window_reservation window_Reservation = new Window_reservation();
            window_Reservation.Show();
        }
    }
}
