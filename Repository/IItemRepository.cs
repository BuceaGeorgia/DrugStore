using Model;

namespace Repository
{
    public interface IItemRepository

    {


        /* int id - the id of the drug
         * int quantity- the drug quantity
         * int orderid- the id of the order (foreign key)
         * adds a new item to database and returns the inserted item or null if not succesful
         */

        Item add(int drugid, int quantity, int orderid);
    }
}
