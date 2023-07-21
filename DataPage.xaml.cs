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

namespace Homework17version1._1
{
    /// <summary>
    /// Логика взаимодействия для DataPage.xaml
    /// </summary>
    public partial class DataPage : Page
    {
        private SqlConnections sql = new SqlConnections();
        private ModelAccess CurrentProduct;
        private ModelSQL CurrentUser;
        private Order CurrentOrder;

        public DataPage()
        {
            InitializeComponent();
            SelectProducts();
            SelectUsers();
            SelectOrders();
        }


        //SQLContext context = new SQLContext();
        //AccessContext contextTwo = new AccessContext();
        //List<Order> orders = new List<Order>();
        //public List<LINQOrder> ListOrders { get; private set; }
        //public List<Order> ListInitialOrders { get; private set; }
        //public List<ModelSQL> sql { get; private set; }
        //public List<ModelAccess> access { get; private set; }
        public void SelectProducts()
        {
            sql.SelectProducts();
            DGProducts.ItemsSource = sql.ListProducts;
        }
        public void SelectUsers()
        {
            sql.SelectUsers();
            DGClients.ItemsSource = sql.ListUsers;
        }
        public void SelectOrders()
        {
            sql.SelectOrders();
            date.ItemsSource = sql.ListInitialOrders;
           
        }
        //public DataPage()
        //{
        //    InitializeComponent();

        //    orders = new List<Order>();

        //    ModelSQL modelOne = new ModelSQL("Васильев", "Игорь", "Аркадьевич", "88009014527", "vasiliev.@mail.ru");
        //    ModelSQL modelTwo = new ModelSQL("Сергеев", "Олег", "Иванович", "88009014527", "sergeev.@mail.ru");
        //    sql = new List<ModelSQL>() { modelOne, modelTwo };
        //    //foreach (var Item in sql)
        //    //{
        //    //    context.ModelSQLNew.Add(Item);
        //    //}

        //    context.SaveChanges();
        //    ModelAccess modelAccessOne = new ModelAccess("vasiliev.@mail.ru", "11", "Samsung fx17");
        //    ModelAccess modelAccessTwo = new ModelAccess("sergeev.@mail.ru", "20", "Audi Q7");
        //    access = new List<ModelAccess>() { modelAccessOne, modelAccessTwo };
        //    //foreach (var ItemNew in access)
        //    //{
        //    //    contextTwo.ModelAccessNew.Add(ItemNew);
        //    //}
        //    contextTwo.SaveChanges();

        //    context.ModelSQLNew.Load();
        //    DGClients.ItemsSource = context.ModelSQLNew.Local.ToBindingList<ModelSQL>();

        //    contextTwo.ModelAccessNew.Load();
        //    DGProducts.ItemsSource = contextTwo.ModelAccessNew.Local.ToBindingList<ModelAccess>();

        //    //var info = context.ModelSQLNew.Join(contextTwo.ModelAccessNew,
        //    //    ModelSQL => ModelSQL.Email,
        //    //    ModelAccess => ModelAccess.Email,
        //    //    (ModelSQL, ModelAccess) => new
        //    //    {
        //    //        ModelSQL.ModelSQLID,
        //    //        ModelSQL.LastName,
        //    //        ModelSQL.Name,
        //    //        ModelSQL.MiddleName,
        //    //        ModelSQL.Email,
        //    //        ModelAccess.CodeProduct,
        //    //        ModelAccess.NameProduct
        //    //    }).ToArray();

        //    //ListInitialOrders = SQLContext.ModelSQLNew.ToList();
        //    //orders = new List<Order>();
        //    //foreach (var l in ListInitialOrders)
        //    //{
        //    //    ListOrders.Add(new LINQOrder()
        //    //    {
        //    //        Id = l.Id,
        //    //        Email = ListUsers.Find(e => e.Id == l.Id).Email,
        //    //        Product = ListProducts.Find(e => e.Id == l.ProductId).ProductName,
        //    //        Count = l.ProductCount
        //    //    });
        //    //}
        //    //var info = (from ModelSQLNew in context.ModelSQLNew
        //    //            join ModelAccessNew in contextTwo.ModelAccessNew on
        //    //    ModelSQLNew.Email equals ModelAccessNew.Email
        //    //            select ModelSQLNew.Email).ToArray();

        //    //var infoNew = from ModelAccessNew in contextTwo.ModelAccessNew
        //    //              join ModelSQLNew in context.ModelSQLNew on
        //    //    ModelAccessNew.Email equals ModelSQLNew.Email
        //    //              select new { Email = ModelSQLNew.Email };
        //    //DGPurchases.ItemsSource = info.ToList();
        //    //try
        //    //{
        //    //    DGPurchases.ItemsSource = info.ToList();
        //    //}
        //    //catch (Exception ex) { MessageBox.Show(ex.Message); }
        //}
        private void MenuItemAdd_Click(object sender, RoutedEventArgs e)//клиенты
        {
            //WindowAdd add = new WindowAdd();
            //add.ShowDialog();

            //if (add.DialogResult.Value)
            //{
            //    DGClients.ItemsSource = context.ModelSQLNew.Local.ToBindingList<ModelSQL>();
            //}
        }
        private void MenuItemDelete_Click(object sender, RoutedEventArgs e)//клиенты
        {
            //dataRowView = (DataRowView)DGClients.SelectedItem;
            //dataRowView.Row.Delete();
            //adapterSql.Update(dataTableSql);
        }
        private void MenuAdd_Click(object sender, RoutedEventArgs e)//клиенты
        {
            //WindowAddTwo add = new WindowAddTwo();
            //add.ShowDialog();
            //if (add.DialogResult.Value)
            //{
            //    DGProducts.ItemsSource = contextTwo.ModelAccessNew.Local.ToBindingList<ModelAccess>();
            //}
        }
        private void MenuDelete_Click(object sender, RoutedEventArgs e)//клиенты
        {
            //dataRowView = (DataRowView)DGClients.SelectedItem;
            //dataRowView.Row.Delete();
            //adapterSql.Update(dataTableSql);
        }
        #region SelectionChanged
        private void DGClients_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = DGClients.SelectedItem;
            if (item != null) CurrentUser = (ModelSQL)item;
        }

