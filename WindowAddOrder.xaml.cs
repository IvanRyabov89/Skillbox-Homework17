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
    /// Логика взаимодействия для WindowAddOrder.xaml
    /// </summary>
    public partial class WindowAddOrder : Window
    {
        private SqlConnections sql = new SqlConnections();
        public SQLContext UserContext { get; private set; }
        private Order Data;
        public WindowAddOrder(ref Order data, List<ModelAccess> ProductList)
        {
            Data = data;
            InitializeComponent();
            product.ItemsSource = ProductList;
            if (data != null)
            {
                quantity.Text = $"{data.ProductCount}";
                product.Text = $"";
                foreach (ModelAccess p in ProductList)
                {
                    //if (data.ProductId == p.ModelAccessID)
                    //{
                    //    product.Text = p.ToString();
                    //    break;
                    //}
                    product.Text = p.ToString();
                }
            }
        }

 
        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {
            if (product.SelectedValue != null)
            {
                ModelAccess products = (ModelAccess)product.SelectedItem;
                //Data.ProductId = products.ModelAccessID;
                Data.ProductCount = quantity.Text;
                Data.NameProduct = product.Text;

                //Order model = new Order($"{elements[0]}", $"{tbFirst.Text}", $"{tbPatronymic.Text}", $"{tbPhone.Text}", $"{tbEmail.Text}");

                //sql.CreateOrUpdate(model);
                //DataPage data = new DataPage();
                //data.SelectOrders();
            }
            Close();
        }

        private void CancelOrder_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
