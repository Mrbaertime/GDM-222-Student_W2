using UnityEngine;

namespace Solution
{

    public class OOPItem : Identity
    {

        public ItemData itemData;
        
        public override void Hit(Identity hitBy)
        {
            itemData.Use(hitBy);
            Destroy(this.gameObject);
        }
    }
}