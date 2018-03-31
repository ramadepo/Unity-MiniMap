using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public Camera cam;
	public ParticleSystem flash;
	public GameObject impactEffect;

	public float range = 100f;
	public float damage = 10f;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Shoot ();
	}

	private void Shoot(){
		if (Input.GetButtonDown("Fire1")) {
			flash.Play ();
			RaycastHit hit;
			if (Physics.Raycast(cam.transform.position,cam.transform.forward,out hit,range)) {	//shoot sense by raycast, there is information about object in (out)hit
				Debug.Log ("Hit the " + hit.transform.name);
				Target target = hit.transform.GetComponent<Target> ();	//if hit the something who can be shoot
				if (target != null) {
					target.TakeDamage (damage);
				}
				GameObject impactGO = Instantiate (impactEffect, hit.point, Quaternion.LookRotation (hit.normal));	//generate particle on hit place
				GameObject.Destroy (impactGO, 1f);
			}
		}
	}
}
