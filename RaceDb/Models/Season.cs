using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Season
    {
        public int SeasonId { get; set; }
        public string SeasonName { get; set;}

        public ICollection<Race> Races { get; set; }
    }
}
