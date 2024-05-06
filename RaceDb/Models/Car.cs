using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Car : MotorVehicle
    {
        // Properites
        public override int NumberOfWheels { get; } = 4;
        public override string Type { get; } = "Car";
        public bool HasAirFreshner { get; set; }
        public override string ToString()
        {
            return $"{base.ToString()}, number of wheels = {NumberOfWheels}";
        }

    }
}
