using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	//Turnin on/off Roof Light
	public GameObject roofLight;

	//Enters in Trigger Lights On
	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Light")) {
			roofLight.SetActive (true);

		}
	}
}