using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Truck : MotorVehicle
    {
        // Properites
        public override int NumberOfWheels { get; } = 12;
        public override string Type { get; } = "Truck";
        public override string ToString()
        {
            return $"{base.ToString()}, number of wheels = {NumberOfWheels}";
        }
    }
}
