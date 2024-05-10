using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaceDb.Models
{
    public class FuelTank_SomeMediumModel : FuelTank
    {
        public override string SizeName { get; set; } = "Medium";
        public override int SizeInCc { get; set; } = 3000;
    }
}
