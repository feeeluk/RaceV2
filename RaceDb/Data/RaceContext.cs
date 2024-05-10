using Microsoft.EntityFrameworkCore;
using RaceDb.Models;

namespace RaceDb.Data
{
    public class RaceContext : DbContext
    { 
        // Constructor
        public RaceContext(DbContextOptions<RaceContext> options)
            : base(options)
        {

        }


        // 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vehicle>().ToTable("Vehicles");
            modelBuilder.Entity<Engine>().ToTable("Engines");
            modelBuilder.Entity<Engine_SomeSmallModel>().ToTable("SmallEngines");
            modelBuilder.Entity<Engine_SomeMediumModel>().ToTable("MediumEngines");
            modelBuilder.Entity<Engine_SomeLargeModel>().ToTable("LargeEngines");
            modelBuilder.Entity<FuelTank>().ToTable("FuelTanks");
            modelBuilder.Entity<FuelTank_SomeSmallModel>().ToTable("SmallFuelTanks");
            modelBuilder.Entity<FuelTank_SomeMediumModel>().ToTable("MediumFuelTanks");
            modelBuilder.Entity<FuelTank_SomeLargeModel>().ToTable("LargeFuelTanks");
            modelBuilder.Entity<MotorVehicle>().ToTable("MotorVehicles");
            modelBuilder.Entity<Bicycle>().ToTable("Bicycles");
            modelBuilder.Entity<Car>().ToTable("Cars");
            modelBuilder.Entity<Truck>().ToTable("Trucks");
            modelBuilder.Entity<Motorbike>().ToTable("Motorbikes");
        }


        // Entity types (classes) represented by tables in the database
        public DbSet<Season> Seasons {  get; set; }
        public DbSet<Circuit> Circuits { get; set; }
        public DbSet<Race> Races { get; set; }
        public DbSet<RaceResult> RaceResults { get; set; }
        public DbSet<Team> Teams { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Model> Models { get; set; }
        public DbSet<Manufacturer> Manufacturers { get; set; }
        public DbSet<Engine> Engines { get; set; }
        public DbSet<Engine_SomeSmallModel> SmallEngines { get; set; }
        public DbSet<Engine_SomeMediumModel> MediumEngines { get; set; }
        public DbSet<Engine_SomeLargeModel> LargeEngines { get; set; }
        public DbSet<FuelTank> FuelTanks { get; set; }
        public DbSet<FuelTank_SomeSmallModel> SmallFuelTanks { get; set; }
        public DbSet<FuelTank_SomeMediumModel> MediumFuelTanks { get; set; }
        public DbSet<FuelTank_SomeLargeModel> LargeFuelTanks { get; set; }
        public DbSet<MotorVehicle> MotorVehicles { get; set; }
        public DbSet<Registration> Registrations { get; set; }
        public DbSet<MOT> MOTs { get; set; }
        public DbSet<Insurance> Insurances { get; set; }
        public DbSet<RoadTax> RoadTaxes { get; set; }
        public DbSet<Bicycle> Bicycles { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Truck> Trucks { get; set; }
        public DbSet<Motorbike> Motorbikes { get; set; }
    }
}
