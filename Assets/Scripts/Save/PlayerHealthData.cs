public class PlayerHealthData
{
    public int currentHealth;

    public PlayerHealthData(HealthManager healthManager) {
        currentHealth = healthManager.currentHealth;
    }
}
