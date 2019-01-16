using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreShop.Models
{
    [Table("Category")]

    public class Category
    {
        [Key]
        public int CategoryId { get; set; }

        public string CategoryLib { get; set; }

        //iditem -> categoryItem
    }
}
