using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlightPick : MonoBehaviour {
	//FlashLight Object kept on Table
	public GameObject tableFlashlight;
	public bool interactable;
	public GameObject intText;

	void OnTriggerStay(Collider other) {
		if(other.CompareTag("Player")) {
			interactable = true;
			intText.SetActive (true);
		}
	}

	void OnTriggerExit(Collider other) {
		if(other.CompareTag("Player")) {
			interactable = false;
			intText.SetActive (false);
		}
	}
		

	void Update() {
		if (interactable == true) {
			if (Input.GetKeyDown (KeyCode.E)) {
				//When Player picks Flashlight from Table
				//Deactivate Flashlight on Table
				tableFlashlight.SetActive (false);
				interactable = false;
				intText.SetActive (false);
			}
		}
	}

}
