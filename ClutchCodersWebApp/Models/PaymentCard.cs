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
        [StringLength(20)]
        //[DataType(DataType.CreditCard)]
        public string CardNumber { get; set; }


        [Required]
        [StringLength(30)]
        [Display(Name = "Name on card")]
        public string NameOnCard { get; set; }


        [Required]
        [Range(2021,2030)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiry Year")]
        public int ExpiryYear { get; set; }

        [Required]
        [Range(1, 12)]
        //[DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expiry Month")]
        public int ExpiryMonth { get; set; }


        [Required]
        [StringLength(3)]
        public string SecurityCode { get; set; }

    }
}
