using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{

    private Rigidbody2D rb;
    
    public static Transform player;
    public Transform Dulo;
    public Transform SpawnPula;

    public float pause;

    public GameObject pula;

    public ParticleSystem Efect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Fire();    
    }

    void Update()
    {
        var direction = player.position - transform.position;
        var angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    public void Fire()
    {
        StartCoroutine(spawn());
    }

    IEnumerator spawn()
    {
        yield return new WaitForSeconds(pause);
        Instantiate(pula, SpawnPula.position, SpawnPula.rotation);
        Efect.Play();
        Fire();
    }
}
