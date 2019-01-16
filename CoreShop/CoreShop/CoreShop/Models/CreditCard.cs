using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CoreShop.Models
{
    [Table("CreditCard")]
    public class CreditCard
    {
        [Key]
        public int CardId { get; set; }

        public int CardNumber { get; set; }

        public string CardOwner { get; set; }

        public int CardSecurityCode { get; set; }

        public DateTime CardExpirationDate{ get; set; }
        
    }
}
