using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour {

    public Transform target;


	// Use this for initialization
	void Start () {
		
	}

    private void Awake()
    {

       // target = GameObject.Find("Player").transform;
        target = GameObject.FindWithTag("Player").transform;

    }



    // Update is called once per frame
    void LateUpdate () {
      
       transform.position = Vector3.Lerp(transform.position, target.position, Time.deltaTime * 2.0f);
        transform.rotation = Quaternion.Slerp(transform.rotation, target.rotation, Time.deltaTime * 2.0f);


	}
}
