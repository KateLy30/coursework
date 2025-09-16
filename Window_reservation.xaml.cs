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
    /// Логика взаимодействия для Window_reservation.xaml
    /// </summary>
    public partial class Window_reservation : Window
    {
        public Window_reservation()
        {
            InitializeComponent();
            if (reservations.Count == 0)
            {
                reservations.Add(new Reservation { Name = "Екатерина", Phone = "89188613549", Date = new DateTime(2025, 04, 17, 12, 00, 00), Table = 12 });
                reservations.Add(new Reservation { Name = "Валерий", Phone = "89065678990", Date = new DateTime(2025, 04, 16, 20, 00, 00), Table = 1 });
                reservations.Add(new Reservation { Name = "Николай", Phone = "89624235678", Date = new DateTime(2025, 04, 16, 17, 00, 00), Table = 19 });
                reservations.Add(new Reservation { Name = "Кристина", Phone = "89187658978", Date = new DateTime(2025, 04, 15, 19, 00, 00), Table = 7 });
                reservations.Add(new Reservation { Name = "Дмитрий", Phone = "89064567832", Date = new DateTime(2025, 04, 17, 20, 00, 00), Table = 2 });

            }
            listView.ItemsSource = reservations;
        }
        public static  List<Reservation> reservations = new List<Reservation>();
        public class Reservation
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public DateTime  Date { get; set; }
            public int Table { get; set; }
            
        }

        public void Add(string name, string phone, DateTime date, int table)
        {
            reservations.Add(new Reservation { Name = name, Phone = phone, Date = date, Table = table });
            listView.Items.Refresh();
        }

        private void b_exit_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            Hide();
            window1.Show();
        }

        private void b_reserv_Click(object sender, RoutedEventArgs e)
        {
            Reservation_Add reservation_Add = new Reservation_Add();
            Hide();
            reservation_Add.Show();
        }
    }
}
