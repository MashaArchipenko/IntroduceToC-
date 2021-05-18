using System;
using System.Collections.Generic;
using System.Text;

namespace NovitskyOnline
{
    class GoalKeeper : Player,IPick
    {
        private const string role = "Вратарь";
        private bool yellowCard = false;
        private bool redCard = false;

        public GoalKeeper(string name) : base(name, role) { }

        public void PickBooking()
        {
            if (!yellowCard)
            {
                Console.WriteLine($"{Role} {Name} получает желтую карточку");
                yellowCard = true;
            }

            else if (yellowCard)
            {
                Console.WriteLine($"{Role} {Name} получает красную  карточку");
                redCard = true;
            }
        }

        public void MissBall()
        {
            Console.WriteLine("ГОООЛ!");
        }
    }
}
