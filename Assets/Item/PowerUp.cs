using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : Item
{
    [SerializeField] private int _powerUpAmount;
    [SerializeField] private float time;

    public override void Use(PickUpItem pui)
    {
        base.Use(pui);

        pui.HitEntity.AddPower(_powerUpAmount, time);
    }
}
