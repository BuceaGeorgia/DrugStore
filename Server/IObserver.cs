
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface IObserver
    {
        /*
         * Updates the data from controller with the new list when a new order is taken
         */ 
        void UpdateData(List<Order> all);

        /*
         * Updates the data from controller with the new list when a new order is placed
         */
        void UpdateData2(List<Order> all);
    }
}
