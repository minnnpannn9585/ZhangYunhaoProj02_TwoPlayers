using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartEndManager : MonoBehaviour
{
    public Transform startPos;
    public Transform endPos;
    int startIndex;
    public Transform player;
    int endIndex;
    public GameObject endPrefab;
    float timer = 5f;
    GameObject lastEndObject;

    // Start is called before the first frame update
    void Start()
    {
        startIndex = Random.Range(0, 5);
        player.position = startPos.GetChild(startIndex).position;

        endIndex = Random.Range(0, 5);
        if(endIndex == startIndex)
        {
            endIndex = (endIndex + 1) % 5;
        }
        lastEndObject = Instantiate(endPrefab, endPos.GetChild(endIndex).position, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0f)
        {
            timer = 2f;
            Destroy(lastEndObject);
            endIndex = Random.Range(0, 5);
            lastEndObject = Instantiate(endPrefab, endPos.GetChild(endIndex).position, Quaternion.identity);
        }


    }
}
