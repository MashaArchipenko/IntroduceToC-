using System;
using System.Collections.Generic;
using System.Text;

namespace NovitskyOnline
{
    class FieldPlayer : Player,IPick
    {
        private bool yellowCard = false;
        private bool redCard = false;
        private const string role = "игрок";

        public FieldPlayer(string name) : base(name, role) { }

        public void KickOnGoal()
        {
            Console.WriteLine($"игрок {Name} бьет по воротам");
        }

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

        public override void CatchBall()
        {
            base.CatchBall();
            Console.WriteLine("...и нарушает правила");
        }
    }
}
