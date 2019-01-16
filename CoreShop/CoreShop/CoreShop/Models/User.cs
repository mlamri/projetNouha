using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;


namespace CoreShop.Models

{
    [Table("User")]

    public class User
    {
        [Key]
        public int UserId { get; set; }

        public string UserName { get; set; }

        public string UserLastName { get; set; }

        public string UserGender { get; set; }

        public DateTime UserBirthDate { get; set; }

        public int UserFixPhone { get; set; }

        public int UserMobilePhone { get; set; }

        [EmailAddress, Required]
        public string UserEmail { get; set; }

        [MinLength(8)]
        public string Password { get; set; }
        //adresse tableau

    }
}
