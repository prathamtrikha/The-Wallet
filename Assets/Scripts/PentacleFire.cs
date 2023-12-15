using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PentacleFire : MonoBehaviour {

	public GameObject MatchBoxInHand;
	public GameObject intText;
	public GameObject fireParticleSystem1;
	public GameObject fireParticleSystem2;

	public Transform equipPos;
	public Text myText;


	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive(true);
			if (Input.GetKeyDown (KeyCode.E)) {
				if (fireParticleSystem1.activeInHierarchy == true) {
					myText.text = "";
				}
				if (equipPos.Find ("MatchBox")) {
					fireParticleSystem1.SetActive (true);
					fireParticleSystem2.SetActive (true);

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
}
