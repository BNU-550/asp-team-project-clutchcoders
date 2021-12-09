using System;
using System.ComponentModel.DataAnnotations;

namespace ClutchCodersWebApp.Models
{

    public class Customer
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
        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Required, StringLength(20, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        public string LastName { get; set; }

    }
}
