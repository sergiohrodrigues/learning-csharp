﻿using Comparison.Entities;

namespace Comparison;

class Program
{
    static void Main(string[] args)
    {
        List<Product> list = new List<Product>();
        list.Add(new Product("TV", 900.00));
        list.Add(new Product("Notebook", 1200.00));
        list.Add(new Product("Tablet", 450.00));

        // Tipo delegate..
        // Comparison<Product> comp = CompareProducts;
        // list.Sort(comp);

        // expressao lambda atribuida a uma variavel tipo delegate
        // Comparison<Product> comp = (p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());

        // expressao lambda inline
        list.Sort((p1, p2) => p1.Name.ToUpper().CompareTo(p2.Name.ToUpper()));

        foreach (Product p in list)
        {
            Console.WriteLine(p);
        }
    }

    // static int CompareProducts(Product p1, Product p2) {
    //     return p1.Name.ToUpper().CompareTo(p2.Name.ToUpper());
    // }
}