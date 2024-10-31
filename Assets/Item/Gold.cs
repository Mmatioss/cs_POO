using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gold : Item
{
    [SerializeField] private int _gold;

    public override void Use(PickUpItem pui)
    {
        base.Use(pui);

        pui.EntityGold.AddGold(_gold);
    }
    
}
