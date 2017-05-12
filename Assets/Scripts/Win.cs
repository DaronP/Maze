using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win : MonoBehaviour {


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider col){

		if (col.gameObject.tag == "Player") {
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			Screen.lockCursor = false;
			
			Application.LoadLevel(1);


		}

	}
}
