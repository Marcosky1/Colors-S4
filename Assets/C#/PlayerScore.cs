using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int currentScore = 0;
    public ScoreEvent scoreEvent;
    void OnEnable()
    {
        scoreEvent.OnScoreUpdate += AddScore;
    }

    void OnDisable()
    {
        scoreEvent.OnScoreUpdate -= AddScore;
    }

    public void AddScore(int value)
    {
        currentScore += value;
    }
}

