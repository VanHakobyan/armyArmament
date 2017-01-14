using System;

namespace Armament
{
    public class PlatoonCommander : IMap, IPistol, IRespirator, IWalkie
    {
        public PlatoonCommander()
        {
            Console.WriteLine("I am a Platoon commander");
        }
        public int cartridge()
        {
            Console.WriteLine("I have 24 pistols bullets");
            return 24;
        }

        public void getPistol()
        {
            Console.WriteLine("I am using makarov pistol");
        }

        public void maps()
        {
            Console.WriteLine("I have a 1:200000 scale map");
        }

        public void Respirator()
        {
            Console.WriteLine("I have a K41 type Respirator ");
        }

        public void Walkie()
        {
            Console.WriteLine("I am using a walkie-IC F4");
        }
    }
}
