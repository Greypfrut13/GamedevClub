using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemTrigger : MonoBehaviour
{
    private Item _item;

    private Collider2D _collider;

    private void Start() 
    {
        _item = GetComponentInParent<Item>();   
        _collider = GetComponent<Collider2D>();
    }

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.TryGetComponent(out PlayerInventory inventory))
        {
            _collider.enabled = false;

            inventory.AddItem(_item);

            Destroy(_item.gameObject);
        }
    }
}
