using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fireParticle : MonoBehaviour {

	public GameObject MatchBoxInHand;
	public GameObject intText;
	public GameObject fireParticleSystem;

	//Transform in PlayerObject for holding MatchBox
	public Transform equipPos;
	public Text myText;


	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive(true);
			if (Input.GetKeyDown (KeyCode.E)) {
				if (fireParticleSystem.activeInHierarchy == true) {
			myText.text = "";
					}
				if (equipPos.Find ("MatchBox")) {
					MatchBoxInHand.SetActive (false);
					fireParticleSystem.SetActive (true);

				} else {
					myText.gameObject.SetActive(true);
					myText.text = "Need MatchBox";
				}	
			}
		}
	}


	void OnTriggerExit(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive(false);
			myText.gameObject.SetActive(false);
		}
	}

	void Update() {
	}
}
