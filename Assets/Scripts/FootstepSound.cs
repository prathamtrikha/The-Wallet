using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSound : MonoBehaviour {

	public AudioSource footstepSound;
	
	// Update is called once per frame
	void Update () {
		//When Player presses movement Keys play FootSteps Sound
		if (Input.GetKey(KeyCode.W) || Input.GetKey (KeyCode.S) || Input.GetKey (KeyCode.A) || Input.GetKey(KeyCode.D)) {
			footstepSound.enabled = true;
		} else {
			footstepSound.enabled = false;
		}
	}
}
