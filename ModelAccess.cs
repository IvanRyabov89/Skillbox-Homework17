using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework17version1._1
{
    public class ModelAccess
    {
        public ModelAccess(string Email, string CodeProduct, string NameProduct)
        {
            this.email = Email;
            this.code = CodeProduct;
            this.nameProduct = NameProduct;
        }
        public ModelAccess() { }
        public int ModelAccessID { get; set; }
        private string email;
        private string code;
        private string nameProduct;
        public string Email { get { return email; } set { email = value; } }
        public string CodeProduct { get { return code; } set { code = value; } }
        public string NameProduct { get { return nameProduct; } set { nameProduct = value; } }

        public override string ToString()
        {
            return $" {nameProduct,15}";
        }

    }
}
