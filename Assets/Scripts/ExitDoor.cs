using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ExitDoor : MonoBehaviour {

	public GameObject intText;
	public Text textNeed;
	public GameObject equipPos;

	// When Player enters or Stay ExitDoor Trigger
	void OnTriggerStay (Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				//Checking if player has WalletObject 
				if (equipPos.transform.Find ("Wallet")) {
					//if wallet is present in PlayerTransform Change Scene 
					SceneManager.LoadScene ("WinScene");
				} else {
					//else ask Player to find the Wallet
					textNeed.gameObject.SetActive (true);
					textNeed.text = "Find your Wallet first.";
				}
			}
		}
	}
	
	// WHen Player exits ExitDoor Trigger
	void OnTriggerExit (Collider other) {
		if (other.CompareTag ("Player")) {
			intText.SetActive (false);
			textNeed.text = " ";
			textNeed.gameObject.SetActive (false);
		}
	}
}
