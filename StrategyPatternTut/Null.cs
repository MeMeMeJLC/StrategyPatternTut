using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternTut
{
    public class Null : IWeapon
    {
        //Means if Null error encountered it won't break the app.
        public void Use()
        {
           Console.WriteLine("Null object encountered"); //doesn't necessarily have to do anything. Just having something to pick up the error is enough.
        }
    }
}
