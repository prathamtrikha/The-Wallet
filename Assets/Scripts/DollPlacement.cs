using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DollPlacement : MonoBehaviour {

	public GameObject dollInHand;
	public GameObject dollOnGround;
	public GameObject intText;

	public Transform equipPos;

	public Text myText;

	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive(true);
			if (Input.GetKeyDown (KeyCode.E)) {
				if (equipPos.Find ("Voodoo Doll")) {
					dollOnGround.SetActive (true);
					dollInHand.SetActive (false);
				} else {
					myText.gameObject.SetActive(true);
					myText.text = "Need Voodoo Doll";
				}	
			}
		}
	}


	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive (false);
			myText.gameObject.SetActive (false);
		}
	}


}
