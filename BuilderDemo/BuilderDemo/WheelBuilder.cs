using System.Runtime.Serialization;

namespace BuilderDemo
{
    public class WheelBuilder : IWheelBuilder
    {
        public Wheel Wheel { get; private set; } = new Wheel();

        public WheelBuilder BuildWideTyre()
        {
            try
            {
                Wheel.Tyre = new WideTyre();
            }
            catch (Exception e)
            {
                throw new WideTireBuildException(e);
            }
            

            return this;
        }

        public WheelBuilder BuildSlimTyre()
        {
            try
            {
                Wheel.Tyre = new SlimTyre();
            }
            catch (Exception e)
            {
                throw new SlimTireBuildException(e);
            }
            

            return this;
        }

        public WheelBuilder BuildWideRim()
        {
            Wheel.Rim = new WideRim();

            return this;
        }

        public WheelBuilder BuildSlimRim()
        {
            Wheel.Rim = new SlimRim();

            return this;
        }

        public WheelBuilder BuildBolt()
        {
            Wheel.Bolts.Add(new Bolt());

            return this;
        }

        public void Validate()
        {
            if (Wheel.Rim is SlimRim && Wheel.Tyre is WideTyre)
                throw new Exception("Slim rim can`t be assigned to wide tyre");

            if (Wheel.Rim is WideRim && Wheel.Tyre is SlimTyre)
                throw new Exception("Wide rim can`t be assigned to slim tyre");
        }

        public WheelBuilder Reset()
        {
            Wheel = new();

            return this;
        }
    }

    [Serializable]
    internal class WideTireBuildException : Exception
    {
        private Exception e;

        public WideTireBuildException()
        {
        }

        public WideTireBuildException(Exception e)
        {
            this.e = e;
        }

        public WideTireBuildException(string? message) : base(message)
        {
        }

        public WideTireBuildException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected WideTireBuildException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
