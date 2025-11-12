// See https://aka.ms/new-console-template for more information
using LiskovSubstution;

Console.WriteLine("Hello, World!");

Rectangle rectangle = new Rectangle() { Width=5, Height=4};
Console.WriteLine(rectangle.GetArea());

Square square = new Square() {EdgeLength = 5};
Console.WriteLine(square.GetArea());

var rect = Geometry.CreateGeometry(5);
//rect.Width = 5;
//rect.Height = 4;

Console.WriteLine(rect.GetArea());

var another = Geometry.CreateGeometry(7, 8);
Console.WriteLine(another.GetArea());