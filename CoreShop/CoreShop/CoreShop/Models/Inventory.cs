using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    [Table("Inventory")]
    public class Inventory
    {
        [Key]
        public int InventoryId { get; set; }

        public DateTime InventoryDateTime{ get; set; }
    }
}
