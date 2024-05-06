using RaceDb.Data;
using RaceDb.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;


namespace RaceApplication
{
    public class InitialiseData
    {
        public InitialiseData()
        {
            CreateDatabase();
        }
        
        public void CreateDatabase()
        {
            IConfiguration config = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json")
                .Build();

            var options = new DbContextOptionsBuilder<RaceContext>()
                .UseSqlServer(config.GetConnectionString("RaceDB"))
                .Options;

            using var db = new RaceContext(options);

            db.Database.EnsureDeleted();
            db.Database.EnsureCreated();

            CreateData(db);

            db.SaveChanges();
        }


        void CreateData(RaceContext db)
        {
            Season season1 = new Season { SeasonName = "2024" };

            Circuit circuit1 = new Circuit { CircuitName = "Chinese GP", LapLength = 5, NumberOfLaps = 53 };
            Circuit circuit2 = new Circuit { CircuitName = "Japanese GP", LapLength = 15, NumberOfLaps = 47 };

            Race race1 = new Race { DateOfRace = new DateOnly(2024, 6, 1), Circuit = circuit1, Season = season1 };
            Race race2 = new Race { DateOfRace = new DateOnly(2024, 7, 1), Circuit = circuit2, Season = season1 };

            Team team1 = new Team { TeamName = "Ferrari" };
            Team team2 = new Team { TeamName = "McLaren" };

            Manufacturer manufacturer1 = new Manufacturer { ManufacturerName = "BMW" };
            Manufacturer manufacturer2 = new Manufacturer { ManufacturerName = "Canyon" };
            Manufacturer manufacturer3 = new Manufacturer { ManufacturerName = "Audi" };
            Manufacturer manufacturer4 = new Manufacturer { ManufacturerName = "Volvo" };
            Manufacturer manufacturer5 = new Manufacturer { ManufacturerName = "Triumph" };

            Model model1 = new Model { ModelName = "3 Series", Year = "2020", Colour = "Black", Manufacturer = manufacturer1 };
            Model model2 = new Model { ModelName = "Strive", Year = "2015", Colour = "Black", Manufacturer = manufacturer2 };
            Model model3 = new Model { ModelName = "A5", Year = "2012", Colour = "Grey", Manufacturer = manufacturer3 };
            Model model4 = new Model { ModelName = "FH16", Year = "2013", Colour = "White", Manufacturer = manufacturer4 };
            Model model5 = new Model { ModelName = "Speedmaster", Year = "2019", Colour = "Red", Manufacturer = manufacturer5 };

            Bicycle bicycle1 = new Bicycle
            {
                VehicleName = "Phil's bicycle",
                Model = model2
            };

            Car car1 = new Car
            {
                VehicleName = "Phil's car",
                Model = model1,
                Engine = new Engine_SomeSmallModel(),
                FuelTank = new FuelTank_SomeSmallModel(),
                Registration = null,
                MOT = null,
                Insurance = null,
                Roadtax = null
            };

            Car car2 = new Car
            {
                VehicleName = "Mark's car",
                Model = model3,
                Engine = new Engine_SomeLargeModel(),
                FuelTank = new FuelTank_SomeMediumModel(),
                Registration = new Registration { DateOfRegistration = new DateOnly(2024, 5, 1) },
                MOT = new MOT { StartDate = new DateOnly(2024, 5, 1), EndDate = new DateOnly(2025, 4, 30) },
                Insurance = new Insurance { StartDate = new DateOnly(2024, 05, 01), EndDate = new DateOnly(2025, 4, 30) },
                Roadtax = new RoadTax { StartDate = new DateOnly(2024, 05, 01), EndDate = new DateOnly(2025, 4, 30) }
            };

            Motorbike motorbike1 = new Motorbike
            {
                VehicleName = "Johns's motorbike",
                Model = model5,
                Engine = new Engine_SomeSmallModel(),
                FuelTank = new FuelTank_SomeSmallModel(),
                Registration = null,
                MOT = null,
                Insurance = null,
                Roadtax = null
            };

            Truck truck1 = new Truck
            {
                VehicleName = "Dave's truck",
                Model = model4,
                Engine = new Engine_SomeLargeModel(),
                FuelTank = new FuelTank_SomeMediumModel(),
                Registration = null,
                MOT = null,
                Insurance = null,
                Roadtax = null
            };

            race1.Teams = new Team[] { team1, team2 };
            race2.Teams = new Team[] { team1, team2 };

            season1.Races = new Race[] { race1, race2 };

            manufacturer1.Model = new Model[] { model1 };
            manufacturer2.Model = new Model[] { model2 };
            manufacturer3.Model = new Model[] { model3 };
            manufacturer4.Model = new Model[] { model4 };
            manufacturer5.Model = new Model[] { model5 };


            team1.Vehicles = new Vehicle[] { car1, truck1, motorbike1 };
            team2.Vehicles = new Vehicle[] { bicycle1, car2 };

            db.Add(season1);
            db.Add(manufacturer1);
            db.Add(manufacturer2);
            db.Add(manufacturer3);
            db.Add(manufacturer4);
            db.Add(manufacturer5);
            db.Add(team1);
            db.Add(team2);
        }
    }
}
