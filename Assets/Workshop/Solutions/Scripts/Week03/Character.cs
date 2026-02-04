using NUnit.Framework;
using UnityEngine;
using UnityEngine.XR;


namespace Solution
{
    public class Character : Identity
    {
        [Header("Character")]
        public int energy;
        public int AttackPoint;

        public bool isAlive = true;

        // Start is called before the first frame update
        protected void GetRemainEnergy()
        {

        }

        public virtual void Move(Vector2 direction)
        {
<<<<<<< HEAD
            int toX = (int)(positionX+ direction.x);
            int toY = (int)(positionY+ direction.y);

            if(HasPlacement(toX, toY)){
                Debug.Log("can't move");
                Identity identity = mapGenerator.GetMapData(toX,toY);
=======
            int toX = (int)(positionX + direction.x);
            int toY = (int)(positionY + direction.y);

            if (HasPlacement(toX, toY))
            {
                Debug.Log("can't move ");
                Identity identity = mapGenerator.GetMapData(toX, toY);
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
                identity.Hit(this);
            }
            else
            {
<<<<<<< HEAD
                mapGenerator.UpdatePositionIdenity(this,toX,toY);
                TakeDamage(1);
            }
           
=======
                
                mapGenerator.UpdatePositionIdenity(this, toX, toY);
                TakeDamage(1);
            }


        }
        public void UpdatePosition(Vector2 dir)
        {
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
        }
        // hasPlacement �׹��� true ����ա���ҧ������麹 map �����˹� x,y
        public bool HasPlacement(int x, int y)
        {
<<<<<<< HEAD
            var cell = mapGenerator.GetMapData(x,y);
=======
            var cell = mapGenerator.GetMapData(x, y);
>>>>>>> c30ddb5079366190c59e2dc5527c64c7e971a10c
            return cell != null;
        }
        

        public virtual void TakeDamage(int Damage)
        {
            energy -= Damage;
            CheckDead();
        }
        


        public void Heal(int healPoint)
        {
            energy += healPoint;
            Debug.Log("Current Energy : " + energy);
        }


        protected virtual void CheckDead()
        {
            if (energy <= 0)
            {
                Destroy(gameObject);
            }
        }
    }
}