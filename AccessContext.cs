using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Homework17version1._1
{
    class AccessContext : DbContext
    {
        public AccessContext() : base("DbConnectionAccess")
        { }
        public DbSet<ModelAccess> ModelAccessNew { get; set; }
    }
}
