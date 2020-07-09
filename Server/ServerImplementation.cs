using Model;
using Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Server
{
    class ServerImplementation : MarshalByRefObject, IServices
    {

        IUserRepository userrepo;
        IOrderRepository orderrepo;
        IDrugRepository drugrepo;
        IItemRepository itemrepo;
        private readonly IDictionary<int, IObserver> loggedClients;

        public ServerImplementation(IUserRepository ur, IOrderRepository or, IDrugRepository dr, IItemRepository itemrepo)
        {
            this.userrepo = ur;
            this.orderrepo = or;
            this.drugrepo = dr;
            this.itemrepo = itemrepo;
            loggedClients = new Dictionary<int, IObserver>();
        }


        public User login(string user, string password, IObserver ob)
        {

            User u = this.userrepo.findOne(user, password);
            if (u != null)
            {
                if (loggedClients.ContainsKey(u.UserID))
                    throw new AppException("User is logged in");
                loggedClients[u.UserID] = ob;
                return u;
            }
            else
            {
                throw new AppException("Incorrect User!");
            }

        }
        private void notifytakeorder(User user)
        {

            foreach (int us in loggedClients.Keys)
            {
                User u = userrepo.find(us);
                if (us != user.UserID && u.Status == Status.MedicalStaff)
                {

                    Task.Run(() => loggedClients[us].UpdateData2(filterMedicalStaff(u.SectieID)));
                }
            }
        }
        private void notifyplaceorder(User user)
        {

            foreach (int us in loggedClients.Keys)
            {
                User u = userrepo.find(us);
                if (us != user.UserID && u.Status == Status.Pharmacist)
                {

                    Task.Run(() => loggedClients[us].UpdateData(filterpharmacist()));
                }
            }
        }
        public List<Order> getall()
        {

            return orderrepo.getall();
        }

        public User addUser(string username, string password, Status status, string section)
        {
            try
            {
                int sect = Int32.Parse(section);
                return userrepo.add(username, password, status, sect);
            }
            catch (Exception ex)
            {
                return null;
            }

        }

        public List<Drug> filterdrugs(string name)
        {
            return drugrepo.filter(name);
        }
        public List<User> getallusers()
        {
            return userrepo.getall();
        }
        public List<Order> getallorders()
        {
            return orderrepo.getall();
        }
        public List<Order> filterpharmacist()
        {
            return orderrepo.filterPharmacist();
        }
        public List<Order> filterMedicalStaff(int sectieid)
        {
            return orderrepo.filterMedicalStaff(sectieid);
        }
        public void place_order(User us, List<Item> it, int sectieId)
        {
            Order o = orderrepo.add(DateTime.Now, sectieId);

            foreach (var el in it)
            {

                itemrepo.add(el.DrugID, el.Quantity, o.OrderID);

            }
            notifyplaceorder(us);
        }

        public bool take_order(User us, int id)
        {
            Order o = orderrepo.modify(id);

            if (o == null)
                return false;
            notifytakeorder(us);
            return true;
        }

        public void logout(User user, IObserver client)
        {
            IObserver localClient = loggedClients[user.UserID];
            if (localClient == null)
                throw new Exception("User " + user.UserID + " is not logged in.");

            loggedClients.Remove(user.UserID);

        }

        public override object InitializeLifetimeService()
        {
            return null;
        }
    }
}
