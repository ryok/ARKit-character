using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	private Transform target;
	private HeadLookController controller;

	// Use this for initialization
	private void Start () {
		controller = GetComponent<HeadLookController> ();
	}

	void OnTriggerEnter(Collider other){
		if (target != null) {
			return;
		}

		if (other.CompareTag("Player")){
			Debug.Log ("hit!");
			target = other.transform;
		}
	}
	
	// Update is called once per frame
	private void LateUpdate () {
		if (target != null) {
			controller.target = target.position;
		}
	}
}
