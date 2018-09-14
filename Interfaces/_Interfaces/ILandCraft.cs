namespace Interfaces._Interfaces
{
    public interface ILandCraft : IVehicle
    {
        int Wheels { get; set; }
        int Doors { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        double MaxLandSpeed { get; set; }
    }
}


