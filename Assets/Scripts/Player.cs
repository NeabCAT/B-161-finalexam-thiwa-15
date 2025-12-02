using UnityEngine;

public class Player : MonoBehaviour
{

    [field : SerializeField] private float moveSpeed = 5f;
    [field : SerializeField] private float jumpForce = 10f;

    [field : SerializeField] private bool IsEffectActive = false;

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

    public void SetMoveSpeed(float value)
    {
        moveSpeed += value;
    }

    public void SetSuperJump(float value)
    {
        jumpForce += value;
    }

    public void SetInvulnerability(bool value)
    {
        IsEffectActive = true ;
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
       PowerUpBase Item = other.GetComponent<PowerUpBase>();

       if (other == true)
        {
           
            
        }
    }

}
