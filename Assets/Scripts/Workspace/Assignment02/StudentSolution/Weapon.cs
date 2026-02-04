using UnityEngine;

namespace Assignment03.StudentSolution
{
    public class Weapon : Equipment
    {
        public int attackPower;

        public virtual void DealDamage(Entity target) { }
        public virtual void Equip(Player player) { }
    }
}
