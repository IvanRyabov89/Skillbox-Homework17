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

namespace Homework17version1._1
{
    /// <summary>
    /// Логика взаимодействия для ef.xaml
    /// </summary>
    public partial class ef : Window
    {
        SqlConnections sql=new SqlConnections();
        public ef()
        {
            InitializeComponent();
            //dd.ItemsSource = sql.ListOrders;
        }
    }
}
