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

    //set movespeed
    public void SetMoveSpeed(float value)
    {
        moveSpeed += value;
    }

    //set super jump
    public void SetSuperJump(float value)
    {
        jumpForce += value;
    }

    //set Invulerability
    public void SetInvulnerability(bool value)
    {
        IsEffectActive = value ;
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

}
