using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Order
    {

        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter a name that is 1-30 characters long")]
        [StringLength(30)]
        [Display(Name = "Full name")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Please enter your phone number")]
        [StringLength(25)]
        public string PhoneNo { get; set; }

        [Required(ErrorMessage = "Please enter your post code")]
        [StringLength(10)]
        public string Postcode { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Delivery Date")]
        public Nullable<DateTime> DeliveryDate { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Order Date")]
        public DateTime OrderDate { get; set; }

        //full name//contact number//post code//order date//delivery date

    }
}
