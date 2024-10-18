using UnityEngine;

[CreateAssetMenu(fileName = "PlayerHealthHandler", menuName = "Handlers/PlayerHealthHandler")]
public class PlayerHealthHandler : ScriptableObject
{
    public delegate void HealthUpdated(int currentHealth);
    public event HealthUpdated OnHealthUpdated;

    public void UpdateHealth(int health)
    {
        OnHealthUpdated?.Invoke(health);
    }
}

