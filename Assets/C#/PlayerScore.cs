using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    private int currentScore = 0;

    void OnEnable()
    {
        GameEvents.OnScoreUpdated += AddScore; 
    }

    void OnDisable()
    {
        GameEvents.OnScoreUpdated -= AddScore;
    }

    private void AddScore(int value)
    {
        currentScore += value;
        UpdateScoreUI();
    }

    private void UpdateScoreUI()
    {
        GameEvents.OnScoreUIUpdate?.Invoke(currentScore); 
    }
}

