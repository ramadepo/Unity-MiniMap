using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapFollowMC : MonoBehaviour {

	public Transform Player;

	void LateUpdate(){	//second cam for minimap
		Vector3 newposition = Player.position;
		newposition.y = transform.position.y;	//freeze the height of cam
		transform.position = newposition;
	}
}
