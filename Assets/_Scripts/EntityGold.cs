using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityGold : MonoBehaviour
{
    [SerializeField] private GoldUI _goldUI;
    public int CurrentGold { get; private set; }

    public void AddGold(int gold)
    {
        CurrentGold += gold;
        _goldUI.UpdateGoldText();
    }
}
