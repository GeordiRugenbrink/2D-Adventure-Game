using UnityEngine;
using UnityEngine.Events;

public class HealthManager : MonoBehaviour
{
    public int currentHealth;
    [SerializeField]
    private int maxHealth = 100;

    [SerializeField]
    protected UnityEvent OnDeath;

    private void Awake() {
        Utility.playerHealthManager = this;
        currentHealth = maxHealth;
    }

    private void Update() {
        if(currentHealth <= 0) {
            Death();
        }
    }

    public void TakeDamage(int amount) {
        currentHealth -= amount;
    }

    private void Death() {
        OnDeath.Invoke();
    }
}
