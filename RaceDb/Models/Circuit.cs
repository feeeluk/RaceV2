using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Circuit
    {
        // Properties
        public int CircuitId { get; set; }

        [Required]
        public string CircuitName { get; set; }

        [Required]
        public int LapLength { get; set; }

        [Required]
        public int NumberOfLaps { get; set; }

        public ICollection<Race> Races { get; set; }
    }
}
