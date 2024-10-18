using UnityEngine;
using UnityEngine.UI;

public class UIScoreDisplay : MonoBehaviour
{
    public Text scoreText;
    public ScoreEvent scoreEvent;
    void OnEnable()
    {
        scoreEvent.OnScoreUpdate += UpdateScoreUI;
    }

    void OnDisable()
    {
        scoreEvent.OnScoreUpdate -= UpdateScoreUI;
    }

    void UpdateScoreUI(int currentScore)
    {
        scoreText.text = "Puntaje: " + currentScore.ToString();
    }
}


