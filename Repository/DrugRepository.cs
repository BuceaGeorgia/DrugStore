using Model;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class DrugRepository : IDrugRepository
    {
        private string dbcon;
        public DrugRepository(string dbname) { dbcon = dbname; }
        public List<Drug> filter(string name)
        {
            using (var v = new MyContext(dbcon))
            {
                List<Drug> dictionary = v.Drugs.Where(x => x.Name == name).ToList();

                return dictionary;
            }
        }

    }
}
