using BuilderDemo;

try
{

    var wheelBuilder = new WheelBuilder();

    var wheelDirector = new WheelDirector(wheelBuilder);

    var slimWheel = wheelDirector.BuildSlimWheel();

    var wideWheel = wheelDirector.BuildWideWheel();

    Console.WriteLine(slimWheel);
    Console.WriteLine(wideWheel);


    var builder = new VehicleBuilder(wheelBuilder);
    var director = new VehicleDirector(builder);

    var car = director.BuildCar();
    var bike = director.BuildBike();

    Console.WriteLine(car);
    Console.WriteLine(bike);

} catch (Exception ex)  
{
    Console.WriteLine("Error: " + ex);
}

