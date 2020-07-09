using Model;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controller.Controller
{
   public class ClientController : MarshalByRefObject, IObserver
    {
        private readonly IServices server;
        public User user = null;
        public List<Item> currOrder;
        public event EventHandler<UserEventArgs> updateEvent;
        public  ClientController(IServices s)
        {
            server = s;
        }
        
        public User login(string username,string password)
        {
           user = server.login(username, password, this);
            return user;         
        }
        public bool takeOrder(int id)
        {
            return server.take_order(user,id);
        }
        public List<Order> getOrders()
        {
            return server.getallorders();
        }
        public List<Order> getOrdersPharmacist()
        {
            return server.filterpharmacist();
        }

        public List<Order> getMedicalStaff(int idsectie)
        {
            return server.filterMedicalStaff(idsectie);
        }
        public void place_order()
        {
            server.place_order(user,currOrder,user.SectieID);
            currOrder.Clear();
        }

        public void add_user(string username, string password, Status status,String section)
        {
            
            if (server.addUser(username, password, status,section) == null)
                throw new Exception("User is already registered");
        }
        public void logout()
        {
            Console.WriteLine("Ctrl logout");
            server.logout(user, this);
            user = null;
        }
        public void additem(string drugid,string quantity)
        {
            int id = int.Parse(drugid);
            int q = int.Parse(quantity);
            if (currOrder == null)
                currOrder = new List<Item>();
            Item i = new Item { DrugID = id, Quantity = q};
            currOrder.Add(i);
        }
        public List<User> getalluser()
        {
            return server.getallusers();
        }

        public List<Drug> filter(string name)
        {
            List<Drug> dr= server.filterdrugs(name);
            return dr;
        }

        protected virtual void OnUserEvent(UserEventArgs e)
        {
            if (updateEvent == null) return;
            updateEvent(this, e);
            Console.WriteLine("Update Event called");
        }
        public void UpdateData2(List<Order> all)
        {
            UserEventArgs userArgs = new UserEventArgs(UserEvent.TAKE_ORDER, all);
            OnUserEvent(userArgs);
        }
        public void UpdateData(List<Order> all)
        {
            UserEventArgs userArgs = new UserEventArgs(UserEvent.PLACED_ORDER, all);
            OnUserEvent(userArgs);
        }
    }
}
