using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerRatate : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        transform.Rotate(540 * Time.deltaTime, 0, 0);

	}
}
