// See https://aka.ms/new-console-template for more information
using RecordTypes;

Console.WriteLine("Hello, World!");

Product product1 = new Product() { Name ="Rayban", Price=5000};
Product product2 = new Product () { Name = "Rayban", Price = 5000 };

//if (product2 == product1)
//{
//    Console.WriteLine("İki ürün sınıfının referansı aynı");
//}

var comments = new List<string> { "Yorum1", "Yorum3" };
ProductRecord p1 = new ProductRecord() { Name = "Tişört", Price = 500, Comments = comments };
ProductRecord p2 = new ProductRecord() { Name = "Tişört", Price = 500, Comments = comments};

if (p1==p2)
{
    Console.WriteLine("İki ürün record'unun değeri aynı");
}
else
{
    Console.WriteLine("Farklı değerler");
}


