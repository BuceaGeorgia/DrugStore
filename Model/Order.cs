using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public enum OrderStatus
    {
        finished,delivered
    }
    [Serializable]
    public  class Order
    {
        public Order() { }
        [Key]
        public int OrderID { get; set; }
        public int SectieID { get; set; }
        public OrderStatus Status { get; set; }

        public DateTime Date { get; set; }

        [NotMapped]
        public virtual ICollection<Item> Items { get; set; }
    }
}
