using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Birds
{
    class Chicken : Bird
    {
        public Chicken() : base("chicken") { }

        public override void Fly()
        {
            base.Fly();
            Console.WriteLine("but not far");
        }
    }
}
