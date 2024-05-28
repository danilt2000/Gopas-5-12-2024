using ChainOfResponsibilityDemo;

var o1 = new Order()
{
    Customer = "Gopas",
    Product = "slon",
    Price = 2_000_000,
    Quantity = 1,
};

var o2 = new Order()
{
    Customer = "Gopas",
    Product = "krecek",
    Price = 200,
    Quantity = 100,
};

var o3 = new Order()
{
    Customer = "Jina firma",
    Product = "slon",
    Price = 2_000_000,
    Quantity = 1,
};

var o4 = new Order()
{
    Customer = "Jina firma",
    Product = "krecek",
    Price = 200,
    Quantity = 100,
};

var head = new PartnerDiscount();
head.Next = new VolumeDiscount();

head.Handle(o1);
head.Handle(o2);
head.Handle(o3);
head.Handle(o4);

Console.WriteLine(o1);
Console.WriteLine(o2);
Console.WriteLine(o3);
Console.WriteLine(o4);