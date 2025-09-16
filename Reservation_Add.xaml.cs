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
    /// Логика взаимодействия для Reservation_Add.xaml
    /// </summary>
    public partial class Reservation_Add : Window
    {
        public Reservation_Add()
        {
            InitializeComponent();
        }

        private void b_exit_Click(object sender, RoutedEventArgs e)
        {
            Window_reservation window_Reservation = new Window_reservation();
            Hide();
            window_Reservation.Show();
        }

        private void t_Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string name = t_name.Text;
                string phone = t_phone.Text;
                DateTime date = DateTime.Parse(t_date.Text);
                int table = int.Parse(t_table.Text);
                bool b1 = true, b2 = true, b3 = true;
                if (phone.Length != 11)
                {
                    t_phone.ToolTip = "Это поле введено не корректно";
                    t_phone.Background = Brushes.Red;
                    b1 = false;
                }
                if (table <= 0 || table > 19)
                {
                    t_table.ToolTip = "Это поле введено не корректно";
                    t_table.Background = Brushes.Red;
                    b2 = false;
                }
                foreach (var item in Window_reservation.reservations)
                {
                    if (item.Date.Month == date.Month && item.Date.Day == date.Day && item.Table == table)
                    {
                        if (date.Hour == item.Date.Hour || (date.Hour < item.Date.Hour + 4 && date.Hour > item.Date.Hour - 4))
                        {
                            MessageBox.Show("На это время уже есть бронирование");
                            b3 = false;
                        }

                    }
                }
                if (b1 && b2 && b3)
                {
                    t_date.ToolTip = "";
                    t_date.Background = Brushes.Transparent;
                    t_table.ToolTip = "";
                    t_table.Background = Brushes.Transparent;
                    t_phone.ToolTip = "";
                    t_phone.Background = Brushes.Transparent;
                    Window_reservation window_Reservation = new Window_reservation();
                    window_Reservation.Add(name, phone, date, table);
                    Hide();
                    window_Reservation.Show();
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }

        }
    }
}
