using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] [Min(0.0f)] protected float _moveSpeed;
    [SerializeField] [Min(0.0f)] protected float _damage;
    [SerializeField] [Min(0.0f)] protected float _distanceToAttack;
    [SerializeField] [Min(0.0f)] private float _delayBetwenAttack;

    private Transform _target;
    private Vector3 _startPosition;

    private bool _canAttack = true;

    private void Start() 
    {
        _startPosition = gameObject.transform.position;
    }


    private void Update() 
    {
        MoveToTarget();
    }

    public void StartChasingTarget(Transform target)
    {
        _target = target;
    }

    public void StopChasingTarget()
    {
        _target = null;
    }

    public virtual void AttackTarget()
    {
        if(_canAttack)
        {
            _target.GetComponent<PlayerHealth>().TakeDamage(_damage);
            
            _canAttack = false;

            StartCoroutine(AttackDelay());
        }
        else
        {
            return;
        }
    }

    protected virtual void MoveToTarget()
    {
        if(_target != null)
        {
            Vector3 direction = (_target.position - transform.position).normalized;

            transform.position = transform.position + (direction * _moveSpeed * Time.deltaTime);

            if(Vector3.Distance(transform.position, _target.transform.position) <= _distanceToAttack)
            {
                AttackTarget();
            }
        }
        else
        {
            Vector3 direction = (_startPosition - transform.position).normalized;

            transform.position = transform.position + (direction * _moveSpeed * Time.deltaTime);
        }
    } 

    private IEnumerator AttackDelay()
    {
        yield return new WaitForSeconds(_delayBetwenAttack);

        _canAttack = true;
    }
}
