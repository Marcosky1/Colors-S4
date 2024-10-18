using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "GameStateData", menuName = "ScriptableObject/GameStateData", order = 2)]

public class GameStateEvent : ScriptableObject
{
    public delegate void GameStateChange(string state);
    public event GameStateChange OnGameStateChange;

    public void RaiseEvent(string state)
    {
        OnGameStateChange?.Invoke(state);
    }
}
