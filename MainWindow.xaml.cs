
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
using ClassLibraryIsCafee;
namespace IsCafee
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            FillingData();
        }

        private void bOpenBronList_Click(object sender, RoutedEventArgs e)
        {
            BronList bronlist = new BronList();
            bronlist.Show();

            

           
        }

        private void bAddClient_Click(object sender, RoutedEventArgs e)
        {
            ClientAdd clientadd = new ClientAdd();
            clientadd.Show();
        }

        private void bBron_Click(object sender, RoutedEventArgs e)
        {
            Bronirivanie bron;
            bron = new Bronirivanie
            {
                firstName = tBNameBron.Text,
                secondName = tbFamilBron.Text,
                thirdName = tbOtchBron.Text,
                hallId = int.Parse(tbZalBron.Text),
                tableId = int.Parse(tbStolBron.Text),
                TimeBron = tbTime.Text,
                Summ = float.Parse(tbSumBron.Text),
                Status = "забронированно"
            };
            Bronirivanie.Add(bron);
        }
        public void FillingData()
        {
            var list = Client.GetClientViewsAll();
            dgClientView.ItemsSource = list;
        }

        private void bViewZakz_Click(object sender, RoutedEventArgs e)
        {
            ZakazList zakaz = new ZakazList();
            zakaz.Show();
        }

        private void bZakazAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
