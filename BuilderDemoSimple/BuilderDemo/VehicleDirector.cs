namespace BuilderDemo
{
    public class VehicleDirector
    {
        private IVehicleBuilder _vehicleBuilder;

        public VehicleDirector(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public Vehicle BuildCar()
        {
            _vehicleBuilder.Reset()
                .BuildWheel()
                .BuildWheel()
                .BuildWheel()
                .BuildWheel()
                .BuildSteeringWheel();
            return _vehicleBuilder.Vehicle;
            
        }

        public Vehicle BuildBike()
        {
            _vehicleBuilder.Reset()
                .BuildWheel()
                .BuildWheel()
                .BuildHandlebars();
            return _vehicleBuilder.Vehicle;
        }
    }
}
