using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryButton : MonoBehaviour
{
    [SerializeField] private GameObject _inventoryMenu;

    private Button _button;

    private bool _state = false;

    private void Start() 
    {
        _button = GetComponent<Button>();
        _button.onClick.AddListener(ChangeState);

        _inventoryMenu.gameObject.SetActive(_state);
    }

    private void ChangeState()
    {
        _state = !_state;

        _inventoryMenu.SetActive(_state);
    }
}
