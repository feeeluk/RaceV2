using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Race
    {
        // Properites
        public int RaceId { get; set; }
        public DateOnly DateOfRace { get; set; }
        public ICollection<Team> Teams { get; set; }
        [Required]
        public Circuit Circuit { get; set; }
        [Required]
        public Season Season { get; set; }
        public int? RaceResultId { get; set; }
        public RaceResult RaceResult { get; set; }
    }
}
