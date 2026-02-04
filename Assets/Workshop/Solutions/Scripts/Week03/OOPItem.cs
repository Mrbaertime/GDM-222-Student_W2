using UnityEngine;
using UnityEngine.UIElements;

namespace Solution
{

    public class OOPItem : Identity
    {
        public ItemData itemData;
<<<<<<< HEAD
        public override void Hit(Identity hitBy)
        {
            base.Hit(hitBy);
            if(hitBy is Character)
            {
                mapGenerator.UpdatePositionIdenity
                (hitBy,positionX,positionY);
                itemData.Use(hitBy);
                Destroy(gameObject);
            }
        }
=======
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

>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
       
    }
}