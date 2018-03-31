using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class MCMove : MonoBehaviour {

	public Camera cam;
	public float step = 0.1f;
	public MouseLook mouseLook = new MouseLook();

	// Use this for initialization
	void Start () {
		mouseLook.Init (transform, cam.transform);
	}
	
	// Update is called once per frame
	void Update () {
		Move ();
		RotateView ();
	}

	private void Move(){	//control the player
		if (Input.GetKey(KeyCode.A)) {
			gameObject.transform.Translate (new Vector3 (-1*step, 0f, 0f));
		}
		if (Input.GetKey(KeyCode.D)) {
			gameObject.transform.Translate (new Vector3 (step, 0f, 0f));
		}
		if (Input.GetKey(KeyCode.W)) {
			gameObject.transform.Translate (new Vector3 (0f, 0f, step));
		}
		if (Input.GetKey(KeyCode.S)) {
			gameObject.transform.Translate (new Vector3 (0f, 0f, -1*step));
		}
	}

	private void RotateView(){	//mouse control look view
		mouseLook.LookRotation (transform, cam.transform);
	}
}
