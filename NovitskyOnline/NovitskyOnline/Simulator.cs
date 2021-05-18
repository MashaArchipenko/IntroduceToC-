using System;
using System.Collections.Generic;
using System.Text;

namespace NovitskyOnline
{
    abstract class Simulator
    {
        public static void Move(string position, Ball ball)
        {
            Console.WriteLine($"мяч {position}");
        }

        public static void Move(string position, params FieldPlayer[] player)
        {
            foreach (FieldPlayer i in player)
            {
                Console.Write($"{i.Name}");
            }
            Console.WriteLine($" {position}");
        }

        public static void Move(string position, Ball ball, params FieldPlayer[] item)
        {
            Console.Write($"{position} мяч");
            foreach (var i in item)
            {
                Console.Write($" {i.Name} ");
            }
            Console.WriteLine();
        }
    }
}
