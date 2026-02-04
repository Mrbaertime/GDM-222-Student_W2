using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Solution
{
    public class ZombieParade : OOPEnemy
    {
        // ใช้ LinkedList ในการจัดการส่วนของงูเพื่อประสิทธิภาพในการเพิ่ม/ลบ
        // ใช้ LinkedList ในการจัดการส่วนของงูเพื่อประสิทธิภาพในการเพิ่ม/ลบ
        private LinkedList<GameObject> Parade = new LinkedList<GameObject>();
        public int SizeParade = 3;
        int timer = 0;
        public GameObject[] bodyPrefab; // Prefab ของส่วนลำตัวงู
        public float moveInterval = 0.5f; // ช่วงเวลาในการเคลื่อนที่ (0.5 วินาที)

        private Vector3 moveDirection;

        public  void Start()
        {
            moveDirection = Vector3.up;
            // เริ่ม Coroutine สำหรับการเคลื่อนที่
            positionX = (int)transform.position.x;
            positionY = (int)transform.position.y;
            StartCoroutine(MoveParade());
        }
        private Vector3 RandomizeDirection()
        {
            List<Vector3> possibleDirections = new List<Vector3>
            {
                Vector3.up,
                Vector3.down,
                Vector3.left,
                Vector3.right
            };

            return possibleDirections[Random.Range(0, possibleDirections.Count)];
        }
        // Coroutine สำหรับการเคลื่อนที่ทีละช่อง
        IEnumerator MoveParade()
        {      
            //0. สร้างหัวงู
            Parade.AddFirst(this.gameObject);
            while (isAlive)
            {
                LinkedListNode<GameObject> firstNode = Parade.First;
                GameObject firstPart = firstNode.Value;

                LinkedListNode<GameObject> LastNode = Parade.Last;
                GameObject LastPart = firstNode.Value;

                Parade.RemoveLast();

                int toX = 0;
                int toY = 0;

                bool isCollide = true;
                int countTryFind = 0;

                while (isCollide == true || countTryFind > 10)
                {
                    moveDirection = RandomizeDirection();
                    toX = (int)(firstPart.transform.position.x + moveDirection.x);
                    toY = (int)(firstPart.transform.position.y + moveDirection.y);
                    countTryFind++;
                    if (countTryFind > 10)
                    {
                        toX = positionX;
                        toY = positionY;
                    }
                    isCollide = IsCollision(toX,toY);
                }

                positionX = toX;
                positionY = toY;

                LastPart.transform.position = new Vector3(positionX, positionY, 0);

                Parade.AddFirst(LastNode);

                if(Parade.Count < SizeParade)
                {
                    timer++;
                    if(timer > 3){
                        Grow();
                        timer = 0;
                    }
                }
                yield return new WaitForSeconds(moveInterval);
            }
        }
        private bool IsCollision(int x, int y)
        {
            // 4. ตรวจสอบสิ่งกีดขวาง
            if (HasPlacement(x, y))
            {
                return true;
            }
            return false;
        }
        
        // ฟังก์ชันสำหรับเพิ่มส่วนของงู (Grow)
        private void Grow()
        {
            GameObject newPart = Instantiate(bodyPrefab[0]);

            GameObject LastPart = Parade.Last.Value;

            newPart.transform.position = LastPart.transform.position;   

            Parade.AddLast(newPart);
        }

    }
}
