using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{

    private Rigidbody2D rb;

    public float speed = 2;
    public float up = 3;

    public bool d = true;

    public XP heath;

    private TrailRenderer PlayerTrain;

    private int Check = 0;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        PlayerTrain = GetComponent<TrailRenderer>();
        PlayerTrain.enabled = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && d == true)
        {
            rb.AddForce(transform.up * up);
            DablJump();
        }
    }

    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            speed = 6;
            gameObject.transform.localScale = new Vector3(0.5f, 0.325f, 0);
            PlayerTrain.enabled = true;
        }

        else if (!Input.GetKey(KeyCode.LeftShift))
        {
            speed = 3;
            gameObject.transform.localScale = new Vector3(0.5f, 0.5f, 0);
            PlayerTrain.enabled = false;
        }

        if (Input.GetKey(KeyCode.D))
        {
            transform.position += transform.right * speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.A))
        {
            transform.position += transform.right * -speed * Time.deltaTime;
        }
    }

    private void DablJump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Check++;
        }

        if (Check == 2)
        {
            d = false;
            Check = 0;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.CompareTag("Stop"))
        {
            d = true;
        }               
    }
}