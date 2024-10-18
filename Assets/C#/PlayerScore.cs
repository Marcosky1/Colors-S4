using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public PlayerScoreHandler scoreHandler;
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
        scoreHandler.UpdateScore(currentScore);
    }
}

