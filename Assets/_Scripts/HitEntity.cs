using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitEntity : MonoBehaviour
{
    [SerializeField]private int _damage;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.GetComponent<EntityHealth>())
        {
            other.gameObject.GetComponent<EntityHealth>().TakeDamage(_damage);
        }
        else if(other.gameObject.GetComponent<PlayerHealth>())
        {
            other.gameObject.GetComponent<PlayerHealth>().TakeDamage(_damage);
        }
    }

    public void AddPower(int powerUpAmount, float time)
    {
        _damage += powerUpAmount;
        StartCoroutine(PowerUpTimer(time, powerUpAmount));
    }

    private IEnumerator PowerUpTimer(float time, int powerUpAmount)
    {
        yield return new WaitForSeconds(time);
        _damage -= powerUpAmount;
    }
}
