using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameUI : MonoBehaviour
{
    public GameObject victoryScreen;
    public GameObject defeatScreen;

    public Text resultText;
    public Text timeText;
    public Button retryButton;
    public Button menuButton;
    public Button nextLevelButton;

    private void OnEnable()
    {
        GameEvents.PlayerDied += ShowDefeatScreen;
        GameEvents.PlayerWon += ShowVictoryScreen;

    }

    private void OnDisable()
    {
        GameEvents.PlayerDied -= ShowDefeatScreen;
        GameEvents.PlayerWon -= ShowVictoryScreen;
    }

    private void Start()
    {
        retryButton.onClick.AddListener(RestartLevel);
        menuButton.onClick.AddListener(GoToMenu);
        nextLevelButton.onClick.AddListener(LoadNextLevel);
      
    }

    private void ShowVictoryScreen()
    {
        resultText.gameObject.SetActive(true);
        timeText.gameObject.SetActive(true);
        victoryScreen.SetActive(true);
        defeatScreen.SetActive(false);
        resultText.text = "You Won!";
        timeText.text = "Time: " + GetCurrentTime();
        ToggleButtons(true, true, true); 
    }

    private void ShowDefeatScreen()
    {
        resultText.gameObject.SetActive(true);
        timeText.gameObject.SetActive(true);
        victoryScreen.SetActive(false);
        defeatScreen.SetActive(true);
        resultText.text = "You Lost!";
        timeText.text = "Time: " + GetCurrentTime();
        ToggleButtons(true, true, false); 
    }

    private void ShowNextLevelScreen()
    {
        resultText.gameObject.SetActive(true);
        timeText.gameObject.SetActive(true);
        victoryScreen.SetActive(false);
        defeatScreen.SetActive(false);
        resultText.text = "Level Completed!";
        timeText.text = "Time: " + GetCurrentTime();
        ToggleButtons(true, false, true); 
    }

    private void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void GoToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    private void LoadNextLevel()
    {
        int nextLevelIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextLevelIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(nextLevelIndex);
        }
        else
        {
            SceneManager.LoadScene("Menu");
        }
    }

    private string GetCurrentTime()
    {
        return "00:00";
    }

    private void ToggleButtons(bool retry, bool menu, bool nextLevel)
    {
        retryButton.gameObject.SetActive(retry);
        menuButton.gameObject.SetActive(menu);
        nextLevelButton.gameObject.SetActive(nextLevel);
    }
}


