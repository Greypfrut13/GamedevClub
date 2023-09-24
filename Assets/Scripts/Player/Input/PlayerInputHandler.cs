using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputHandler : MonoBehaviour
{
    [SerializeField] private PlayerMovement _playerMovement;
    [SerializeField] private Joystick _joystick;

    private void Update() 
    {
        _playerMovement.SetDirection(OnJoystickMovemet());
    }
    
    public Vector2 OnJoystickMovemet()
    {
        Vector2 direction = new Vector2(_joystick.Horizontal, _joystick.Vertical);
        return direction;
    }
}
