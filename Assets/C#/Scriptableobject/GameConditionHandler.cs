using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "GameConditionHandler", menuName = "Handlers/GameConditionHandler")]
public class GameConditionHandler : ScriptableObject
{
    public delegate void PlayerWon();
    public event PlayerWon OnPlayerWon;

    public delegate void PlayerDied();
    public event PlayerDied OnPlayerDied;

    public void WinGame()
    {
        OnPlayerWon?.Invoke();
    }

    public void LoseGame()
    {
        OnPlayerDied?.Invoke();
    }
}

