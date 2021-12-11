using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Data
{
    public static class ProductInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any products.
            // AddProduct(context);
        }
        
        //TODO: Add call initialise method in the program class

        private static void AddProduct(ApplicationDbContext context)
        {
            if (context.Products.Any())
            {
                return;   // DB has been seeded
            }

            var products = new Product[]
            {
                new Product()
                {
                    Id = 1,
                    Name = "M 1000 RR",
                    EngineSize = "500cc",
                    Type = "Sport",
                    Brand = "BMW",
                    FuelType = "Petrol",
                    FuelCapacity = "3L",
                    Dimensions = "1m",
                    Year = 2009,
                    Price = 30000,
                    Images = new List<Image>()
                    {
                        new Image()
                        {
                            Id =1,
                            Name = "bmwM1000RRImage1.jfif",
                            Category = 1
                        },
                         new Image()
                        {
                            Id =2,
                            Name = "bmwM1000RRImage2.jfif",
                            Category = 2
                        },
                          new Image()
                        {
                            Id =3,
                            Name = "bmwM1000RRImage3.jfif",
                            Category = 3
                        },
                           new Image()
                        {
                            Id =4,
                            Name = "bmwM1000RRImage4.jfif",
                            Category = 4
                        }
                    }  
                },
                new Product()
                {
                    Id = 2,
                    Name = "R 18 B",
                    EngineSize = "500cc",
                    Type = "Sport",
                    Brand = "BMW",
                    FuelType = "Petrol",
                    FuelCapacity = "3L",
                    Dimensions = "1m",
                    Year = 2009,
                    Price = 30000,
                    Images = new List<Image>()
                    {
                        new Image()
                        {
                            Id =1,
                            Name = "bmwM1000RRImage1.jfif",
                            Category = 1
                        },
                         new Image()
                        {
                            Id =2,
                            Name = "bmwM1000RRImage2.jfif",
                            Category = 2
                        },
                          new Image()
                        {
                            Id =3,
                            Name = "bmwM1000RRImage3.jfif",
                            Category = 3
                        },
                           new Image()
                        {
                            Id =4,
                            Name = "bmwM1000RRImage4.jfif",
                            Category = 4
                        }
                    }
                },


            };

            foreach (Product a in products)
            {
                context.Products.Add(a);
            }

            context.SaveChanges();
        }
    }
}
