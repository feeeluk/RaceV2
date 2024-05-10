namespace RaceDb.Models
{
    public class Engine_SomeLargeModel : Engine
    {
        // Properties
        public override string SizeName { get; set; } = "Large";
        public override int SizeInCc { get; set; } = 5000;
    }
}
