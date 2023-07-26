using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17version1._1
{
    public class Order
    {
        
        public Order( string LastName, string Name, string MiddleName, string Email, string NameProduct, string ProductCount)
        {
            //this.userid = UserId;
            //this.productid = ProductId;
            this.lastName = LastName;
            this.name = Name;
            this.middleName = MiddleName;
            this.email = Email;
            //this.codeProduct = CodeProduct;
            this.nameProduct = NameProduct;
            this.productCount = ProductCount;
        }
        public Order() { }
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderID { get; set; }
        private string lastName;
        private string name;
        private string middleName;
        private string email;
        private string nameProduct { get; set; }
        private string productCount { get; set; }
        
        public string LastName  { get { return lastName; } set { lastName = value; } } 
        public string Name { get { return name; } set { name = value; } }
        public string MiddleName { get { return middleName; } set { middleName = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }
        public string ProductCount { get { return productCount; } set { productCount = value; } }
        
        public override string ToString()
        {
            return $"{OrderID},{lastName},{name},{middleName},{email},{nameProduct},{productCount}";
        }
    }
    //public class LINQOrder
    //{
    //    public int Id { get; set; }
    //    public string LastName { get; set; }
    //    public string Name { get; set; }
    //    public string MiddleName { get; set; }
    //    public string Email { get; set; }
    //    public string NameProduct { get; set; }
    //    public int Count { get; set; }
    //}
}
