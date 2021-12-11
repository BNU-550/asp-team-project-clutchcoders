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
        private static void AddPaymentCards(ApplicationDbContext context)
        {
            if (context.PaymentCards.Any())
            {
                return;
            }

            var cards = new PaymentCard[]
            {
                new PaymentCard()
                {
                    CardNumber = "8361 4019 5729 9172",
                    NameOnCard = "Dave Smith",
                    ExpiryYear = 2023,
                    ExpiryMonth = 8,
                    SecurityCode = "927"
                },
                new PaymentCard()
                {
                    CardNumber = "1857 2740 7592 7281",
                    NameOnCard = "John Walker",
                    ExpiryYear = 2026,
                    ExpiryMonth = 2,
                    SecurityCode = "891"
                },
                new PaymentCard()
                {
                    CardNumber = "3718 0572 7593 1074",
                    NameOnCard = "Graham Fanta",
                    ExpiryYear = 2024,
                    ExpiryMonth = 5,
                    SecurityCode = "294"
                },
                new PaymentCard()
                {
                    CardNumber = "2974 4728 0183 4628",
                    NameOnCard = "Sharon Case",
                    ExpiryYear = 2028,
                    ExpiryMonth = 9,
                    SecurityCode = "919"
                },
                new PaymentCard()
                {
                    CardNumber = "1847 5973 0317 5628",
                    NameOnCard = "Anna Becker",
                    ExpiryYear = 2021,
                    ExpiryMonth = 10,
                    SecurityCode = "137"
                },
                new PaymentCard()
                {
                    CardNumber = "1749 5628 6183 0572",
                    NameOnCard = "Jake Price",
                    ExpiryYear = 2027,
                    ExpiryMonth = 11,
                    SecurityCode = "482"
                },
                new PaymentCard()
                {
                    CardNumber = "1847 9573 5729 5661",
                    NameOnCard = "Vinny Thread",
                    ExpiryYear = 2028,
                    ExpiryMonth = 5,
                    SecurityCode = "007"
                },
                new PaymentCard()
                {
                    CardNumber = "4579 4781 1208 8753",
                    NameOnCard = "Matt Driver",
                    ExpiryYear = 2027,
                    ExpiryMonth = 9,
                    SecurityCode = "217"
                },
                new PaymentCard()
                {
                    CardNumber = "1794 5827 9274 0297",
                    NameOnCard = "Kate Turton",
                    ExpiryYear = 2022,
                    ExpiryMonth = 12,
                    SecurityCode = "136"
                },
                new PaymentCard()
                {
                    CardNumber = "1937 7592 5729 9172",
                    NameOnCard = "Sarah Walker",
                    ExpiryYear = 2028,
                    ExpiryMonth = 9,
                    SecurityCode = "274"
                },
            };
            foreach (PaymentCard a in cards)
            {
                context.PaymentCards.Add(a);
            }
        }

        private static void AddAddresses(ApplicationDbContext context)
        {
            if (context.Addresses.Any())
            {
                return;
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
                },
                new Address()
                {
                    HouseNumber = "11",
                    Postcode = "FU7 5IT"
                },
                new Address()
                {
                    HouseNumber = "12",
                    Postcode = "JD2 7GJ"
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
