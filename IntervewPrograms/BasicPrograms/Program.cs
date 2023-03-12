// See https://aka.ms/new-console-template for more information
using BasicPrograms.Oops.Polymorphism;
using SolidPrinciples;

Console.WriteLine("Hello, World!");
var d = new D1();
d.Name();
d.VirtualName();

Base b = new D1();
b.Name();
b.VirtualName();

//SolidStart.Run();


Console.ReadLine();
