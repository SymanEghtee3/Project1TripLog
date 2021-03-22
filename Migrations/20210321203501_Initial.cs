using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Project1TripLog.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Trips",
                columns: table => new
                {
                    TripId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Destination = table.Column<string>(nullable: true),
                    StartDate = table.Column<DateTime>(nullable: false),
                    EndDate = table.Column<DateTime>(nullable: false),
                    Accomodation = table.Column<string>(nullable: true),
                    AccomodationPhone = table.Column<string>(nullable: true),
                    AccomodationEmail = table.Column<string>(nullable: true),
                    ThingToDo1 = table.Column<string>(nullable: true),
                    ThingToDo2 = table.Column<string>(nullable: true),
                    ThingToDo3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trips", x => x.TripId);
                });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodation", "AccomodationEmail", "AccomodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 1, "The Fantastic Hotel", "fanstastic_hotel@fantastic.com", "555-550-5550", "Las Vegas", new DateTime(2021, 3, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go to the Park", "Go to the Aquarium", "See a Show" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodation", "AccomodationEmail", "AccomodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 2, "The Royal Hovel", "royal_hovel@royallyhoveled.com", "555-554-5554", "Atlanta", new DateTime(2021, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Go Jousting", "Ride a Pony", "Have a Feast" });

            migrationBuilder.InsertData(
                table: "Trips",
                columns: new[] { "TripId", "Accomodation", "AccomodationEmail", "AccomodationPhone", "Destination", "EndDate", "StartDate", "ThingToDo1", "ThingToDo2", "ThingToDo3" },
                values: new object[] { 3, "The Weirdly Weird Place", "soweirdlyweirdbro@weird.com", "556-556-5556", "Portland", new DateTime(2021, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Buy a Beanie and Drink Craft Beer", "Enjoy Nature by Biking Around the City", "Voodoo Donuts" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Trips");
        }
    }
}
