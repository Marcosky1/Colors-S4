using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu(fileName = "LifeData", menuName = "ScriptableObject/LifeData", order = 0)]

public class LifeEvent : ScriptableObject
{
    public delegate void LifeUpdate(int newLife);
    public event LifeUpdate OnLifeUpdate;
    public delegate void PlayerDeath();
    public event PlayerDeath OnPlayerDeath; 

    public void RaiseEvent(int currentHealth)
    {
        OnLifeUpdate?.Invoke(currentHealth);
        if (currentHealth <= 0)  
        {
            OnPlayerDeath?.Invoke();
        }
    }
}
