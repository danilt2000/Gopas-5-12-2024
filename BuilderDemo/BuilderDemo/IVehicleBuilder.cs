namespace BuilderDemo
{
    public interface IVehicleBuilder
    {
        Vehicle Vehicle { get; }

        VehicleBuilder BuildHandlebars();

        VehicleBuilder BuildSteeringWheel();

        VehicleBuilder BuildWheel(WheelType wheelType);

        VehicleBuilder Reset();
    }
}