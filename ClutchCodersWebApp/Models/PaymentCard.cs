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
        public int Id { get; set; }

        [Required, StringLength(30)]
        public string NameOnCard { get; set; }
        [Required]
        public int ExpiryDate { get; set; }
        [Required]
        public string SecurityCode { get; set; }
        //
        // PERSONID MAYBE REMOVE
        //
        [Required]
        public int PersonId { get; set; }

    }
}
