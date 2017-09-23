using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject missile;
    public Transform[] shootPosition;
    float totalTime = 0;
    public float shootTime = 0.1f;



	// Use this for initialization
	void Start () {
		
	}


    private void Awake()
    {

        InvokeRepeating("MissileShoot", 0, shootTime);

    }


    // Update is called once per frame
    void Update () {

        totalTime = totalTime + Time.deltaTime;

       
	}

    void MissileShoot ()

    {
		for (int i = 0; i < shootPosition.Length; i++)
		{
			Instantiate(missile, shootPosition[i].position, shootPosition[i].rotation);
		}


    }


}
