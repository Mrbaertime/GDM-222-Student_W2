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
<<<<<<< HEAD
                OOPPlayer p = hitBy as OOPPlayer;
                p.TakeDamage(Damage);
                Debug.Log("Hit wall");
            }
        }
        
=======
                OOPPlayer player = hitBy as OOPPlayer;
                player.TakeDamage(Damage);
                Debug.Log("hitwall");
            }
        }



>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
    }
}