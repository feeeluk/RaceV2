using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RaceDb.Data;
using RaceDb.Models;

namespace RaceApplication
{
    public class StagingArea
    {
        public StagingArea()
        {
            ShowDBData();
        }

        public void ShowDBData()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<RaceContext>()
                .UseSqlServer(config.GetConnectionString("RaceDB"))
                .Options;

            using var db = new RaceContext(options);

            Console.WriteLine("All Vehicles:");

            var allVehicles = db.Vehicles
                .Include(x => x.Team)
                //.Include(x => x.Model)
                .Include(x => x.Model.Manufacturer)
                .ToList();

            foreach (var v in allVehicles)
            {
                Console.WriteLine($"Name:               {v.VehicleName}");
                Console.WriteLine($"Manufacturer:       {v.Model.Manufacturer.ManufacturerName}");
                Console.WriteLine($"Model:              {v.Model.ModelName}");
                Console.WriteLine($"Colour:             {v.Model.Colour}");
                Console.WriteLine($"Year:               {v.Model.Year}");
                Console.WriteLine($"Team:               {v.Team.TeamName}");
                Console.WriteLine($"Wheels:             {v.NumberOfWheels}");
                Console.WriteLine($"Type:               {v.Type}");

                if (v is MotorVehicle mv)
                {
                    var motorVehicles = db.MotorVehicles
                        .Where(x => x.VehicleId == mv.VehicleId)
                        .Include(x => x.Engine)
                        .Include(x => x.FuelTank)
                        .ToList();

                    foreach (var x in motorVehicles)
                    {
                        Console.WriteLine($"Engine:             {x.Engine.SizeName}");
                        Console.WriteLine($"Fuel tank:          {x.FuelTank.SizeName}");
                    }


                    if (mv is Car c)
                    {
                        Console.WriteLine($"Airfreshner?        {c.HasAirFreshner}");
                    }

                }

                if (v is Bicycle b)
                {
                    Console.WriteLine($"Bell?               {b.HasABell}");
                }

                Console.WriteLine();
            }

            Console.WriteLine("All Manufacturers:");
            Console.WriteLine("All Models:");
            Console.WriteLine("All Models by Manufacturer:");
            Console.WriteLine("All Bikes:");
            Console.WriteLine("All Cars:");
            Console.WriteLine("All Trucks:");
            Console.WriteLine("All Motorbikes:");
            Console.WriteLine("All Motor Vehicles:");
            Console.WriteLine("All Teams:");
            Console.WriteLine("All Seasons:");
            Console.WriteLine("All Circuits in a particular Season:");
            Console.WriteLine("All Races in a particular Season:");
            Console.WriteLine("All Teams in a particular Race:");
        }
    }
}
