using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ReloadFillImage : MonoBehaviour
{
    [SerializeField] private UnityEvent _onFinish;

    private float _maxTime;
    private float _currentTime;

    private Image _image;

    private void Start() 
    {
        _image = GetComponent<Image>();

        
        _currentTime = _maxTime;
    }

    private void Update() 
    {
        _currentTime -= Time.deltaTime;

        _image.fillAmount = _currentTime / _maxTime;

        if(_currentTime <= 0)
        {
            _currentTime = _maxTime;

            _onFinish?.Invoke();
        }
    }

    public void SetMaxTime(float maxTime)
    {
        _maxTime = maxTime;
    }

    public void OnFInish()
    {
        _image.fillAmount = 1;

        gameObject.SetActive(false);
    }
}
