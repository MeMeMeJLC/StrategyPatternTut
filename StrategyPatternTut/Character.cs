using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatternTut
{
    class Character
    {
        private IWeapon weapon;

        public void setWeapon(IWeapon newWeapon)
        {
            weapon = newWeapon;
        }

        public void Attack()
        {
            weapon.Use();
        }
    }
}
