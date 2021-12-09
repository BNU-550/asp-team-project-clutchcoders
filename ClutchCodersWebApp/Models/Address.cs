using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }


        [Required, StringLength(50)]
        public string FirstLine { get; set; }


        [Required, StringLength(50)]
        public string SecondLine { get; set; }


        [Required]
        public int CustomerId { get; set; }


        [Required, StringLength(10)]
        public string Postcode { get; set; }


        //
        // PERSONID MAYBE REMOVE
        //
        [Required]
        public int PersonId { get; set; }

    }
}
