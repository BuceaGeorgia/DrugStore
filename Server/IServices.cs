using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IServices
    {
        /*string user, string password,IObserver us
        *
        * returns the logged in use or error if the user does not exist
        */
        User login(string user, string password,IObserver us);

        /*
        *string username, string password, Status status,string section
        * adds a new user, returns the given user or null if it does not exst
        */
   
        User addUser(string username, string password, Status status,string section);

        /*
        * returns a list of all the orders
        */
        List< Order> getall();

        /*
        * returns a list with all the users
        */
        List<User> getallusers();

        /*
        * returns a list with all the orders
        */
        List<Order> getallorders();

        /*
         * returns a list of orders that have status as: delivered
         */
        List<Order> filterpharmacist();

        /*User user- username(id) of user
         * IObserver client
         * 
         * removes an observer with given id from the list
         */
        void logout(User user, IObserver client);

        /*
         * 
        *returns a list of orders placed from the given section
        */ 
        List<Order> filterMedicalStaff(int sectieid);

        /*
         * User -us the user to be notified about the placed order
         * List<Item>all -list of order items
         * int sectieId -id of the section that places the order
         * 
         * inserts new order in database
         * notifies the user
         */
        void place_order(User us,List<Item>all,int sectieId);

        /*
         * User us -the current user
         * int id  -id of the order
         * 
         * modifies the status of the order with given id into finished
         * updates the data of the user
         */
        bool take_order(User us,int id);

        /*name- string the name of the drug
         * returns a list of Drug object with given name
         */
        List<Drug> filterdrugs(string name);

    }
}
