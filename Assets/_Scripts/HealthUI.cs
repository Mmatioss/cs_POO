using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthUI : MonoBehaviour
{

    [SerializeField] Slider _slider;
    [SerializeField] TextMeshProUGUI _text;
    [SerializeField] PlayerHealth _playerHealth;

    int CachedMaxHealth { get; set; }

    void Start()
    {
        CachedMaxHealth = _playerHealth.CurrentHealth;
        _slider.maxValue = CachedMaxHealth;
        _slider.value = CachedMaxHealth;
        _text.text = $"{CachedMaxHealth} / {CachedMaxHealth}";
    }

    public void UpdateSlider(int newHealthValue)
    {
        _slider.value = newHealthValue;
        _text.text = $"{newHealthValue} / {CachedMaxHealth}";
    }

}
