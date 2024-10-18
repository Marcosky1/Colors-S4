using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "PlayerScoreHandler", menuName = "Handlers/PlayerScoreHandler")]
public class PlayerScoreHandler : ScriptableObject
{
    public delegate void ScoreUpdated(int currentScore);
    public event ScoreUpdated OnScoreUpdated;

    public void UpdateScore(int score)
    {
        OnScoreUpdated?.Invoke(score);
    }
}

