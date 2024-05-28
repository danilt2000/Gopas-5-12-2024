namespace BuilderDemo
{
    public class Vehicle
    {
        public List<Wheel> Wheels { get; init; } = new();
        public ISteering? Steering { get; set; }

        public override string ToString()
        {
            return $"Wheels {Wheels.Count}; Steering: {Steering}";
        }
    }
}
