using UnityEngine;

namespace Solution
{

    public class OOPWall : Identity
    {
        public int Damage;
        public bool IsIceWall;

        public override void Hit(Identity hitBy)
        {
            base.Hit(hitBy);
            if(hitBy is OOPPlayer)
            {
                OOPPlayer player = hitBy as OOPPlayer;
                player.TakeDamage(Damage);
                Debug.Log("hitwall");
            }
        }



    }
}