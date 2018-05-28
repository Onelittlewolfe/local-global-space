using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouseLookY : MonoBehaviour {

	// Use this for initialization
	[SerializeField]
	private float _sensitivy = 2.5f;
	
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		float _mouseY = Input.GetAxis("Mouse Y");
		Debug.Log("MouseY " + _mouseY);
		
		Vector3 newRotation = transform.localEulerAngles;
		newRotation.x += _mouseY * _sensitivy;
		newRotation.x = Mathf.Clamp(newRotation.x , 0f , 27f);
		transform.localEulerAngles = newRotation;
		
	}
}
