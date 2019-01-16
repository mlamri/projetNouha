using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreShop.Models
{
    [Table("Item")]
    public class Item
    {
        [Key]
        public int ItemId { get; set; }

        public string Itemlib { get; set; }

        public int ItemPrice { get; set; }

        public string ItemDescription { get; set; }

        //Photo..
        public string ItemState { get; set; }
    }
}
