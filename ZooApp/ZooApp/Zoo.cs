using System;
using System.Collections.Generic;
using System.Text;

namespace ZooApp
{
    static class Zoo
    {
        public static void Swim(params ISwimable[] swimable)
        {
            foreach(ISwimable item in swimable)
            {
                item.Swim();
            }
        }
    }
}
