using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPItem : Identity
    {
        public ItemData itemData;
        public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is Character)
            {
                mapGenerator.UpdatePositionIdenity(hitby, positionX, positionY);
                itemData.Use(hitby);
                Destroy(gameObject);
            }
        }

       
    }
}