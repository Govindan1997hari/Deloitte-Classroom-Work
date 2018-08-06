using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace ConsoleApplication1
{
    class PizzaDBEntities:DbContext
    {
        public DbSet<Pdetails> PizzaDetails { get; set; }
        public PizzaDBEntities():base("MyDB")
        { }

    }
}
