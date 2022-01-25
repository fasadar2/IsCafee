﻿using System;
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
using ClassLibraryIsCafee;

namespace IsCafee
{
    /// <summary>
    /// Логика взаимодействия для ClientAdd.xaml
    /// </summary>
    public partial class ClientAdd : Window
    {
        public ClientAdd()
        {
            InitializeComponent();
        }

        private void bAddClient_Click(object sender, RoutedEventArgs e)
        {
            Client client;
            client = new Client
            {
                FirstName = tbClientAddFmil.Text,
                SecondName = tbClientAddName.Text,
                ThirdName = tbClientAddOtchestvo.Text,
                BirthDate = (DateTime)dtDoB.SelectedDate,
               
                
            };
            Client.Add(client);
        }
    }
}
