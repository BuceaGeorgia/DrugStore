using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Model
{
    public enum Category
    {
        tablet, syrup, vitamin
    }
    [Serializable]
    public class Drug : MarshalByRefObject
    {
        public Drug() { }
        [Key]
        public int DrugID { get; set ; }
        public string Name { get; set; }
        public Category Category { get; set ; }
        public float Price { get; set; }
        public string Description { get ; set ; }

        public virtual ICollection<Item> Item { get; set; }
    }
}
