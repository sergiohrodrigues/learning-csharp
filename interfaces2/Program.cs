using interfaces2.Model.Entities;
using interfaces2.Model.Enums;

Shape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
Shape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.White };
Console.WriteLine(s1);
Console.WriteLine(s2);