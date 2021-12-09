using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Basket
    {
        [Key]
        public int Id { get; set; }


        [Required]
        public DateTime OrderDate { get; set; }


        [Required]
        public DateTime DeliveryDate { get; set; }

    }
}