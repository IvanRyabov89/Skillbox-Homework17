using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Data.Entity.Migrations;

namespace Homework17version1._1
{
    class SqlConnections
    {
        public AccessContext ProductContext { get; private set; }
        public SQLContext UserContext { get; private set; }

        public List<ModelSQL> ListUsers { get; private set; }
        public List<ModelAccess> ListProducts { get; private set; }
        public List<Order> ListInitialOrders { get; private set; }
        //public List<LINQOrder> ListOrders { get; private set; }

        public SqlConnections()
        {
            ListUsers = new List<ModelSQL>();
            ListProducts = new List<ModelAccess>();
            //ListOrders = new List<LINQOrder>();
            ListInitialOrders = new List<Order>();
            UserContext = new SQLContext();
            ProductContext = new AccessContext();
        }

        public void SelectProducts()
        {
            ListProducts = ProductContext.ModelAccessNew.ToList();
        }

        public void SelectUsers()
        {
            ListUsers = UserContext.ModelSQLNew.ToList();
        }

       
        public void SelectOrders()
        {
            ListInitialOrders = UserContext.Orders.ToList();
            //ListOrders = new List<LINQOrder>();
            //foreach (var l in ListInitialOrders)
            //{
            //    ListOrders.Add(new LINQOrder()
            //    {
            //        Id = l.OrderID,
            //        Email = ListUsers.Find(e => e.ModelSQLID == l.UserId).Email,
            //        NameProduct = ListProducts.Find(e => e.ModelAccessID == l.ProductId).NameProduct,
            //        Count = l.ProductCount
            //    });
            //}
        }
        #region Remove
        /// <summary>
        /// Удаление выбранной строки
        /// </summary>
        /// <param name="item"></param>
        public void Remove(ModelSQL item)
        {
            UserContext.ModelSQLNew.Remove(item);
            UserContext.SaveChanges();
            SelectUsers();
        }
        /// <summary>
        /// Удаление выбранной строки
        /// </summary>
        /// <param name="item"></param>
        public void Remove(Order item)
        {
            UserContext.Orders.Remove(item);
            UserContext.SaveChanges();
            SelectOrders();
        }
        /// <summary>
        /// Удаление выбранной строки
        /// </summary>
        /// <param name="item"></param>
        public void Remove(ModelAccess item)
        {
            ProductContext.ModelAccessNew.Remove(item);
            ProductContext.SaveChanges();
            SelectProducts();
        }
        #endregion

        #region Create/Update
        /// <summary>
        /// Добавление или обновление строки
        /// </summary>
        /// <param name="item"></param>
        public void CreateOrUpdate(ModelSQL item)
        {
            UserContext.ModelSQLNew.AddOrUpdate(item, item);
            UserContext.SaveChanges();
        }
        /// <summary>
        /// Добавление или обновление строки
        /// </summary>
        /// <param name="item"></param>
        public void CreateOrUpdate(Order item)
        {
            UserContext.Orders.AddOrUpdate(item, item);
            UserContext.SaveChanges();
        }
        /// <summary>
        /// Добавление или обновление строки
        /// </summary>
        /// <param name="item"></param>
        public void CreateOrUpdate(ModelAccess item)
        {
            ProductContext.ModelAccessNew.AddOrUpdate(item);
            ProductContext.SaveChanges();
        }
        #endregion
    }
}
