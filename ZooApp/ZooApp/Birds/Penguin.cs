using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Birds
{
    class Penguin : Bird, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Penguin is swimming");
        }

        public Penguin() : base("penguin") { }

        public override void Fly()
        {
            Console.WriteLine("Penguin cannot fly");
        }
    }
}