        private void DGProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = DGProducts.SelectedItem;
            if (item != null) CurrentProduct = (ModelAccess)item;
        }

        private void date_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object item = date.SelectedItem;
            if (item != null) CurrentOrder = (Order)item;
        }
        #endregion

        #region Create
        /// <summary>
        /// Определение первого свободного Id
        /// </summary>
        /// <param name="item"></param>
        private void SetID(ModelSQL item)
        {
            item.ModelSQLID = 1;
            List<ModelSQL> list = (sql.ListUsers.OrderBy(i => i.ModelSQLID)).ToList();
            for (int i = 0; i < sql.ListUsers.Count; i++)
            {
                if (list[i].ModelSQLID == item.ModelSQLID) item.ModelSQLID++;
                else break;
            }
        }
        /// <summary>
        /// Определение первого свободного Id
        /// </summary>
        /// <param name="item"></param>
        private void SetID(ModelAccess item)
        {
            item.ModelAccessID = 1;
            List<ModelAccess> list = (sql.ListProducts.OrderBy(i => i.ModelAccessID)).ToList();
            for (int i = 0; i < sql.ListProducts.Count; i++)
            {
                if (list[i].ModelAccessID == item.ModelAccessID) item.ModelAccessID++;
                else break;
            }
        }
        /// <summary>
        /// Определение первого свободного Id
        /// </summary>
        /// <param name="item"></param>
        private void SetID(Order item)
        {
           
            item.OrderID = 1;
            List<Order> list = (sql.ListInitialOrders.OrderBy(i => i.OrderID)).ToList();
            for (int i = 0; i < sql.ListInitialOrders.Count; i++)
            {
                
                if (list[i].OrderID == item.OrderID)
                {
                    MessageBox.Show($"{item.OrderID}");
                    item.OrderID++;
                    MessageBox.Show($"{item.OrderID}");
                }
                else break;
            }
        }
        private void AddClients_Click(object sender, RoutedEventArgs e)
        {
            CurrentUser = new ModelSQL();
            WindowAdd wnd = new WindowAdd(ref CurrentUser);
            wnd.ShowDialog();
            //if (CurrentUser.Email == null) return;
            SetID(CurrentUser);
            sql.CreateOrUpdate(CurrentUser);
            SelectUsers();
        }

        private void AddProducts_Click(object sender, RoutedEventArgs e)
        {
            CurrentProduct = new ModelAccess();
            WindowAddTwo wnd = new WindowAddTwo(ref CurrentProduct);
            wnd.ShowDialog();
            SetID(CurrentProduct);
            sql.CreateOrUpdate(CurrentProduct);
            SelectProducts();
        }

        private void AddDate_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUser == null)
            {
                MessageBox.Show("Пользователь не выбран");
                return;
            }
            CurrentOrder = new Order();
            WindowAddOrder wnd = new WindowAddOrder(ref CurrentOrder, sql.ListProducts);
            wnd.ShowDialog();
            //if (CurrentOrder.ProductId == 0) return;

            SetID(CurrentOrder);
            CurrentOrder.LastName = CurrentUser.LastName;
            CurrentOrder.Name = CurrentUser.Name;
            CurrentOrder.MiddleName = CurrentUser.MiddleName;
            CurrentOrder.Email= CurrentUser.Email;
            sql.CreateOrUpdate(CurrentOrder);
            SelectOrders();
        }
        #endregion

        #region Update

        private void UpdateClients_Click(object sender, RoutedEventArgs e)
        {
                if (CurrentUser == null)
                {
                    MessageBox.Show("Пользователь не выбран");
                    return;
                }
                WindowAdd wnd = new WindowAdd(ref CurrentUser);
                wnd.ShowDialog();
                sql.CreateOrUpdate(CurrentUser);
                SelectUsers();
        }

        private void UpdateProducts_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentProduct == null)
            {
                MessageBox.Show("Продукт не выбран");
                return;
            }
            WindowAddTwo wnd = new WindowAddTwo(ref CurrentProduct);
            wnd.ShowDialog();
            sql.CreateOrUpdate(CurrentProduct);
            SelectProducts();
        }

        private void UpdateDate_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOrder == null)
            {
                MessageBox.Show("Заказ не выбран");
                return;
            }
            WindowAddOrder wnd = new WindowAddOrder(ref CurrentOrder, sql.ListProducts);
            wnd.ShowDialog();
            sql.CreateOrUpdate(CurrentOrder);
            SelectOrders();
        }
        #endregion

        #region Delete
        private void DeleteClients_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentUser == null) return;
            sql.Remove(CurrentUser);
            SelectUsers();
        }

        private void DeleteProducts_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentProduct == null) return;
            sql.Remove(CurrentProduct);
            SelectProducts();
        }

        private void DeleteDate_Click(object sender, RoutedEventArgs e)
        {
            if (CurrentOrder == null) return;
            sql.Remove(CurrentOrder);
            SelectOrders();
        }
        #endregion
    }
}
