using System;
using System.Collections.Generic;
using System.Text;

namespace NovitskyOnline
{
    class Referee
    {
        private string Name;

        public Referee(string name) => Name = name;

        public void Whistle()
        {
            Console.WriteLine($"Арбитр {this.Name} свистит");
        }
    }
}
