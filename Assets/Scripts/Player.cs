using UnityEngine;

public class Player : MonoBehaviour
{

    private float moveSpeed = 5f;
    private float jumpForce = 10f;


    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Movement
        float moveInput = Input.GetAxisRaw("Horizontal");

        //move left-right
        rb.linearVelocity = new Vector2 (moveInput * moveSpeed , rb.linearVelocity.y);

        //Jump
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }
}
