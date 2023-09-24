using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealth : Health
{
    [SerializeField] private Enemy _enemy;

    public override void Die()
    {
        _enemy.DropItem();

        base.Die();
    }
}
