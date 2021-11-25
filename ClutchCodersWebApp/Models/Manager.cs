using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        [StringLength(10)]
        public string PhoneNo { get; set; }

        public string Email { get; set; }

        public Boolean IsEmployee { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

    }
}
