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
            if (items.Count == 0)
            {
                items.Add(new Item { Name = "Екатерина", Phone = "89188613549", Date = new DateTime(2025, 04, 17, 12, 00, 00), Table = 12 });
                items.Add(new Item { Name = "Валерий", Phone = "89065678990", Date = new DateTime(2025, 04, 16, 20, 00, 00), Table = 12 });
                items.Add(new Item { Name = "Николай", Phone = "89624235678", Date = new DateTime(2025, 04, 16, 17, 00, 00), Table = 19 });
                items.Add(new Item { Name = "Кристина", Phone = "89187658978", Date = new DateTime(2025, 04, 15, 19, 00, 00), Table = 7 });
                items.Add(new Item { Name = "Дмитрий", Phone = "89064567832", Date = new DateTime(2025, 04, 17, 20, 00, 00), Table = 2 });
           
            }
            listView.ItemsSource = items;
        }
        private static List<Item> items = new List<Item>();

        public class Item
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public DateTime Date { get; set; }
            public int Table { get; set; }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.Show();
            Hide();
        }
        public void Add(string name, string phone, DateTime date, int table)
        {
            items.Add(new Item { Name = name, Phone = phone, Date = date, Table = table });
            listView.Items.Refresh();
        }
    }
}
