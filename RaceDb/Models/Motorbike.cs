using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Motorbike : MotorVehicle
    {
        // Properites
        public override int NumberOfWheels { get; } = 2;
        public override string Type { get; } = "Motorbike";
        public override string ToString()
        {
            return $"{base.ToString()}, number of wheels = {NumberOfWheels}";
        }
    }
}
