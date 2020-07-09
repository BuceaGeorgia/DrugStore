using Model;
using System.Collections.Generic;

namespace Repository
{
    public interface IDrugRepository
    {
        /*name- string the name of the drug
         * returns a list of Drug object with given name
         */
        List<Drug> filter(string name);
    }
}
