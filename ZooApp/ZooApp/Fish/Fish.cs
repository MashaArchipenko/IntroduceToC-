using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Fish
{
    abstract class Fish : Animal, ISwimable
    {
        public void Swim()
        {
            Console.WriteLine("Fish is swimming");
        }

    }
}
