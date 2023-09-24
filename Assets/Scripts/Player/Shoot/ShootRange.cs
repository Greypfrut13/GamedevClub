using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootRange : MonoBehaviour
{
    private EnemyHealth _enemyInRadius;

    public EnemyHealth EnemyInRadius => _enemyInRadius;

    public void SetRangeRadius(Vector3 newRadius)
    {
        transform.localScale = newRadius;
    }

    private void OnTriggerStay2D(Collider2D other) 
    {
        if(other.TryGetComponent(out EnemyHealth enemy))
        {
            _enemyInRadius = enemy;
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.TryGetComponent(out EnemyHealth enemy))
        {
            _enemyInRadius = null;
        }
    }
}
