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

namespace Homework17version1._1
{
    /// <summary>
    /// Логика взаимодействия для WindowAdd.xaml
    /// </summary>
    public partial class WindowAdd : Window
    {
        private SqlConnections sql = new SqlConnections();
        public SQLContext UserContext { get; private set; }
        public WindowAdd(ref ModelSQL user)
        {
            InitializeComponent();
            if (user.Email != null)
            {

                tbLast.Text = user.LastName;
                tbFirst.Text = user.Name;
                tbPatronymic.Text = user.MiddleName;
                tbPhone.Text = user.NumberTelephone;
                tbEmail.Text = user.Email;

            }
            UserContext=new SQLContext();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            ModelSQL model = new ModelSQL($"{tbLast.Text}", $"{tbFirst.Text}", $"{tbPatronymic.Text}", $"{tbPhone.Text}", $"{tbEmail.Text}");
            sql.CreateOrUpdate(model);
            DataPage data = new DataPage();
            data.SelectUsers();
            Close();
        }

        private void disBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
