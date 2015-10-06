using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternTut
{
    class Program
    {
        static void Main(string[] args)
        {
            IWeapon weapon = null;
            Character JeremyCook = new Character();

            while (true)
            {
                Console.WriteLine("Choose a weapon for JeremyCook! 1 = Sword, 2 = Ax, 3 = Club");
                String input = Console.ReadLine();

                switch (input)
                {
                    case "1":
                        weapon = new Sword();
                        break;
                    case "2":
                        weapon = new Ax();
                        break;
                    case "3":
                        weapon = new Club();
                        break;
                    default:
                        Console.WriteLine("no weapon picked");
                        break;
                }

                JeremyCook.setWeapon(weapon);
                JeremyCook.Attack();
            }
        }
    }
}
