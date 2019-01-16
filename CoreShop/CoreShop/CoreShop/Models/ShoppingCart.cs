using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace CoreShop.Models
{
    [Table("ShoppingCart")]
    public class ShoppingCart
    {
        [Key]
        public int IdCart { get; set; }

        public string item { get; set; } //array article

        public int Amount { get; set; }

        public int Price { get; set; }
    }
}
