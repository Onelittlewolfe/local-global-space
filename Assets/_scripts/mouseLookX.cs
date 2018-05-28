using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookX : MonoBehaviour {

	[SerializeField]
	private float _sensitivy = 2.5f;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float _mouseX = Input.GetAxis("Mouse X");
		
		Vector3 newRotation = transform.localEulerAngles;
		newRotation.y += _mouseX * _sensitivy;
		transform.localEulerAngles = newRotation;
	}
}
