using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClutchCodersWebApp.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Required, StringLength(20)]
        public string Name { get; set; }

        //ModelNo might be unnecessary
        public int ModelNo { get; set; }


        [Required, StringLength(10)]
        public string EngineSize { get; set; }


        [Required, StringLength(10)]
        public string Type { get; set; }


        [Required, StringLength(10)]
        public string Brand { get; set; }


        [Required, StringLength(10)]
        public string FuelType { get; set; }


        [Required, StringLength(10)]
        public string FuelCapacity { get; set; }


        [Required, StringLength(15)]
        public string Dimensions { get; set; }


        [Required(ErrorMessage = "Please enter a year between 1900 - 2025")]
        [Range(1900, 2025)]
        public int Year { get; set; }


        [Required(ErrorMessage = "Please enter a price between £0 - £50000")]
        [Range(0, 50000)]
        public decimal Price { get; set; }

        //Navigation property
        
        public virtual ICollection<Image> Images { get; set; }
    }
}
