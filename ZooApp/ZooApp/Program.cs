using System;
using ZooApp.Birds;
using ZooApp.Fish;

namespace ZooApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Penguin firstPenguin = new Penguin();
            Penguin secondPenguin = new Penguin();
            Makrel makrel = new Makrel();
            Salmon salmon = new Salmon();
            Parrot parrot = new Parrot();
            Zoo.Swim(firstPenguin, makrel, secondPenguin, salmon, firstPenguin);
            Console.WriteLine("--------------------------");
            Chicken chicken = new Chicken();
            Penguin penguin = new Penguin();
            parrot.Fly();
            chicken.Fly();
            penguin.Fly();
            Console.WriteLine("--------------------------");
            Bird parrot2 = new Parrot();
            Bird chicken2 = new Chicken();
            Bird penguin2 = new Penguin();
            parrot2.Fly();
            chicken2.Fly();
            penguin2.Fly();
            Console.WriteLine("--------------------------");
            Animal parrot3 = new Parrot();
            Animal chicken3 = new Chicken();
            Animal pengui3 = new Penguin();
            Console.ReadKey();
        }
    }
}
