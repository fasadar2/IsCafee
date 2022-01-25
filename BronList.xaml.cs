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
using System.Windows.Navigation;
using ClassLibraryIsCafee;

namespace IsCafee
{
    /// <summary>
    /// Логика взаимодействия для BronList.xaml
    /// </summary>
    public partial class BronList : Window
    {
        public BronList()
        {
            InitializeComponent();
            FillingData();
        }
        public void FillingData()
        {
            var list = Bronirivanie.GetBronViewsAll();
            dgBronList.ItemsSource = list;
        }
        private static ApplicationContext db = Context.Db;
        private void bBronUpdate_Click(object sender, RoutedEventArgs e)
        {
            int key = int.Parse(tbDeletBron.Text);

            // Вариант 1. Изменение записи.
            var item = db.Bronirivanie.Find(key); // найдем запись
            if (item != null)
            {
                item.TimeClientEntering = tbBronTimeEntry.Text;
                item.TimeClientExit = tbBronTimeExit.Text;
                db.SaveChanges();
            }
        }
    }
}
