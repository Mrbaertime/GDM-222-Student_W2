using UnityEngine;

namespace Solution
{
<<<<<<< HEAD
    [CreateAssetMenu(fileName ="ItemPotion",menuName ="Item/ItemPotion")]
    public class ItemPotion : ItemData
    {
       public int healPoint= 10;
=======
    [CreateAssetMenu(fileName ="ItemPotion", menuName = "Item/ItemPotion")]
    public class ItemPotion : ItemData
    {
        public int HealHp = 10;
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c

        public override void Use(Identity identity)
        {
            base.Use(identity);
            OOPPlayer p = identity as OOPPlayer;
<<<<<<< HEAD
            p.Heal(healPoint);
            Debug.Log("You got "+ ItemName);
        }
=======
            p.Heal(HealHp);
            Debug.Log("healllll" + ItemName);
        }
       
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
    }
}
