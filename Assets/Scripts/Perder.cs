using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Perder : MonoBehaviour {

	public Transform spwn;
	public GameObject plyr;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


	void OnTriggerEnter(Collider collider){
		if (collider.gameObject.tag == "Player") {
			collider.transform.position = spwn.transform.position;
		}
	}

}
