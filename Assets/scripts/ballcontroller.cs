using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ballcontroller : MonoBehaviour {
    [SerializeField]
    private float speed;

    Rigidbody rb;

    private void Awake() {
        rb = GetComponent<Rigidbody>();
    }

    // Use this for initialization
    void Start () {
        rb.velocity = new Vector3(speed, 0, 0);
	}
	
	// Up date is called once per frame
	void Update () {
		
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
