using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraaFollow : MonoBehaviour {

    public GameObject ball;
    Vector3 offset;
    float lerpRate; 
	// Use this for initialization 
	void Start () {

        offset = ball.transform.position - transform.position;

	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void Follow()
    {
        Vector3 pos = transform.position;
        Vector3 targetpos = transform.position + offset;
        Vector3.Lerp(pos, targetpos, lerpRate * Time.deltaTime);
    }

}
