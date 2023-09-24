using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] [Min(0.0f)] private float _moveSpeed;

    private Vector2 _direction;

    private void Update() 
    {
        Move();
    }

    public void SetDirection(Vector2 direction)
    {
        _direction = direction;
    }

    private void Move()
    {
        Vector3 newPosition = new Vector3(_direction.x * _moveSpeed * Time.deltaTime, _direction.y * _moveSpeed * Time.deltaTime, 0);

        transform.position += newPosition;
    }
}
