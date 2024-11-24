using System;
using System.Collections.Generic;
using System.IO;
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

namespace Praktika3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Client> Clients { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            Clients = new List<Client>();
            ClientsDataGrid.ItemsSource = Clients;
        }

        private void AddProductButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string abonimentType = AbonimentTypeTextBox.Text;
            try
            {
                int quantityOfVisits = Convert.ToInt32(QuantityOfVisitsTextBox.Text);
                Clients.Add(new Client
                {
                    Name = name,
                    AbonimentType = abonimentType,
                    QuantityOfVisits = quantityOfVisits
                });

                NameTextBox.Clear();
                AbonimentTypeTextBox.Clear();
                QuantityOfVisitsTextBox.Clear();
                ClientsDataGrid.ItemsSource = Clients;
            }
            catch (Exception i)
            {
                MessageBox.Show("Вы ввели неверный формат данных в блоке количества посещений");
                NameTextBox.Clear();
                AbonimentTypeTextBox.Clear();
                QuantityOfVisitsTextBox.Clear();
            }
        }
    }

    public class Client
    {
        public string Name { get; set; }
        public string AbonimentType { get; set; }
        public int QuantityOfVisits { get; set; }

    }
}

