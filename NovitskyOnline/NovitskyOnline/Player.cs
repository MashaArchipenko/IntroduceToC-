using System;
using System.Collections.Generic;
using System.Text;

namespace NovitskyOnline
{
    abstract class Player
    {
        public string Name;
        public string Role;

        public Player(string name, string role)
        {
            Name = name;
            Role = role;
        }

        public void Pass(Player person)
        {
            Console.WriteLine($"{this.Name} отдал пас {person.Name}-у");
        }

        public virtual void CatchBall()
        {
            Console.WriteLine($"{this.Role} {this.Name} берет мяч в руки");
        }
    }
}
