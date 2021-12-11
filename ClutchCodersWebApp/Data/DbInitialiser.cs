using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClutchCodersWebApp.Models;

namespace ClutchCodersWebApp.Data
{
    public static class DbInitialiser
    {
        public static void Initialize(ApplicationDbContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            // AddAddresses(context);
        }
        //TODO: Add 10 payment cards
        //TODO: Add 10 people and 2 staff
        //TODO: Add 12 addresses
        //TODO: Add call initialise method in the program class

        private static void AddAddresses(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;   // DB has been seeded
            }

            var addresses = new Address[]
            {
                new Address()
                {
                    HouseNumber = "1",
                    Postcode = "HP5 A3Z"
                    //TODO: Add 10 addresses
                }
            };

            foreach (Address a in addresses)
            {
                context.Addresses.Add(a);
            }

            context.SaveChanges();
        }
    }
}
