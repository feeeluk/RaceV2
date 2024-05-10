using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class Model
    {
        public int ModelId { get; set; }

        public string ModelName { get; set; }

        [Required]
        public string Year { get; set; }

        [Required]
        public string Colour { get; set; }


        public Manufacturer Manufacturer { get; set; }
        public ICollection<Vehicle> Vehicle { get; set; }
    }
}
