using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using UnityEngine;

public class Item : MonoBehaviour
{
    [SerializeField] private string _name;

    [SerializeField] private Sprite _icon;

    public Sprite Icon => _icon;
}
