using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class basementDoor : MonoBehaviour {

/*
	Script for opening BasementDoor with BasementKey
 */

	//public GameObject intText;
	public bool interactable, toggle;
	public Animator doorAnim;

	public AudioSource doorOpen;
	public AudioSource doorClose;
	public AudioSource lockedSound;

	public GameObject equipPos;
	private GameObject childPos;
	public GameObject interactableText;
	public GameObject DoorLockText;

	public Text needText;

	//When Player enters DoorTrigger 
	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			interactableText.SetActive(true);
			interactable = true;
		}
	}

	//When Player exits DoorTrigger
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			interactableText.SetActive(false);
			interactable = false;
			DoorLockText.SetActive (false);
		}
	}


	void Update()
	{
		//check wehther we can interact with the Door
		if(interactable == true)
		{
			if (Input.GetKeyDown (KeyCode.E)) {
				//Check at PlayerTransform whether BasementKey is present or not
				//if present Open BasementDoor and Play DoorSFX
				if (equipPos.transform.Find ("Basement Key")) {
					toggle = !toggle;
					if (toggle == true) {
						doorAnim.SetTrigger ("open");
						doorOpen.Play ();
					}
					if (toggle == false) {
						doorAnim.SetTrigger ("close");
						doorClose.Play ();
					}
					interactableText.SetActive (false);
					interactable = false;
				} else {
					lockedSound.Play();
					//if DoorKey not present Tell Player "Needed a key" 
					needText.text = "Need Basement Key";
				}

			} else {
				DoorLockText.SetActive (true);
			}
		}
	}
}
