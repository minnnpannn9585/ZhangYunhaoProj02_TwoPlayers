using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float timer = 5f;
    public Sea sea;

    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0)
        {
            sea.isIncreasing = true;
            timer = 10000f;
        }
    }
}
