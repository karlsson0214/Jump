using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    private Rigidbody2D rb;
    public float maxJumpVelocity = 20;
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
        if (Input.GetKey(KeyCode.Space))
        {
            rb.velocity = new Vector2(rb.velocity.x, maxJumpVelocity);
        }
        if (Input.GetKey(KeyCode.A))
        {
            // move left
            rb.velocity = new Vector2(-5, rb.velocity.y);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            // move right
            rb.velocity = new Vector2(5, rb.velocity.y);
        }
        
    }
}
