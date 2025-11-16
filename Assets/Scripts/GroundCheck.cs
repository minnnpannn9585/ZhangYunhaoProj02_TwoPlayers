using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundCheck : MonoBehaviour
{
    [HideInInspector]
    public PlayerOneMove playerOneMove;

    private void Start()
    {
        playerOneMove = GetComponentInParent<PlayerOneMove>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerOneMove.isGrounded = true;
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            playerOneMove.isGrounded = false;
        }
    }
}
