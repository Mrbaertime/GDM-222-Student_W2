using UnityEngine;

namespace Solution
{
    public class OOPExit : Identity
    {
<<<<<<< HEAD
       public GameObject WinUi;

        public override void Hit(Identity hitBy)
        {
            base.Hit(hitBy);
            if(hitBy is OOPPlayer)
            {
                WinUi.gameObject.SetActive(true);
                mapGenerator.UpdatePositionIdenity(hitBy,positionX,positionY);
                hitBy.enabled = false;
            }

=======
        public Canvas canvas;
        public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                mapGenerator.UpdatePositionIdenity(hitby, positionY, positionX);
                canvas.gameObject.SetActive(true);
                
            }
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
        }
    }
}