using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; } 


        [Required, StringLength(25)]
        public string Name { get; set; }


        [StringLength(255)]
        public string URL { get; set; }


        [Required]
        public int Category { get; set; }

    }
}
