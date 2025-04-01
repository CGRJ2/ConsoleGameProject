using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Week4_Day2_OOP_Project_MudGame
{

    public enum ItemType
    {
        Consumable, Armor, Weapon
    }
    public class Item
    {
        // 아이템 코드
        
        public int Code { get; protected set;}

        public string Name { get; protected set; }

        public ItemType type;

        public int ItemCount { get; set; }


        public Item()
        {

        }

        public Item(int code, string name, string itemDefine)
        {
            this.Code = code;
            this.Name = name;
        }
    }

    public class ConsumableItem : Item
    {
        
        public ConsumableItem(int code, string name)
        {
            type = ItemType.Consumable;
            this.Code = code;
            this.Name = name;
        }
    }

    public class EquipmentItem : Item
    {
        public bool isArmor = false;
        public int DEF { get; private set; }
        public int ATK { get; private set; }

        public EquipmentItem(int code, string name, bool isArmor, int def)
        {
            this.type = ItemType.Armor;
            this.Code = code;
            this.Name = name;
            this.DEF = def;
        }

        public EquipmentItem(int code, string name,  int atk)
        {
            this.type = ItemType.Weapon;
            this.Code = code;
            this.Name = name;
            this.ATK = atk;
        }
    }


    public static class ItemDataBase
    {
        // 아이템 데이터에 접근하면 안되니까 private으로 하고, 아이템 정보 받는건 public함수로 하자.
        private static Dictionary<int, Item> itemDatas = new Dictionary<int, Item>
        {
            {1, new ConsumableItem(1, "체력 포션")},
            {2, new ConsumableItem(2, "마나 포션")},
            {1001, new EquipmentItem(1001, "기본 투구", true, 30)},
            {2001, new EquipmentItem(2001, "기본 상의", true, 30)},
            {3001, new EquipmentItem(3001, "기본 하의", true, 30)},
            {4001, new EquipmentItem(4001, "기본 장갑", true, 10)},
            {5001, new EquipmentItem(5001, "기본 신발", true, 10)},
            {9001, new EquipmentItem(9001, "기본 롱소드", 40)}
        };

        public static Dictionary<int, Item> ItemDatas { get { return itemDatas; }}
    }
}
