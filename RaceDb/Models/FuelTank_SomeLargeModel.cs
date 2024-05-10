using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class FuelTank_SomeLargeModel : FuelTank
    {
        // Properites
        public override string SizeName { get; set; } = "Large";
        public override int SizeInCc { get; set; } = 5000;
    }
}
