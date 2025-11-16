using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOneMove : MonoBehaviour
{
    public Rigidbody2D rb;
    public float leftRightSpeed = 5f;
    public float upSpeed = 10f;
    public bool isGrounded;

    void Update()
    {
        if(Input.GetKey(KeyCode.A))
        {
            rb.velocity = new Vector2(-leftRightSpeed, rb.velocity.y);
        }
        else if(Input.GetKey(KeyCode.D))
        {
            rb.velocity = new Vector2(leftRightSpeed, rb.velocity.y);
        }

        if(Input.GetKey(KeyCode.W) && isGrounded) 
        {
            rb.velocity = new Vector2(rb.velocity.x, upSpeed);
        }

    }
}
