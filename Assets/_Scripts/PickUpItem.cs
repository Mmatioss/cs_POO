using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PickUpItem : MonoBehaviour
{
    [SerializeField] private EntityGold _entityGold;
    [SerializeField] private PlayerHealth _playerHealth;
    [SerializeField] private HitEntity _hitEntity;
    
    public EntityGold EntityGold => _entityGold;
    public PlayerHealth PlayerHealth => _playerHealth;
    public HitEntity HitEntity => _hitEntity;


    private void OnTriggerEnter(Collider other)
    {
        if(other.TryGetComponent(out Item item))
        {
            item.Use(this);
        }
    }



}
