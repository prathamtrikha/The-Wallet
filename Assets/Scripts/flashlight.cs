using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flashlight : MonoBehaviour {

	public GameObject handFlashlight, tableFlashlight;
	public bool toggle;
	public AudioSource flashlightSound;

	//CHecking for Flashlight 
	void Update() {
		if (Input.GetKeyDown (KeyCode.F) && tableFlashlight.activeInHierarchy == false) {
			toggle = !toggle;
			if (toggle == true) {
				handFlashlight.SetActive (true);
			}
			if (toggle == false) {
				handFlashlight.SetActive (false);
			}
			flashlightSound.Play ();
		}
	}
}
