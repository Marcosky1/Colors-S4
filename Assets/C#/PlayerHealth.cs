using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    public int maxHealth = 10;
    public int currentHealth;
    private SpriteRenderer spriteRenderer;

    public LifeEvent lifeEvent;
    public LifeEvent playerDeathEvent;
    private void Start()
    {
        currentHealth = maxHealth;
        spriteRenderer = GetComponent<SpriteRenderer>();
        lifeEvent.RaiseEvent(currentHealth);
        //GameEvents.OnHealthUpdated?.Invoke(currentHealth);
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        lifeEvent.RaiseEvent(currentHealth);
        //GameEvents.OnHealthUpdated?.Invoke(currentHealth);
    }

    public void Heal(int amount)
    {
        currentHealth = Mathf.Min(currentHealth + amount, maxHealth);
        lifeEvent.RaiseEvent(currentHealth);
        //GameEvents.OnHealthUpdated?.Invoke(currentHealth);
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



