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
                    Name = "First Motomoto",
                    Id = 1,
                 
                    
                 
                }
            };

            foreach (Product a in products)
            {
                context.Products.Add(a);
            }

            context.SaveChanges();
        }
    }
}
