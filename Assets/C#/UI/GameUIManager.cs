using System;
using UnityEngine;
using UnityEngine.UI;

public class GameUIManager : MonoBehaviour
{
    public Text timerText;
    private float startTime;
    private bool isPlaying;

    void Start()
    {
        startTime = Time.time;
        isPlaying = true;
    }

    void Update()
    {
        if (isPlaying)
        {
            float t = Time.time - startTime;
            timerText.text = "Time: " + t.ToString("F2");
        }
    }

    public void PauseGame()
    {
        isPlaying = false;
        Time.timeScale = 0f;
        // Mostrar menú de pausa
    }

    public void ResumeGame()
    {
        isPlaying = true;
        Time.timeScale = 1f;
        // Ocultar menú de pausa
    }
}

