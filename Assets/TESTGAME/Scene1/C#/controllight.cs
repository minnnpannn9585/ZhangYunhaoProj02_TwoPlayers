using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime;
using UnityEngine;

public class controllight : MonoBehaviour
{
    private Transform[] platforms = new Transform[6];
    public GameObject[] platformFrames;
    public int index = 0;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < platforms.Length; i++)
        {
            platforms[i] = transform.GetChild(i);
            platforms[i].GetComponent<PlatformMove>().isSelected = false;
        }
        platforms[0].GetComponent<PlatformMove>().isSelected = true;
        platformFrames[0].SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Slash))
        {
            index++;
            if (index != platforms.Length)
            {
                platforms[index].GetChild(0).gameObject.SetActive(true);
                platformFrames[index].SetActive(true);
                platforms[index - 1].GetChild(0).gameObject.SetActive(false);
                platforms[index].GetComponent<PlatformMove>().isSelected = true;
                platformFrames[index - 1].SetActive(false);
                platforms[index - 1].GetComponent<PlatformMove>().isSelected = false;

            }
            else
            {
                index = 0;
                platforms[index].GetChild(0).gameObject.SetActive(true);
                platformFrames[index].SetActive(true);
                platforms[platforms.Length - 1].GetChild(0).gameObject.SetActive(false);
                platforms[index].GetComponent<PlatformMove>().isSelected = true;
                platformFrames[platforms.Length - 1].SetActive(false);
                platforms[platforms.Length - 1].GetComponent<PlatformMove>().isSelected = false;
            }
        }
        if (Input.GetKeyDown(KeyCode.Comma))
        {
            index--;
            if (index != -1)
            {
                platforms[index].GetChild(0).gameObject.SetActive(true);
                platformFrames[index].SetActive(true);
                platforms[index].GetComponent<PlatformMove>().isSelected = true;
                platforms[index + 1].GetChild(0).gameObject.SetActive(false);
                platformFrames[index + 1].SetActive(false);
                platforms[index + 1].GetComponent<PlatformMove>().isSelected = false;
            }
            else
            {
                index = platforms.Length - 1;
                platforms[index].GetChild(0).gameObject.SetActive(true);
                platformFrames[index].SetActive(true);
                platforms[0].GetChild(0).gameObject.SetActive(false);
                platforms[index].GetComponent<PlatformMove>().isSelected = true;
                platformFrames[0].SetActive(false);
                platforms[0].GetComponent<PlatformMove>().isSelected = false;
            }
        }
    }
}
