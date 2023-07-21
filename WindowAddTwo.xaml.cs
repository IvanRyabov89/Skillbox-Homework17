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
    /// Логика взаимодействия для WindowAddTwo.xaml
    /// </summary>
    public partial class WindowAddTwo : Window
    {
        private SqlConnections sql = new SqlConnections();
        public SQLContext UserContext { get; private set; }
        //private ModelAccess Data;
        public WindowAddTwo(ref ModelAccess data)
        {
            InitializeComponent();
            if (data != null)
            {
                tbPEmail.Text = data.Email;
                tbPCode.Text = data.CodeProduct;
                tbPName.Text = data.NameProduct;
            }
            UserContext=new SQLContext();
        }

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            
            ModelAccess model = new ModelAccess($"{tbPEmail.Text}", $"{tbPCode.Text}", $"{tbPName.Text}");
            sql.CreateOrUpdate(model);
            DataPage data = new DataPage();
            data.SelectProducts();
            Close();
        }

        private void disBtn_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
