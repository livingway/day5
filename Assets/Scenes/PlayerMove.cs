using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float moveSpeed = 20f;
    public float angularSpeed = 45.0f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        transform.Translate(0,0, moveSpeed * Time.deltaTime);

        //      if (Input.GetKeyDown(KeyCode.A))

        //      { transform.Rotate(0, 0, -h * angularSpeed * Time.deltaTime); }


        //if (Input.GetKeyDown(KeyCode.D))

        //{ transform.Rotate(0, 0, h * angularSpeed * Time.deltaTime); }

        transform.Rotate(v * angularSpeed, 0, -h * angularSpeed); 

	}
}
