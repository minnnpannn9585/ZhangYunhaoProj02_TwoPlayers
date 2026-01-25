using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
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
    public bool isPlayer;
    public bool isScale;
    public Transform pointOne;
    public Transform pointTwo;
    private float minX;
    private float minY;
    private float maxX;
    private float maxY;
    public float scale;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        minX = pointOne.position.x;
        minY = pointOne.position.y;
        maxX = pointTwo.position.x;
        maxY = pointTwo.position.y;
        scale = 1.001f;
        if (!isPlayer)
        {
            if (!isRotate)
            {
                rb.velocity = new Vector2(speed, 0f);
            }
        }
        
    }
    void Update()
    {
        if (isPlayer)
        {
            if (!isSelected)
            {
                rb.velocity = new Vector2(0f, 0f);
                return;
            }
            if (isRotate == true)
            {
                if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    rotation = rotationSpeed * Time.deltaTime;
                }
                else if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    rotation = -rotationSpeed * Time.deltaTime;
                }
                transform.Rotate(0f, 0f, rotation);
            }
            else
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
            }

            if (isRotate == true)
            {
                if (transform.position.x < minX + transform.localScale.x / 2)
                {
                    transform.position = new Vector3(minX + transform.localScale.x / 2, transform.position.y, transform.position.z);
                }
                if (transform.position.x > maxX - transform.localScale.x / 2)
                {
                    transform.position = new Vector3(maxX - transform.localScale.x / 2, transform.position.y, transform.position.z);
                }

                if (transform.position.y < minY + transform.localScale.x / 2)
                {
                    transform.position = new Vector3(transform.position.x, minY + transform.localScale.x / 2, transform.position.z);
                }

                if (transform.position.y > maxY - transform.localScale.x / 2)
                {
                    transform.position = new Vector3(transform.position.x, maxY - transform.localScale.x / 2, transform.position.z);
                }
            }
            else
            {
                if (transform.position.x < minX + transform.localScale.x / 2)
                {
                    transform.position = new Vector3(minX + transform.localScale.x / 2, transform.position.y, transform.position.z);
                }
                if (transform.position.x > maxX - transform.localScale.x / 2)
                {
                    transform.position = new Vector3(maxX - transform.localScale.x / 2, transform.position.y, transform.position.z);
                }

                if (transform.position.y < minY + transform.localScale.y / 2)
                {
                    transform.position = new Vector3(transform.position.x, minY + transform.localScale.y / 2, transform.position.z);
                }

                if (transform.position.y > maxY - transform.localScale.y / 2)
                {
                    transform.position = new Vector3(transform.position.x, maxY - transform.localScale.y / 2, transform.position.z);
                }
            }
            if (isScale == true) {
                if (Input.GetKey(KeyCode.N))
                {
                    transform.localScale *= scale;
                }
                
                    //transform.localScale = new Vector3(scale, scale,scale);
                if (Input.GetKey(KeyCode.M))
                    {
                        transform.localScale /= scale;
                    }
                    //transform.localScale = new Vector3(transform.localScale.x/scale, transform.localScale.y / scale, transform.localScale.z / scale);
            } 

        }
        else {
            if (isRotate == true)
            {
                rotation = rotationSpeed * Time.deltaTime;
                transform.Rotate(0f, 0f, rotation);
            }

            if (isRotate == false)
            {
                //rb.velocity = new Vector2(speed, 0f);
                if (transform.position.x < minX + transform.localScale.x / 2)
                {
                    rb.velocity = new Vector2(speed, 0f);
                }
                if (transform.position.x > maxX - transform.localScale.x / 2)
                {
                    rb.velocity = new Vector2(-speed, 0f);
                }
            }
            
        }
    }
    
}
