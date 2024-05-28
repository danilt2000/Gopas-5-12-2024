namespace BuilderDemo
{
    public class VehicleBuilder : IVehicleBuilder
    {
        private readonly IWheelBuilder wheelBuilder;

        public VehicleBuilder(IWheelBuilder wheelBuilder)
        {
            this.wheelBuilder = wheelBuilder;
        }

        public Vehicle Vehicle { get; private set; } = new();

        public VehicleBuilder Reset()
        {
            Vehicle = new();
            return this;
        }

        public VehicleBuilder BuildWheel(WheelType wheelType)
        {
            try
            {
                wheelBuilder.Reset();

                if (wheelType == WheelType.Wide)
                {
                    wheelBuilder.BuildWideRim();
                    wheelBuilder.BuildWideTyre();
                }

                if (wheelType == WheelType.Slim)
                {
                    wheelBuilder.BuildSlimRim();
                    wheelBuilder.BuildSlimTyre();
                }

                Vehicle.Wheels.Add(wheelBuilder.Wheel);

                return this;
            }catch (Exception ex)
            {
                throw new BuildWheelException(ex);
            }
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
