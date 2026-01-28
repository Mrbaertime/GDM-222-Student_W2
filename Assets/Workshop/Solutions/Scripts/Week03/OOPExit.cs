using UnityEngine;

namespace Solution
{
    public class OOPExit : Identity
    {
        public Canvas canvas;
        public override void Hit(Identity hitby)
        {
            base.Hit(hitby);
            if (hitby is OOPPlayer)
            {
                mapGenerator.UpdatePositionIdenity(hitby, positionY, positionX);
                canvas.gameObject.SetActive(true);
                
            }
        }
    }
}