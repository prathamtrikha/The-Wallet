using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bathroomInteraction : MonoBehaviour {
	/*
	Script for normal DoorInteraction
	 */

	public bool interactable, toggle;
	public Animator doorAnim;
	public AudioSource doorOpen;
	public AudioSource doorClose;
	public GameObject interactableText;

	//When Player enters or Stays DoorTrigger
	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			interactableText.SetActive(true);
			interactable = true;
		}
	}

	//When Player exits the DoorTrigger
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			interactableText.SetActive(false);
			interactable = false;
		}
	}


	void Update()
	{
		if(interactable == true)
		{
			if (Input.GetKeyDown(KeyCode.E))
			{
				toggle = !toggle;
				if(toggle == true)
				{
					doorAnim.SetTrigger("bathroomOpen");
					doorOpen.Play ();
				}
				if (toggle == false)
				{
					doorAnim.SetTrigger("bathroomClose");
					doorClose.Play ();
				}
				interactableText.SetActive(false);
				interactable = false;
			}
		}
	}
}
