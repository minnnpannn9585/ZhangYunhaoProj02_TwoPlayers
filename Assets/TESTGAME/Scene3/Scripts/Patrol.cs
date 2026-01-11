using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour
{
    public Transform pointA;
    public Transform pointB;
    public float speed = 2f;
    public Transform obj;
    bool movingToB = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(movingToB)
        {
            obj.position = Vector2.MoveTowards(obj.position, pointB.position, speed * Time.deltaTime);
            if(Vector2.Distance(obj.position, pointB.position) < 0.1f)
            {
                movingToB = false;
            }
        }
        else
        {
            obj.position = Vector2.MoveTowards(obj.position, pointA.position, speed * Time.deltaTime);
            if(Vector2.Distance(obj.position, pointA.position) < 0.1f)
            {
                movingToB = true;
            }
        }
    }
}
