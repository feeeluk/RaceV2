using System.ComponentModel.DataAnnotations;

namespace RaceDb.Models
{
    public abstract class MotorVehicle : Vehicle
    {
        public override string ToString()
        {
            return $"Name = {VehicleName}";
        }


        public int? RegistrationId { get; set; }
        public Registration Registration { get; set; }

        public int? MOTId { get; set; }
        public MOT MOT { get; set; }

        public int? InsuranceId { get; set; }
        public Insurance Insurance { get; set; }

        public int? RoadtaxId { get; set; }
        public RoadTax Roadtax { get; set; }

        [Required]
        public int EngineId { get; set; }
        public Engine Engine { get; set; }

        [Required]
        public int FuelTankId { get; set; }
        public FuelTank FuelTank { get; set; }







    }
}
