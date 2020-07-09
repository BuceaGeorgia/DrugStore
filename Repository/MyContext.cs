using Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
   public class MyContext : DbContext
    {
        public MyContext(string db) : base("name="+db) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        
    }

}
