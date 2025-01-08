﻿using interfaces2.Model.Entities;
using interfaces2.Model.Enums;

IShape s1 = new Circle() { Radius = 2.0, Color = Color.Black };
IShape s2 = new Rectangle() { Width = 3.5, Height = 4.2, Color = Color.White };
Console.WriteLine(s1);
Console.WriteLine(s2);