using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ShootButton : MonoBehaviour
{
    [SerializeField] private GunHolder _gunHolder;

    private Button _button;

    private void Start() 
    {
        _button = GetComponent<Button>();

        _button.onClick.AddListener(_gunHolder.TryShoot);
    }
}
