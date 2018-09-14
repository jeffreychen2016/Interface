namespace Interfaces._Interfaces
{
    public interface IAirCraft : IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        int PassengerCapacity { get; set; } 
        bool Winged { get; set; }
        string TransmissionType { get; set; } 
        double EngineVolume { get; set; } 
        double MaxAirSpeed { get; set; }
    }
}


