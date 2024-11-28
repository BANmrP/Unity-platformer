using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fire : MonoBehaviour
{
    public float speed;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //transform.Translate(speed, 0, 0 * Time.deltaTime);

        rb.AddForce(transform.right * speed);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            XP.xp = XP.xp - 0.1f;
            Destroy(gameObject);
        }

        if (collision.collider.CompareTag("Stop"))
        {
            Destroy(gameObject);
        }
    }

}