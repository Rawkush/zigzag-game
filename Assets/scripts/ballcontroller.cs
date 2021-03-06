﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour {
    [SerializeField]
    private float speed;
    bool started; 
    Rigidbody rb;
    public static bool gameOver;
    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
        started = false;
        gameOver = false;
	}
	
	// Up date is called once per frame
	void Update () {
        if (!started)
        {
            if (Input.GetMouseButtonDown(0))
            {

                rb.velocity = new Vector3(speed, 0, 0);
                started = true;
            }
        }

        Debug.DrawRay(transform.position, Vector3.down, Color.red);

        if(!Physics.Raycast(transform.position,Vector3.down,1f))// for checkin ball is above platformnor not
        {
            gameOver = true;
            rb.velocity = new Vector3(0, -25f, 0);
          //  Camera.main.GetComponent<CameraaFollow>().gameOver =true;
           
        }
         if (Input.GetMouseButtonDown(0)&& !gameOver) { 
        
            SwitchDirection();
        }

	}

    void SwitchDirection()
    {
        if (rb.velocity.z > 0)
        {
            rb.velocity = new Vector3(speed, 0, 0);
        }
        else if (rb.velocity.x > 0)
        {
            rb.velocity = new Vector3(0, 0, speed);
        }
    }
 
    

}
