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

            
            // AddProduct(context);
            // AddImage(context);
        }
        
        //TODO: Add call initialise method in the program class
        // Add order initialiser

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
              
                    Name = "M 1000 RR",
                    EngineSize = "500cc",
                    Type = "Sport",
                    Brand = "BMW",
                    FuelType = "Petrol",
                    FuelCapacity = "3L",
                    Dimensions = "1m",
                    Year = 2009,
                    Price = 30000
                    
                },
                new Product()
                {
                
                    Name = "R 18 B",
                    EngineSize = "1500cc",
                    Type = "Cruiser",
                    Brand = "BMW",
                    FuelType = "Petrol",
                    FuelCapacity = "3L",
                    Dimensions = "1m",
                    Year = 2010,
                    Price = 21500,
                 
                },
                new Product()
                {
                  
                    Name = "R 1250 R",
                    EngineSize = "1000cc",
                    Type = "Sport",
                    Brand = "BMW",
                    FuelType = "Diesel",
                    FuelCapacity = "5L",
                    Dimensions = "1m",
                    Year = 2015,
                    Price = 11440,
               
                },
                new Product()
                {
                    
                    Name = "Blue R 1250 RT",
                    EngineSize = "1450cc",
                    Type = "Luxury",
                    Brand = "BMW",
                    FuelType = "Petrol",
                    FuelCapacity = "6L",
                    Dimensions = "1m",
                    Year = 2020,
                    Price = 15745,
                
                },
                new Product()
                {
                  
                    Name = "VT1300",
                    EngineSize = "1200cc",
                    Type = "Cruiser",
                    Brand = "Honda",
                    FuelType = "Petrol",
                    FuelCapacity = "4L",
                    Dimensions = "1m",
                    Year = 2013,
                    Price = 9600,
                
                },
                new Product()
                {
              
                    Name = "Honda Navi",
                    EngineSize = "800cc",
                    Type = "City",
                    Brand = "Honda",
                    FuelType = "Petrol",
                    FuelCapacity = "4L",
                    Dimensions = "1m",
                    Year = 2018,
                    Price = 1800,
               
                },
                new Product()
                {
                   
                    Name = "Ducati Diavel",
                    EngineSize = "1198cc",
                    Type = "City",
                    Brand = "Ducati",
                    FuelType = "Carbon",
                    FuelCapacity = "4L",
                    Dimensions = "1m",
                    Year = 2020,
                    Price = 17995,
                    
                },

            };

            foreach (Product a in products)
            {
                context.Products.Add(a);
            }

            context.SaveChanges();
        }

        private static void AddImage(ApplicationDbContext context)
        {
            if (context.Photos.Any())
            {
                return;   // DB has been seeded
            }

            var images = new Photo[]
                    {
                        new Photo()
                        {
                            PhotoNumber =1,
                            Name = "bmwM1000RRImage1.jfif",
                            Category = 1,
                            ProductId = 8
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "bmwM1000RRImage2.jfif",
                            Category = 2,
                            ProductId = 8
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "bmwM1000RRImage3.jfif",
                            Category = 3,
                            ProductId = 8
                        },
                           new Photo()
                        {
                            PhotoNumber =4,
                            Name = "bmwM1000RRImage4.jfif",
                            Category = 4,
                            ProductId = 8
                        },
                        new Photo()
                        {
                            PhotoNumber =1,
                            Name = "bmwR18BImage1.jfif",
                            Category = 1,
                            ProductId =9
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "bmwR18BImage2.jfif",
                            Category = 2,
                            ProductId =9
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "bmwR18BImage3.jfif",
                            Category = 3,
                            ProductId =9
                        },
                          new Photo()
                        {
                            PhotoNumber =1,
                            Name = "bmwR1250RImage1.jfif",
                            Category = 1,
                            ProductId =10
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "bmwR1250RImage2.jfif",
                            Category = 2,
                            ProductId =10
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "bmwR1250RImage3.jfif",
                            Category = 3,
                            ProductId =10
                        },
                           new Photo()
                        {
                            PhotoNumber =1,
                            Name = "bmwR1250RTImage1.jfif",
                            Category = 1,
                            ProductId =11
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "bmwR1250RTImage2.jfif",
                            Category = 2,
                            ProductId =11
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "bmwR1250RTImage3.jfif",
                            Category = 3,
                            ProductId =11
                        },
                            new Photo()
                        {
                            PhotoNumber =1,
                            Name = "HondaFuryImage1.jfif",
                            Category = 1,
                            ProductId =12
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "HondaFuryImage2.jfif",
                            Category = 2,
                            ProductId =12
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "HondaFuryImage3.jfif",
                            Category = 3,
                            ProductId =12
                        },
                           new Photo()
                        {
                            PhotoNumber =1,
                            Name = "HondaNaviImage1.jfif",
                            Category = 1,
                            ProductId =13
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "HondaNaviImage2.jfif",
                            Category = 2,
                            ProductId =13
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "HondaNaviImage3.jfif",
                            Category = 3,
                            ProductId =13
                        },
                          new Photo()
                        {
                            PhotoNumber =4,
                            Name = "HondaNaviImage4.jfif",
                            Category = 4,
                            ProductId =13
                        },
                           new Photo()
                        {
                            PhotoNumber =1,
                            Name = "DucatiDiavelImage1.jfif",
                            Category = 1,
                            ProductId =14
                        },
                         new Photo()
                        {
                            PhotoNumber =2,
                            Name = "DucatiDiavelImage2.jfif",
                            Category = 2,
                            ProductId =14
                        },
                          new Photo()
                        {
                            PhotoNumber =3,
                            Name = "DucatiDiavelImage3.jfif",
                            Category = 3,
                            ProductId =14
                        }

                    };


            foreach (Photo a in images)
            {
                context.Photos.Add(a);
            }

            context.SaveChanges();

        }
    }
}
