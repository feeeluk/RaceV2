using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class RaceResult
    {
        // Properties
        public int RaceResultId { get; set; }
        public string RaceResultName { get; set; }
        public Race Race {  get; set; }
    }
}
