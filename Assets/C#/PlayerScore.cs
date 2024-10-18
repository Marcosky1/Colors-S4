using UnityEngine;

public class PlayerScore : MonoBehaviour
{
    public int currentScore = 0;
    public ScoreEvent scoreEvent;
    void OnEnable()
    {
    }

    void OnDisable()
    {
    }

    public void AddScore(int value)
    {
        currentScore += value;
        scoreEvent.RaiseEvent(currentScore);
    }
}

