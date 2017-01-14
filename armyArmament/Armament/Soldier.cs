using System;

namespace Armament
{
    public class Soldier : IAutomaticRifle, IBayonetKnife, IGranat, IRespirator
    {
        public Soldier()
        {
            Console.WriteLine("I am a soldier");
        }
        public void AutoRifle()
        {
            Console.WriteLine("I am using AK-47 ");
        }

        public int cartridge()
        {
            Console.WriteLine("I have 120 bullets");
            return 120;
        }

        public void Granat()
        {
            Console.WriteLine("I have one F1 type hand grenade");
        }

        public void Knife()
        {
            Console.WriteLine("I have a multifunctional bayonet knife");
        }

        public void Respirator()
        {
            Console.WriteLine("I have a F58 type Respirator ");
        }
    }
}
