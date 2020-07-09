using Model;

namespace Repository
{
    public class ItemRepository : IItemRepository
    {
        string dbcon;
        public ItemRepository(string dbname) { dbcon = dbname; }

        public Item add(int drugid, int quantity, int orderid)
        {

            using (var v = new MyContext(dbcon))
            {

                Item it = new Item();
                it.DrugID = drugid;
                it.OrderID = orderid;
                it.Quantity = quantity;

                v.Items.Add(it);
                v.SaveChanges();
                return it;

            }
            return null;

        }
    }
}
