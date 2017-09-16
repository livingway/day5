using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

   // Transform myTransform;
    public float moveSpeed = 4;
    public Color newColor;

	// Use this for initialization
	void Start () {

        //myTransform = GetComponent<Transform>();

	}

    // Update is called once per frame
    void Update()
    {


        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        if (Input.GetButtonDown("Fire1"))
        { Debug.Log("fire!!"); }


        transform.Translate(moveSpeed * h, moveSpeed * v, 0); 

    }

       // myTransform.Translate(0, 0, 1 * Time.deltaTime);
       
}
