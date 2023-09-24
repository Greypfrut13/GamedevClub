using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Marakov : Gun
{
    private bool _isReloading = false;

    public override void Shoot(EnemyHealth target)
    {
        if(_isReloading) return;

        _shootParticles.Play();
        _audioSource.PlayOneShot(_shootSound);

        target.TakeDamage(_damage);
        _currentBulletsInClip -= 1;
    }

    public override void Reload(ReloadButton reloadButton)
    {
        if(_isReloading || _currentBulletsInClip == _bulletsInClip) 
        {
            return;
        }

        _isReloading = true;

        StartCoroutine(ReloadCoroutine(reloadButton));

        _audioSource.PlayOneShot(_reloadSound);
    }

    public override IEnumerator ReloadCoroutine(ReloadButton reloadButton)
    {
        reloadButton.ReloadFillImage(_reloadTime);

        yield return new WaitForSeconds(_reloadTime);

        _currentBulletsInClip = _bulletsInClip;

        reloadButton.UpdateBulletsText(this);

        _isReloading = false;
    }
}
