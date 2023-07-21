using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Homework17version1._1
{
    public partial class SQLContext : DbContext
    {
        public SQLContext() : base("DbConnection")
        { }
        public virtual DbSet<ModelSQL> ModelSQLNew { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
    }
}
