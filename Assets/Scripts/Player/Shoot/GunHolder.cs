using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GunHolder : MonoBehaviour
{
    [SerializeField] private Gun _gun;

    [SerializeField] private ShootRange _shootRange;

    [SerializeField] private ReloadButton _reloadButton;

    private void Start() 
    {
        Vector3 shootRangeRadius = new Vector3(_gun.ShootRange, _gun.ShootRange, 1);
        _shootRange.SetRangeRadius(shootRangeRadius);

        _reloadButton.SetReloadButton(_gun);
    }

    public void TryShoot()
    {
        if(_shootRange.EnemyInRadius != null && _gun.CurrentBulletsInClip > 0)
        {
            _gun.Shoot(_shootRange.EnemyInRadius);

            _reloadButton.UpdateBulletsText(_gun);
        }
        else if(_gun.CurrentBulletsInClip <= 0)
        {
            _gun.Reload(_reloadButton);

            _reloadButton.UpdateBulletsText(_gun);
        }
    }
}
