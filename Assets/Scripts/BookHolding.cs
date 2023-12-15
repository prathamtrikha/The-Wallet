using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BookHolding : MonoBehaviour {

	public GameObject bookInHand;
	public GameObject bookOnTable;
	public GameObject intText;
	public GameObject wp;

	public Transform equipPos;
	public Text myText;


	void OnTriggerStay(Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive(true);
			if (Input.GetKeyDown (KeyCode.E)) {
				if (equipPos.Find ("Cursed Book")) {
					bookOnTable.SetActive (true);
					Destroy (wp);
					bookInHand.SetActive (false);
				} else {
					myText.gameObject.SetActive(true);
					myText.text = "Need Cursed Book";
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
