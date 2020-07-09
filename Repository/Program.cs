using Model;
using System;
using System.Linq;
namespace Repository
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new MyContext("farmacie2"))
            {
                Drug d = new Drug { Category = Category.vitamin, Description = "Pastile", Name = "Nurofen", Price = float.Parse("0.5") };
                User u = new User { Password = "user", Username = "user", Status = Status.Admin };

                db.Drugs.Add(d);
                db.SaveChanges();

                var query = from b in db.Users
                            orderby b.Username
                            select b;

                Console.WriteLine("All users in the database:");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Status);
                }
            }
        }
    }
}
