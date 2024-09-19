using UnityEngine;
using UnityEngine.UI;

public class UIScoreDisplay : MonoBehaviour
{
    public Text scoreText;

    void OnEnable()
    {
        GameEvents.OnScoreUIUpdate += UpdateScoreUI;  
    }

    void OnDisable()
    {
        GameEvents.OnScoreUIUpdate -= UpdateScoreUI;
    }

    void UpdateScoreUI(int currentScore)
    {
        scoreText.text = "Puntaje: " + currentScore.ToString();
    }
}


