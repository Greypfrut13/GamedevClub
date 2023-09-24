using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public Action<Item> OnItemAdded;

    private List<Item> _inventoryItems = new List<Item>();

    public List<Item> InventoryItems => _inventoryItems;

    public void AddItem(Item item)
    {
        _inventoryItems.Add(item);

        OnItemAdded?.Invoke(item);
    }
}
