using System;

namespace Armament
{
    public class Sergeant : IAutomaticRifle, IBayonetKnife, IGranat, IRespirator, IWalkie
    {
        public Sergeant()
        {
            Console.WriteLine("I am a Sergeant");
        }
        public void AutoRifle()
        {
            Console.WriteLine("I am using AKM ");
        }

        public int cartridge()
        {
            Console.WriteLine("I have 180 bullets");
            return 180;
        }

        public void Granat()
        {
            Console.WriteLine("I have two F1 type hand grenade");
        }

        public void Knife()
        {
            Console.WriteLine("I have a multifunctional bayonet knife");
        }

        public void Respirator()
        {
            Console.WriteLine("I have a F17 type Respirator ");
        }

        public void Walkie()
        {
            Console.WriteLine("I am using a walkie-IC V-82");
        }
    }
}
