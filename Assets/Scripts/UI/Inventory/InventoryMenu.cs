using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class InventoryMenu : MonoBehaviour
{
    [SerializeField] private PlayerInventory _inventory;
    [SerializeField] private RectTransform _itemsPanel;

    [SerializeField] private List<GameObject> _icons = new List<GameObject>();

    private void Start() 
    {
        _inventory.OnItemAdded += OnItemAdded;
        Redraw();
    }

    private void OnItemAdded(Item obj)
    {
        Redraw();
    }

    private void Redraw()
    {
        for(int i = 0; i < _inventory.InventoryItems.Count; i++)
        {
            Item item = _inventory.InventoryItems[i];

            Image iconImage = _icons[i].GetComponent<Image>();
            iconImage.sprite = item.Icon;
        }
    }

    private void ClearDrawn()
    {
        for(int i = 0; i < _icons.Count; i++)
        {
            Destroy(_icons[i]);
        }

        _icons.Clear();
    }
}

