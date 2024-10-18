using UnityEngine;
using UnityEngine.UI;

public class UIHealthDisplay : MonoBehaviour
{
    public Text healthText;
    public LifeEvent lifeEvent;
    public void OnEnable()
    {
        lifeEvent.OnLifeUpdate += UpdateHealthUI;
        lifeEvent.OnPlayerDeath += NotifyPlayerDeath;
    }

    public void OnDisable()
    {
        lifeEvent.OnLifeUpdate -= UpdateHealthUI;
        lifeEvent.OnPlayerDeath -= NotifyPlayerDeath;
    }

    public void UpdateHealthUI(int currentHealth)
    {
        healthText.text = "Vida: " + currentHealth.ToString();
    }
    private void NotifyPlayerDeath()
    {
        Debug.Log("murio");
    }
}

