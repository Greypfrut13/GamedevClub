using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Gun : MonoBehaviour
{
    [SerializeField] [Min(0.0f)] protected float _damage;
    [SerializeField] [Min(0.0f)] protected int _bulletsInClip;
    [SerializeField] [Min(0.0f)] protected float _reloadTime;
    [SerializeField] [Min(0.0f)] private float _shootRange;

    [Header("Effects")]
    [SerializeField] protected ParticleSystem _shootParticles;
    [SerializeField] protected AudioClip _shootSound;
    [SerializeField] protected AudioClip _reloadSound;

    protected AudioSource _audioSource;

    protected int _currentBulletsInClip;
  
    public float ShootRange => _shootRange;

    public int CurrentBulletsInClip => _currentBulletsInClip;

    public int BulletsInClip => _bulletsInClip;

    private void Awake() 
    {
        _currentBulletsInClip = _bulletsInClip;
    }

    private void Start() 
    {
        _audioSource = GetComponent<AudioSource>();   
    }

    public virtual void Shoot(EnemyHealth target)
    {
    } 

    public virtual void Reload(ReloadButton reloadButton)
    {
        
    }

    public virtual IEnumerator ReloadCoroutine(ReloadButton reloadButton)
    {
        return null;
    }
}
