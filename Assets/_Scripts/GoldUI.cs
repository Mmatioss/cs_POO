using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldUI : MonoBehaviour
{
    [SerializeField] private EntityGold _entityGold;
    [SerializeField] private TMPro.TextMeshProUGUI _goldText;

    void Start()
    {
        _goldText.text = "Gold: " + _entityGold.CurrentGold.ToString();
    }

    public void UpdateGoldText()
    {
        _goldText.text = "Gold: " + _entityGold.CurrentGold.ToString();
    }
}
