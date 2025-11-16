using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlLight : MonoBehaviour
{
    private Transform[] platforms = new Transform[6];
    int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i] = transform.GetChild(i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {

            if (index == platforms.Length - 1) return;
            index++;
            platforms[index].GetChild(0).gameObject.SetActive(true);
            platforms[index - 1].GetChild(0).gameObject.SetActive(false);

        }
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {

            if (index == 0) return;
            index--;
            platforms[index].GetChild(0).gameObject.SetActive(true);
            platforms[index + 1].GetChild(0).gameObject.SetActive(false);

        }
    }
}
