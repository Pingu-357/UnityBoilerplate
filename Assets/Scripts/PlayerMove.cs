using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;
    bool isGrounded;
    void Start()
    {
        this.rb = GetComponent<Rigidbody2D>();
    }

    public void Update()
    {
        

        if (Input.GetKey(KeyCode.W) && isGrounded == true)
            rb.velocity = new Vector2(0, 5);

        if (Input.GetKey(KeyCode.A))
            rb.velocity = new Vector2(-5, 0);
        if (Input.GetKey(KeyCode.D))
            rb.velocity = new Vector2(5, 0);

    }
    
    void OnCollisionEnter2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
}

void OnCollisionExit2D(Collision2D collision)
{
    if (collision.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;
    }
}
}