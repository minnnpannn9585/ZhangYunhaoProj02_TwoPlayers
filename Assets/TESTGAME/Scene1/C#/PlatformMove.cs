using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMove : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    public bool isLeftRight;
    public bool isRotate;
    public float rotationSpeed = 100f;
    float rotation = 0f;
    [HideInInspector]
    public bool isSelected;

    public Transform pointOne;
    public Transform pointTwo;
    private float minX;
    private float minY;
    private float maxX;
    private float maxY;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        minX = pointOne.position.x;
        minY = pointOne.position.y;
        maxX = pointTwo.position.x;
        maxY = pointTwo.position.y;
    }

    void Update()
    {
        if (!isSelected)
        {
            rb.velocity = new Vector2(0f, 0f);
            return;
        }
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                rb.velocity = new Vector2(speed, 0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(-speed, 0f);
            }
            if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.LeftArrow))
            {
                rb.velocity = new Vector2(0f, 0f);
            }
            if (Input.GetKey(KeyCode.UpArrow))
            {
                rb.velocity = new Vector2(0f, speed);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(0f, -speed);
            }
            if (Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.DownArrow))
            {
                rb.velocity = new Vector2(0f, 0f);
            }
            if (isRotate == true)
            {
                if (Input.GetKey(KeyCode.K))
                {
                    rotation = rotationSpeed * Time.deltaTime;
                }
                else if (Input.GetKey(KeyCode.L))
                {
                    rotation = -rotationSpeed * Time.deltaTime;
                }
                transform.Rotate(0f, 0f, rotation);
            }

        }

        if (transform.position.x < minX)
        {
            transform.position = new Vector3(minX, transform.position.y, transform.position.z);
        }
        if (transform.position.x > maxX)
        {
            transform.position = new Vector3(maxX, transform.position.y, transform.position.z);
        }

        if (transform.position.y < minY)
        {
            transform.position = new Vector3(transform.position.x, minY, transform.position.z);
        }

        if (transform.position.y > maxY)
        {
            transform.position = new Vector3(transform.position.x, maxY, transform.position.z);
        }
    }
}
