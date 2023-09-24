using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name;

    private Sprite _icon;

    private void Start() 
    {
        _icon = GetComponent<SpriteRenderer>().sprite;
    }
}
