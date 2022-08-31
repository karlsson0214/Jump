using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Rigidbody2D rb;
    public float maxJumpVelocity = 20;
    private float halfCatHeight = 0.5f;
    public bool onGround = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        
    }

    // Update is called once per frame
    void Update()
    {

        // jump
        if (Input.GetKey(KeyCode.Space) && onGround)
        {

            rb.velocity = new Vector2(rb.velocity.x, maxJumpVelocity);
        }

        if (Input.GetKey(KeyCode.A) && onGround)
        {
            // move left
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D) && onGround)
        {
            // move right
            rb.velocity = new Vector2(5, rb.velocity.y);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.StartsWith("Brick"))
        {
            if(collision.collider.transform.position.y < rb.position.y - halfCatHeight)
            {
                onGround = true;
            }
        }
    }
    // not enough with OnCollisionEnter2D. OnCollisionStay2D needed to set onGround properly.
    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.StartsWith("Brick"))
        {
            if (collision.collider.transform.position.y < rb.position.y - halfCatHeight)
            {
                onGround = true;
            }
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.collider.gameObject.name.StartsWith("Brick"))
        {
            if (collision.collider.transform.position.y < rb.position.y - halfCatHeight)
            {
                onGround = false;
            }
        }
    }
}
