using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace CoreShop.Models
{
    [Table("Adress")]
    public class Adress
    {
        [Key] 
        public int IdAddress { get; set; }

        public string Address { get; set; }

        public string Address2 { get; set; }

        public string City { get; set; }

        public int PostCode { get; set; }

        public string Country { get; set; }

        //ArrayList AdressArray= new ArrayList();
        

    }
}
