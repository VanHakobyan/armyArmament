using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Armament;

namespace Testing_Preparedness
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            // Attached to the soldier
            Soldier solider = new Soldier();
            Console.WriteLine(new string('-',15));
            solider.AutoRifle();
            solider.cartridge();
            solider.Granat();
            solider.Knife();
            solider.Respirator();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            //Attached to the Sergeant
            Sergeant sergeant = new Sergeant();
            Console.WriteLine(new string('-', 15));
            sergeant.AutoRifle();
            sergeant.cartridge();
            sergeant.Granat();
            sergeant.Knife();
            sergeant.Respirator();
            sergeant.Walkie();

            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            //Attached to the PlatoonCommander
            PlatoonCommander platoonCommander = new PlatoonCommander();
            Console.WriteLine(new string('-', 15));
            platoonCommander.getPistol();
            platoonCommander.cartridge();
            platoonCommander.maps();
            platoonCommander.Respirator();
            platoonCommander.Walkie();


            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Attached to the Kombat
            Kombat kombat = new Kombat();
            Console.WriteLine(new string('-', 15));
            kombat.getPistol();
            kombat.cartridge();
            kombat.maps();
            kombat.Respirator();
            kombat.Walkie();
           



        }
    }
}
