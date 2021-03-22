using Microsoft.EntityFrameworkCore;
using System;

namespace Project1TripLog.Models
{
    public class TripContext : DbContext
    {
        public TripContext(DbContextOptions<TripContext> options)
            : base(options) { }

        public DbSet<Trip> Trips { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Trip>().HasData(
                new Trip
                {
                    TripId = 1,
                    Destination = "Las Vegas",
                    StartDate = new DateTime(2021, 3, 22),
                    EndDate = new DateTime(2021, 3, 29),
                    Accomodation = "The Fantastic Hotel",
                    AccomodationPhone = "555-550-5550",
                    AccomodationEmail = "fanstastic_hotel@fantastic.com",
                    ThingToDo1 = "Go to the Park",
                    ThingToDo2 = "Go to the Aquarium",
                    ThingToDo3 = "See a Show"
                },
                
                new Trip 
                { 
                    TripId = 2,
                    Destination = "Atlanta",
                    StartDate = new DateTime(2021, 4, 15),
                    EndDate = new DateTime(2021, 4, 22),
                    Accomodation = "The Royal Hovel",
                    AccomodationPhone = "555-554-5554",
                    AccomodationEmail = "royal_hovel@royallyhoveled.com",
                    ThingToDo1 = "Go Jousting",
                    ThingToDo2 = "Ride a Pony",
                    ThingToDo3 = "Have a Feast"
                },

                new Trip
                {
                    TripId = 3,
                    Destination = "Portland",
                    StartDate = new DateTime(2021, 5, 30),
                    EndDate = new DateTime(2021, 6, 12),
                    Accomodation = "The Weirdly Weird Place",
                    AccomodationPhone = "556-556-5556",
                    AccomodationEmail = "soweirdlyweirdbro@weird.com",
                    ThingToDo1 = "Buy a Beanie and Drink Craft Beer",
                    ThingToDo2 = "Enjoy Nature by Biking Around the City",
                    ThingToDo3 = "Voodoo Donuts"
                });
        }
    }
}
