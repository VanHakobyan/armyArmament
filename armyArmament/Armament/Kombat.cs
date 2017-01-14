using System;

namespace Armament
{
    public class Kombat : IMap, IPistol, IRespirator, IWalkie
    {
        public Kombat()
        {
            Console.WriteLine("I am a Kombat");
        }
        public int cartridge()
        {
            Console.WriteLine("I have 16 pistols bullets");
            return 16;
        }

        public void getPistol()
        {
            Console.WriteLine("I am using Pistolet Tokareva (TT) pistol");
        }

        public void maps()
        {
            Console.WriteLine("I have a 1:100000 scale map");
        }

        public void Respirator()
        {
            Console.WriteLine("I have a K71 type Respirator ");
        }

        public void Walkie()
        {
            Console.WriteLine("I am using a walkie Motorola DP1400");
        }

    }
}
