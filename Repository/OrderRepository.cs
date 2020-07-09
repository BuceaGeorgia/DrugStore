using Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class OrderRepository : IOrderRepository
    {
        private string dbcon;
        public OrderRepository(string dbname) { dbcon = dbname; }
        public List<Order> getall()
        {

            using (var v = new MyContext(dbcon))
            {
                List<Order> dictionary = v.Orders.OrderByDescending(o => o.Date).ToList();

                return dictionary;
            }

        }
        public List<Order> filterMedicalStaff(int sectieid)
        {

            using (var v = new MyContext(dbcon))
            {
                List<Order> dictionary = v.Orders.Where(x => x.SectieID == sectieid).ToList();

                return dictionary;
            }

        }

        public List<Order> filterPharmacist()
        {

            using (var v = new MyContext(dbcon))
            {

                List<Order> dictionary = v.Orders.Where(x => x.Status == OrderStatus.delivered).ToList();

                return dictionary;
            }

        }
        public Order add(DateTime dt, int sectieId)
        {

            using (var v = new MyContext(dbcon))
            {
                Order o = new Order();
                o.Date = dt;
                o.SectieID = sectieId;
                o.Status = OrderStatus.delivered;
                v.Orders.Add(o);
                v.SaveChanges();
                return o;
            }
        }

        public Order find(int idOrder)
        {
            using (var v = new MyContext(dbcon))
            {
                Order o = v.Orders.First(c => c.OrderID == idOrder);
                return o;
            }
            return null;
        }
        public Order modify(int idOrder)
        {
            using (var v = new MyContext(dbcon))
            {
                var result = v.Orders.SingleOrDefault(b => b.OrderID == idOrder);
                if (result != null)
                {
                    result.Status = OrderStatus.finished;
                    v.SaveChanges();
                    return result;
                }
            }
            return null;
        }
        public Order delete(int idOrder)
        {
            using (var v = new MyContext(dbcon))
            {
                Order us = find(idOrder);
                if (us != null)
                {
                    v.Orders.Attach(us);
                    v.Orders.Remove(us);
                    v.SaveChanges();
                    return us;
                }
            }
            return null;
        }
    }
}
