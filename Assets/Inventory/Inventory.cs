using System;
using System.Collections.Generic;
using UnityEngine;

namespace Pokemon.InventorySystem
{
    public class Inventory : MonoBehaviour
    {
        public ItemData[] Items => itemList.ToArray();
        [SerializeField] List<ItemData> itemList = new List<ItemData>();

        public ItemData[] GetItemsByType(ItemType targetType)
        {
            //Create a list that will hold all the items that matched the targetType
            var resultList = new List<ItemData>();
            foreach (var itemData in itemList)
            {
                if (itemData.type == targetType)
                    resultList.Add(itemData);
            }

            //Return the result as Array not List. Because we don't want caller to modify the result afterward.
            return resultList.ToArray();
        }

        public void Add(ItemData itemToAdd)
        {
            
        }

        public void Remove(ItemData itemToRemove)
        {
            
        }
    }

    [Serializable]
    public class ItemData
    {
        public string displayName;
        public string description;
        public Sprite icon;
        public ItemType type;
        public int count;
    }

    public enum ItemType
    {
        PokeBalls, 
        Items, 
        KeyItems, 
        Others
    }
}