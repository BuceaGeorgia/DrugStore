using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    [Serializable]
    public  class Item
    {
        public Item() { }
        [Key]
        public int  ItemID { get ; set ; }

        [ForeignKey("Drug")]
        public int DrugID { get; set; }
        public int Quantity { get; set ; }
        
        [ForeignKey("Order")]
        public int OrderID { get; set; }

        public virtual Drug Drug { get; set; }
        public virtual Order Order { get; set; }
    }
}
