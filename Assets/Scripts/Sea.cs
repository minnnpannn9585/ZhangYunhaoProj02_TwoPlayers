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
            transform.localScale += new Vector3(increaseSpeed, 0, 0) * Time.deltaTime;

            if (transform.localScale.x > 30f)
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
