using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "ScoreData", menuName = "ScriptableObject/ScoreData", order = 1)]

public class ScoreEvent : ScriptableObject
{
    public delegate void ScoreUpdate(int newScore);
    public event ScoreUpdate OnScoreUpdate;

    public void RaiseEvent(int newScore)
    {
        OnScoreUpdate?.Invoke(newScore);
    }
}
