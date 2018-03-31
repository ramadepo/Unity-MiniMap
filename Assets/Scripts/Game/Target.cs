using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

	public float health = 30f;

	private Renderer rend;
	public Material change1;
	public Material change2;

	private void Start(){
		rend = GetComponent<Renderer> ();
	}

	public void TakeDamage(float amount){	//be attacked and change the color or die
		health -= amount;
		if (health <= 20 && health > 10) {
			rend.sharedMaterial = change1;
		}
		else if (health <= 10 && health > 0) {
			rend.sharedMaterial = change2;
		}
		else if (health <= 0f) {
			Die ();
		}
	}

	private void Die(){
		Destroy (gameObject);
	}
}
