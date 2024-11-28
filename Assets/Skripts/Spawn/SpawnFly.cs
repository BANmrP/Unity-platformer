using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnFly : MonoBehaviour
{
    public float pause = 60;

    public GameObject FlyRasha;

    public Transform Spawn;

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
        Instantiate(FlyRasha, Spawn.position, Spawn.rotation);
        spawnRasha();
    }
}
