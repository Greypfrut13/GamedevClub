using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] [Min(0.0f)] private float _maxHealth;

    [SerializeField] private HealthBar _healthBar;

    protected float _currentHealth;

    private void Start() 
    {
        _currentHealth = _maxHealth;

        _healthBar.UpdateHealthBar(_currentHealth, _maxHealth);
    }

    public void TakeDamage(float damage)
    {
        if(damage <= _currentHealth)
        {
            _currentHealth -= damage;

            _healthBar.UpdateHealthBar(_currentHealth, _maxHealth);

            if(_currentHealth <= 0)
            {
                Die();
            }
        }
    }

    public virtual void Die()
    {
        Destroy(gameObject);
    }
}
