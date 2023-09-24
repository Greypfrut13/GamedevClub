using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ReloadButton : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _bulletsText;
    [SerializeField] private ReloadFillImage _fillImage;

    private Button _button;

    private void Awake() 
    {
        _button = GetComponent<Button>();

        _fillImage.gameObject.SetActive(false);
    }

    public void SetReloadButton(Gun gun)
    {
        UpdateBulletsText(gun);

        UnityAction ua;
        ua = new UnityAction(() => gun.Reload(this));
        _button.onClick.AddListener(ua);

        _button.onClick.AddListener(ua);
    }

    public void UpdateBulletsText(Gun gun)
    {
        _bulletsText.text = gun.CurrentBulletsInClip + " / " + gun.BulletsInClip;
    }

    public void ReloadFillImage(float reloadTime)
    {
        _fillImage.SetMaxTime(reloadTime);

        _fillImage.gameObject.SetActive(true);
    }
}
