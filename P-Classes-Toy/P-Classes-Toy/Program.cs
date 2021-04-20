using System;
using System.Collections.Generic;

namespace P_Classes_Toy
{
    class Program
    {
        static void Main(string[] args)
        {
            // Toy 1
            Toy t1 = new Toy();
            t1.Manufacturer = "Mattel";
            t1.Name = "Barbie";
            t1.Price = 15;
            t1.setNotes("Warning: keep out of reach from small children!!");

            Console.WriteLine($"Toy 1 - Manufacturer: {t1.Manufacturer}, Name: {t1.Name}, Price: {t1.Price.ToString("C")}, Notes: {t1.getNotes()}, Aisle {t1.GetAisle()}");

            Console.WriteLine();
            // Toy 2
            Toy t2 = new Toy();
            t2.Manufacturer = "Nintendo";
            t2.Name = "Nintendo Switch";
            t2.Price = 300;
            t2.setNotes("Games sold separately!!");

            Console.WriteLine($"Toy 2 - Manufacturer: {t2.Manufacturer}, Name: {t2.Name}, Price: {t2.Price.ToString("C")}, Notes: {t2.getNotes()}, Aisle {t2.GetAisle()}");

            List<Toy> listOfToys = new List<Toy>();
            listOfToys.Add(t1);
            listOfToys.Add(t2);
        }
    }
}
