namespace BuilderDemo
{
    public enum WheelType
    {
        Slim = 0, Wide = 1
    }

    public class VehicleDirector : IVehicleDirector
    {
        private IVehicleBuilder _vehicleBuilder;

        public VehicleDirector(IVehicleBuilder vehicleBuilder)
        {
            _vehicleBuilder = vehicleBuilder;
        }

        public Vehicle BuildCar()
        {
            try
            {
                _vehicleBuilder.Reset()
                    .BuildWheel(WheelType.Wide)
                    .BuildWheel(WheelType.Wide)
                    .BuildWheel(WheelType.Wide)
                    .BuildWheel(WheelType.Wide)
                    .BuildSteeringWheel();
                return _vehicleBuilder.Vehicle;
            } catch (Exception e)
            {
                throw new BuildCarException(e);
            }

        }

        public Vehicle BuildBike()
        {
            try
            {
                _vehicleBuilder.Reset()
                    .BuildWheel(WheelType.Slim)
                    .BuildWheel(WheelType.Slim)
                    .BuildHandlebars();

                return _vehicleBuilder.Vehicle;
            } catch(Exception e) {  throw new BuildBikeException(e);}
        }
    }
}
