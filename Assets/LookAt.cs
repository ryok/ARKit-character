using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	[SerializeField]
	[Tooltip("ターゲットとなるオブジェクト")]
	private Transform _target;

	private HeadLookController _headLookController;

	// Use this for initialization
	private void Start () {
		_headLookController = GetComponent<HeadLookController> ();
	}
	
	// Update is called once per frame
	private void LateUpdate () {
		_headLookController.target = _target.position;
	}
}
