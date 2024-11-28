using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public float speed;
    public float[] distanse;

    public GameObject[] Woll;

    void Start()
    {
        
    }

    void Update()
    {
        transform.Translate(speed, 0, 0 * Time.deltaTime);

        if (Vector3.Distance(Woll[0].transform.position, gameObject.transform.position) <= distanse[0])
        {
            speed = -speed;
        }

        if (Vector3.Distance(Woll[1].transform.position, gameObject.transform.position) <= distanse[1])
        {
            speed = +speed;
        }
    }
}
