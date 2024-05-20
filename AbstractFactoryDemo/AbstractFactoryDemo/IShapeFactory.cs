namespace AbstractFactoryDemo
{
    public interface IShapeFactory
    {
        ISquare CreateSquare();
        ICircle CreateCircle();
    }
}
