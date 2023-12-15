using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpscareLevel2 : MonoBehaviour {

	//GameObject for ParticleSystem
	public GameObject PS;
	public GameObject PS1;

	//SoundFX for Jumpscare
	public AudioSource jumpscareSound;
	
	// Update is called once per frame
	void Update () {
		if (PS.activeInHierarchy == true && PS1.activeInHierarchy == true) {
			jumpscareSound.Play ();
		}
	}
}
