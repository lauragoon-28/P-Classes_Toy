using System;
using System.Collections.Generic;
using System.Text;

namespace P_Classes_Toy
{
    class Toy
    {
        public string Manufacturer { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        private string Notes;

        public Toy()
        {
            Manufacturer = "";
            Name = "";
            Price = 0;
            Notes = "";
        }

        public string GetAisle()
        {
            Random rand = new Random();
            return $"{Manufacturer.Substring(0, 1)}{rand.Next(1, 24)}";
        }

        public void setNotes(string notes)
        {
            Notes = notes;
        }

        public string getNotes()
        {
            return Notes;
        }

    }
}
