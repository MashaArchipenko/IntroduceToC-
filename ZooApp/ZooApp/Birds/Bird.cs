using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp.Birds
{
    abstract class Bird : Animal
    {
        private string Name;

        public Bird(string name)
        {
            this.Name = name;
        }

        public virtual void Fly()
        {
            Console.WriteLine($"{this.Name} is flying");
        }
    }
}
