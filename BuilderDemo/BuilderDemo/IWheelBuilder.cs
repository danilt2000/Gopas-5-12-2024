namespace BuilderDemo
{
    public interface IWheelBuilder
    {
        Wheel Wheel { get; }

        WheelBuilder BuildWideTyre();

        WheelBuilder BuildSlimTyre();

        WheelBuilder BuildWideRim();

        WheelBuilder BuildSlimRim();

        WheelBuilder BuildBolt();

        WheelBuilder Reset();

        void Validate();
    }
}
