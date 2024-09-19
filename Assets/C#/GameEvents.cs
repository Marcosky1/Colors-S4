using System;

public static class GameEvents
{
    // Evento pierde vida
    public static Action<int> OnHealthUpdated;

    // Evento puntaje 
    public static Action<int> OnScoreUpdated;

    public static System.Action<int> OnScoreUIUpdate;

    // Evento muerte
    public static Action PlayerDied;

    // Evento gana
    public static Action PlayerWon;
}

