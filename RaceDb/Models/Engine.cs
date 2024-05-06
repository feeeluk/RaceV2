namespace RaceDb.Models
{
    public abstract class Engine
    {
        // Properties
        public int EngineId { get; set; }
        public int Mileage { get; set; }
        public abstract string SizeName { get; set; }
        public abstract int SizeInCc { get; set; }
        public MotorVehicle MotorVehicle { get; set; }
    }
}
