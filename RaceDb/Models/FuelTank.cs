using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public abstract class FuelTank
    {
        // Properties
        public int FuelTankId { get; set; }
        public abstract string SizeName { get; set; }
        public abstract int SizeInCc { get; set; }
        public MotorVehicle MotorVehicle { get; set; }
    }
}
