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
        Move();
        Jump();
        IsffectActive();

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

    //set movespeed
    public void SetMoveSpeed(float newSpeed)
    {
        moveSpeed += newSpeed;
        Debug.Log($"Player : Speed {moveSpeed}");
    }

    //set super jump
    public void SetSuperJump(float newJump)
    {
        jumpForce += newJump;
        Debug.Log($"Player : Jump {jumpForce}");
    }

    //set Invulerability
    public void SetInvulnerability(bool isEnabled)
    {
        IsEffectActive = isEnabled;
        Debug.Log($"Player : IsffectActive {IsEffectActive}");
    }

    //use item
    public void OnTriggerEnter2D(Collider2D other)
    {
       PowerUpBase Item = other.GetComponent<PowerUpBase>();

       if (other == true)
        {
            Item.ApplyEffect(this);


        }
    }

    public void Move()
    {
        Debug.Log($"Player : Speed {moveSpeed}");
    }

    public void Jump()
    {
        Debug.Log($"Player : Jump {jumpForce}");
    }

    public void IsffectActive()
    {
        Debug.Log($"Player : IsffectActive {IsEffectActive}");
    }

}
