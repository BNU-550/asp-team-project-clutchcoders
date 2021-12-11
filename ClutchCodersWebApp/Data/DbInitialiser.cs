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
                },
                new Address()
                {
                    HouseNumber = "2",
                    Postcode = "FJ4 8AS"
                    //TODO: Add 10 addresses
                },
                new Address()
                {
                    HouseNumber = "3",
                    Postcode = "BK9 3GN"
                },
                new Address()
                {
                    HouseNumber = "4",
                    Postcode = "SG3 8FH"
                },
                new Address()
                {
                    HouseNumber = "5",
                    Postcode = "EN9 0SA"
                },
                new Address()
                {
                    HouseNumber = "6",
                    Postcode = "HD1 6DI"
                },
                new Address()
                {
                    HouseNumber = "7",
                    Postcode = "IU3 8DS"
                },
                new Address()
                {
                    HouseNumber = "8",
                    Postcode = "ID4 9SH"
                },
                new Address()
                {
                    HouseNumber = "9",
                    Postcode = "MO6 2PS"
                },
                new Address()
                {
                    HouseNumber = "10",
                    Postcode = "BE3 9NA"
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
