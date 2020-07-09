using Model;
using System.Data.Entity;

namespace Repository
{
    public class MyContext : DbContext
    {
        public MyContext(string db) : base("name=" + db) { }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Drug> Drugs { get; set; }
        public virtual DbSet<Item> Items { get; set; }

    }

}
