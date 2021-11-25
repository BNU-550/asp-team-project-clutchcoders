using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(25)]
        public string PhoneNo { get; set; }
        [Required, StringLength(30)]
        public string Email { get; set; }
        [Required]
        public Boolean IsEmployee { get; set; }
        [Required, StringLength(20)]
        public string FirstName { get; set; }
        [Required, StringLength(20)]
        public string LastName { get; set; }

    }
}
