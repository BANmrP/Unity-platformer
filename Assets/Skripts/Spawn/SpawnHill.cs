using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnHill : MonoBehaviour
{
    public float pause = 60;

    public GameObject Hill;

    public Transform Spawn;

    void Start()
    {
        StartCoroutine(spawn());
    }

    void Update()
    {

    }

    public void spawnHill()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(pause);
        Instantiate(Hill, Spawn.position, Spawn.rotation);
        spawnHill();
    }
}
