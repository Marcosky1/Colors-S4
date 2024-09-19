using UnityEngine;
using UnityEngine.UI;

public class ColorButton : MonoBehaviour
{
    public Button button;
    public Color colorToChangeTo;
    public PlayerColorChanger playerColorChanger;

    private void Start()
    {
        button.onClick.AddListener(ChangePlayerColor);
    }

    private void ChangePlayerColor()
    {
        playerColorChanger.ChangeColor(colorToChangeTo);
    }
}

