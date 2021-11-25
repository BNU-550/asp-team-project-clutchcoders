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
        [Required]
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
        [Required]
        public int Year { get; set; }
        [Required]
        public float Price { get; set; }
    }
}
