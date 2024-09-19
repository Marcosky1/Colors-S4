using UnityEngine;

public class PlayerColorChanger : MonoBehaviour
{
    public SpriteRenderer playerSprite;
    private Color currentColor;

    void Start()
    {
        currentColor = playerSprite.color;
    }

    public void ChangeColor(Color newColor)
    {
        if (!IsCollidingWithObstacle())
        {
            currentColor = newColor;
            playerSprite.color = currentColor;
        }
    }

    bool IsCollidingWithObstacle()
    {
        return false;
    }
}

