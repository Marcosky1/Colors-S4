using UnityEngine;
public class Collectable : MonoBehaviour
{
    public enum CollectableType { Coin, Heart }
    public CollectableType type;
    public int value = 1;
    public ScoreEvent scoreEvent;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            if (type == CollectableType.Coin)
            {
                scoreEvent.RaiseEvent(value);
            }
            else if (type == CollectableType.Heart)
            {
                collision.GetComponent<PlayerHealth>().Heal(value);
            }
            Destroy(gameObject);
        }
    }
}

