using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Team
    {
        // Properites
        public int TeamId { get; set; }
        public string TeamName { get; set; }
        public ICollection<Vehicle> Vehicles { get; set; }
        public ICollection<Race> Races { get; set; }
    }
}
