namespace Interfaces._Interfaces
{
    public interface IWaterCraft : IVehicle
    {
        int Doors { get; set; }
        int PassengerCapacity { get; set; }
        double MaxWaterSpeed { get; set; }

    }
}