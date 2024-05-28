using BuilderDemo;

var builder = new VehicleBuilder();
var director = new VehicleDirector(builder);

var car = director.BuildCar();
var bike = director.BuildBike();

Console.WriteLine(car);
Console.WriteLine(bike);