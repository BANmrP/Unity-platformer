using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IIfly : MonoBehaviour
{
    private Transform player;

    public float speed = 20;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();      
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, player.position, speed * Time.deltaTime);
    }

    private void OnCollisionStay2D(Collision2D col)
    {
        if (col.collider.tag == "Player")
        {
            XP.xp = XP.xp - 0.006f;           
        }

        if (col.collider.tag == "Angry")
        {
            Score.coin += 1;
            Destroy(gameObject);          
        }
    }
}
