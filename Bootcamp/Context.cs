using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bootcamp
{
    class Context : DbContext
    {
        public Context(): base("MyContext") { }

        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Item> Item { get; set; }
  
    }
}
