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


        [Required, StringLength(10)]
        public string OrderDate { get; set; }


        [Required, StringLength(10)]
        public string DeliveryDate { get; set; }

    }
}