using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    private Dictionary<ItemData, Item> m_itemDictionary;
    public List<Item> inventory { get; private set; }

    public void Awake()
    {
        inventory = new List<Item>();
        m_itemDictionary = new Dictionary<ItemData, Item>();
    }

    public void Add(ItemData refData)
    {
        if (m_itemDictionary.TryGetValue(refData, out Item value))
        {
            value.AddToStack();
        }
        else
        {
            Item newItem = new Item(refData);
            inventory.Add(newItem);
            m_itemDictionary.Add(refData, newItem);
        }
    }

    public void Remove(ItemData refData)
    {
        if (m_itemDictionary.TryGetValue(refData, out Item value))
        {
            value.RemoveFromStack();

            if (value.stackSize == 0)
            {
                inventory.Remove(value);
                m_itemDictionary.Remove(refData);
            }
        }
    }
}
