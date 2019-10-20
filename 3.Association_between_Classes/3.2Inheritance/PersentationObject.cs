using System;

namespace Inheritance
{
    public class PersentationObject
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public void Copy()
        {
            Console.WriteLine("Object copied to clipboard");
        }
        public void Duplicate()
        {
            Console.WriteLine("Objecy was duplicated.");
        }
    }
}