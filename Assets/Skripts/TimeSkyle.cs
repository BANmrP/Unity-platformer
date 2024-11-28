using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSkyle : MonoBehaviour
{
    public float Scale = 1;
    public float UpTime = 0.5f;

    public GameObject pula;

    private Fire fire;

    void Start()
    {
       fire = pula.GetComponent<Fire>();
    }

    void Update()
    {
        if(Input.GetMouseButton(0))
        {
            Time.timeScale = UpTime;
            fire.speed = 1.5f;
        }

        else if (!Input.GetMouseButton(0))
        {                      
            Time.timeScale = Scale;
            fire.speed = 2.5f;
        }
    }
}
