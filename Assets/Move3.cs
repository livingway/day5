using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move3 : MonoBehaviour {

    public float moveSpeed = 4.0f;
    public float angularSpeed = 360;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		float h = Input.GetAxis("Horizontal");
		float v = Input.GetAxis("Vertical");

        transform.Translate(0, v * moveSpeed * Time.deltaTime, 0);
        transform.Rotate(0, 0, -h * angularSpeed * Time.deltaTime);




	}
}
