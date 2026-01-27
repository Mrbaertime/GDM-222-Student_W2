using UnityEngine;

namespace Solution
{
    [CreateAssetMenu(fileName = "EquipmentItem", menuName = "Items/EquipmentItem")]
    public class EquipmentItem : ItemData
    {
        public int defense;
        public enum Slot { Head, Chest, Legs }
        public Slot armorSlot;
        public override void Use(Identity identity)
        {
            Debug.Log($"สวมใส่ {ItemName} ในช่อง {armorSlot}");
        }

    }
}
