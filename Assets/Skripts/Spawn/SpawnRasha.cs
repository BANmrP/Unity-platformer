using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnRasha : MonoBehaviour
{
    public float pause = 60;

    public GameObject Rasha;

    public Transform[] Spawn;

    private int sp = 0;

    void Start()
    {
        StartCoroutine(spawn());
    }

    void Update()
    {
        
    }

    public void spawnRasha()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(pause);

        if (sp == 0)
        {
            Instantiate(Rasha, Spawn[0].position, Spawn[0].rotation);
            sp++;
        }

        else if (sp == 1)
        {
            Instantiate(Rasha, Spawn[1].position, Spawn[1].rotation);
            sp++;
        }

        else if (sp == 2)
        {
            Instantiate(Rasha, Spawn[0].position, Spawn[0].rotation);
            Instantiate(Rasha, Spawn[1].position, Spawn[1].rotation);
            sp = 0;
        }
    
        spawnRasha();
    }
}
