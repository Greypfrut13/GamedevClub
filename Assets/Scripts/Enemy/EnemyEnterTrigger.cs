using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEnterTrigger : MonoBehaviour
{
    [SerializeField] private Enemy _enemy;

    private void OnTriggerEnter2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _enemy.StartChasingTarget(other.transform);
        }
    }

    private void OnTriggerExit2D(Collider2D other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
            _enemy.StopChasingTarget();
        }
    }
}
