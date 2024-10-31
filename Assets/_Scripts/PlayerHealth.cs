using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] int _maxHealth;
    [SerializeField] HealthUI _healthUI;

    public int CurrentHealth { get; private set; }

    private void Awake()
    {
        CurrentHealth = _maxHealth;
    }

    private void Start()
    {
        _healthUI.UpdateSlider(CurrentHealth);
    }

    public void TakeDamage(int damage)
    {
        CurrentHealth -= damage;
        _healthUI.UpdateSlider(CurrentHealth);
        if(CurrentHealth <= 0)
        {
            Debug.Log("Player is dead");

        }
    }

    public void Heal(int healAmount)
    {
        CurrentHealth += healAmount;
        if(CurrentHealth > _maxHealth)
        {
            CurrentHealth = _maxHealth;
        }
        _healthUI.UpdateSlider(CurrentHealth);
    }
}
