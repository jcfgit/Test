using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5;

    void Start()
    {
        Rigidbody2D body = GetComponent<Rigidbody2D>();
        body.velocity = new Vector2(0, speed * -1);
    }


    public void OnTriggerEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Kill")) { Destroy(gameObject); }
    }
}