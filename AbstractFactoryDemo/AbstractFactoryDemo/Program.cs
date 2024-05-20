using AbstractFactoryDemo;

var factory = new BlueShapeFactory();
var sc = new ShapesClient(factory);
sc.UseShapes();
