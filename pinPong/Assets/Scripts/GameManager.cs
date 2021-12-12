using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    GameObject[] pins;
    // Start is called before the first frame update
    void Start()
    {
        pins = GameObject.FindGameObjectsWithTag("Pin");
    }

    // Update is called once per frame
    void Update()
    {
        /*
        if (GameObject.Find("Ball").GetComponent<Ball>().isThrown)
        {
            GameObject.Find("Camera").GetComponent<Camera>().enble;
        }*/
    }
}
