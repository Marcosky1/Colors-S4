using UnityEngine;
using UnityEngine.UI;

public class UIHealthDisplay : MonoBehaviour
{
    public Text healthText;

    public void OnEnable()
    {
        GameEvents.OnHealthUpdated += UpdateHealthUI;
    }

    public void OnDisable()
    {
        GameEvents.OnHealthUpdated -= UpdateHealthUI;
    }

    public void UpdateHealthUI(int currentHealth)
    {
        healthText.text = "Vida: " + currentHealth.ToString();
    }
}

