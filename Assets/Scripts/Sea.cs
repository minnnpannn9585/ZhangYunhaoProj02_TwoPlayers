using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sea : MonoBehaviour
{
    public bool isIncreasing = false;
    public float increaseSpeed;
    
    void Update()
    {
        if (isIncreasing)
        {
            transform.parent.localScale += new Vector3(0, increaseSpeed, 0) * Time.deltaTime;

            if (transform.parent.localScale.y > 10f)
            {
                isIncreasing = false;
            }
        }
    }
    
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            isIncreasing = true;
            Destroy(other.gameObject);
        }
    }

}
