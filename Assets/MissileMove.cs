using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MissileMove : MonoBehaviour {

    public float moveSpeed = 6.0f;



	// Use this for initialization
	void Start () {

        Destroy(gameObject, 1.0f);


	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(0, moveSpeed * Time.deltaTime, 0); 




	}
}
