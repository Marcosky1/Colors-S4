using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    private int currentHealth;
    private SpriteRenderer spriteRenderer;

    private void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        GameEvents.OnHealthUpdated?.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        GameEvents.OnHealthUpdated?.Invoke(currentHealth);

        if (currentHealth <= 0)
        {
            GameEvents.PlayerDied?.Invoke();
        }
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        GameEvents.OnHealthUpdated?.Invoke(currentHealth);
    }

    private bool IsSameColor(GameObject obstacle)
    {
        SpriteRenderer obstacleRenderer = obstacle.GetComponent<SpriteRenderer>();
        if (obstacleRenderer != null)
        {
            return spriteRenderer.color == obstacleRenderer.color;
        }
        return false;
    }
}



