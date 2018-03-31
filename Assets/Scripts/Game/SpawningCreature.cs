using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningCreature : MonoBehaviour {

	public GameObject TheSpawn;
	public Transform[] SpawnPoints;



	public void Spawn(){	//Spawn the gameobject in random place
		int SpawnPointNumber = Random.Range (0, SpawnPoints.Length);
		Instantiate (TheSpawn, SpawnPoints [SpawnPointNumber].position, SpawnPoints [SpawnPointNumber].rotation);
	}
}
