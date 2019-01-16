using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    [Table("Photo")]
    public class Photo
    {
        [Key]
        public int PhotoId { get; set; }

        public image PhotoLink { get; set; }

        //article
        
    }
}
