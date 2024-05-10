using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public abstract class Vehicle
    {
        // Properties
        public int VehicleId { get; set; }
        
        public string VehicleName { get; set; }
        
        public abstract int NumberOfWheels { get; }

        public abstract string Type { get; }


        // Define relationship
        public Model Model { get; set; }
        public Team Team { get; set; }
    }
}
