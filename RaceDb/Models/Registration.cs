using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Registration
    {
        // Properites
        public int RegistrationId { get; set; }
        public DateOnly DateOfRegistration { get; set; }
        public MotorVehicle MotorVehicle { get; set; }
    }
}
