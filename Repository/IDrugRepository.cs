using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public interface IDrugRepository
    {
        /*name- string the name of the drug
         * returns a list of Drug object with given name
         */
        List<Drug>filter(string name);
    }
}
