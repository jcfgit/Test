using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float speed = 10;
    float horizontal;
    Rigidbody2D body;


    void Start ()
    {
        body = GetComponent<Rigidbody2D>();
    }
	
	void Update ()
    {
        horizontal = Input.GetAxis("Horizontal");
        body.velocity = new Vector2(horizontal * speed,0);

    }
}
