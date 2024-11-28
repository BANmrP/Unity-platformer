using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Efect : MonoBehaviour
{
    public ParticleSystem destroy;

    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Angry"))
        {
            Instantiate(destroy, gameObject.transform.position, gameObject.transform.rotation);
            destroy.Play();
            Destroy(gameObject);
        }
    }
}
