using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MirrorBroken : MonoBehaviour {

	//MirrorBreaking Jumpscare Script
	public Material brokenMirror;
	public GameObject mirrorObject;
	Renderer rend;
	public AudioSource brokeSound;
	public GameObject triggerObject;


	//When Player enters the Trigger
	void OnTriggerEnter () {
		//get the Renderer Component for Mirror
		rend = mirrorObject.gameObject.GetComponent<Renderer> ();
		//Change Mirror Texture to BrokenMirrorTexture
		rend.sharedMaterial = brokenMirror;
		//Make Mirror Fall to Ground from Wall 
		mirrorObject.GetComponent<Rigidbody> ().isKinematic = false;
		brokeSound.Play ();
	}

	//Destroy the TriggerObject once Triggered
	void OnTriggerExit() {
		Destroy (triggerObject); 
	}
}
