using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class PaymentCard
    {
        [Key]
        public int CardId { get; set; }


        [Required]
        public int CardNumber { get; set; }


        [Required, StringLength(30)]
        public string NameOnCard { get; set; }


        [Required]
        public DateTime ExpiryDate { get; set; }


        [Required]
        public string SecurityCode { get; set; }


        //
        // PERSONID MAYBE REMOVE
        //
        [Required]
        public int PersonId { get; set; }

    }
}
