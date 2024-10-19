using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private int jumpCount = 0;
    private PlayerHealth playerHealth;
    public Transform groundCheck; 
    public LayerMask groundLayer;

    public GameStateEvent gameStateEvent;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        playerHealth = GetComponent<PlayerHealth>();
    }

    void Update()
    {
        Move();
        Jump();
    }

    void Move()
    {
        float move = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(move * speed, rb.velocity.y);
    }

    void Jump()
    {
        if (Input.GetKeyDown(KeyCode.Space) && (isGrounded || jumpCount < 2))
        {
            rb.velocity = new Vector2(rb.velocity.x, jumpForce);
            jumpCount++;
        }

        isGrounded = Physics2D.Raycast(groundCheck.position, Vector2.down, 0.1f, groundLayer);
        if (isGrounded)
        {
            jumpCount = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (!IsSameColor(collision.gameObject))
            {
                playerHealth.TakeDamage(1);
            }
        }
        if (collision.gameObject.CompareTag("NextLevelObject"))
        {
            gameStateEvent.RaiseNextLevel();
        }

        if (collision.gameObject.CompareTag("VictoryObject"))
        {
            gameStateEvent.RaiseEvent("Victory");
        }
        if (playerHealth.currentHealth <= 0)
        {
            gameStateEvent.RaiseEvent("Defeat");
        }
    }

    private bool IsSameColor(GameObject obstacle)
    {
        SpriteRenderer playerRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer obstacleRenderer = obstacle.GetComponent<SpriteRenderer>();
        return playerRenderer.color == obstacleRenderer.color;
    }
}

