using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour {

	public Transform spawnObject;

	public Transform[] spawnPoints;

	// Use this for initialization
	void Start () {
		//randomly Spawn the Object at any Location from Transform Array
		int indexNumber = Random.Range (0, spawnPoints.Length);
		spawnObject.position = spawnPoints [indexNumber].position;
	}

}
