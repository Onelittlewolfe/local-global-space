using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class player : MonoBehaviour {

	private CharacterController _char;
	[SerializeField]
	private float _speed = 3.5f;
	private float _gravity = 9.81f;
	private GameObject _UI;

	[SerializeField]
	private Text[] _uiText;

	private float _distanceTravelled;
	
	void Start () {
		_char = gameObject.GetComponent<CharacterController>();
		_UI = GameObject.Find("UI");

		_uiText = _UI.GetComponentsInChildren<Text>();

		Debug.Log(_uiText.Length);
		
	}
	

	void Update () {
		movePlayer();
	}

	void movePlayer() {
		float movHor = Input.GetAxis("Horizontal");
		float movVert = Input.GetAxis("Vertical");

		if ( (movHor != 0) || (movVert != 0)  )
		{
			_uiText[0].text = " movHor is " + movHor;
			_uiText[1].text = " movVert is " + movVert;

			Vector3 movement = new Vector3(movHor , 0, movVert);

			Debug.Log("movement is " + movement);

			movement = Camera.main.transform.TransformDirection(new Vector3(movement.x, movement.y, movement.z));

			movement.y -= _gravity;

			Debug.Log("movement is now " + movement);

			_char.Move(movement * _speed * Time.deltaTime);
			getDistanceTravelled();
		}
		
	}

	void getDistanceTravelled()
	{
		Debug.Log("getDistanceTravelled");
		//get speed and time travelled
		//need to get current time and last time moved
		//add new time moved and times by speed
		//add to distance travelled total
	}
}
