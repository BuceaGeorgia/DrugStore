using Model;
using System;
using System.Collections.Generic;

namespace Repository
{
    public interface IOrderRepository
    {
        //returns a list of orders  from database ordered by date
        List<Order> getall();

        /*DateTime dt, the date when the order was placed
        * int sectieId, the section that made the order
        *
        * Adds a new order to database and returns the order
        * 
        */
        Order add(DateTime dt, int sectieId);


        /*int sectieid- a given section number
        * 
        * returns a list of orders placed from the given section
        */
        List<Order> filterMedicalStaff(int sectieid);

        /*
        * 
        * returns a list of orders that have status as: delivered
        */
        List<Order> filterPharmacist();

        /*
       * int idOrder
       * 
       * returns the order with given id or null if it 
       */
        Order find(int idOrder);

        /*
       * int idOrder
       * 
       * modifies the status of an order into: finished
       * if the operation is not succesful returns null
       */
        Order modify(int idOrder);

        /*
         * int idOrder
         * deletes an order with a given id
         */
        Order delete(int idOrder);

    }
}

