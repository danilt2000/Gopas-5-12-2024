namespace BuilderDemo
{
    public class VehicleBuilder : IVehicleBuilder
    {
        public Vehicle Vehicle { get; private set; } = new();

        public VehicleBuilder Reset()
        {
            Vehicle = new();
            return this;
        }

        public VehicleBuilder BuildWheel()
        {
            Vehicle.Wheels.Add(new Wheel());
            return this;
        }

        public VehicleBuilder BuildSteeringWheel()
        {
            Vehicle.Steering = new SteeringWheel();
            return this;
        }

        public VehicleBuilder BuildHandlebars()
        {
            Vehicle.Steering = new Handlebars();
            return this;
        }
    }
}
