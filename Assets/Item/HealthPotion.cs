using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthPotion : Item
{
    [SerializeField] private int _healAmount;

    public override void Use(PickUpItem pui)
    {
        base.Use(pui);

        pui.PlayerHealth.Heal(_healAmount);
    }

}
