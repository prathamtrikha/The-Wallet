using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorInteraction : MonoBehaviour {

	//public GameObject intText;
	public bool interactable, toggle;
	public Animator doorAnim;
	public AudioSource doorOpen;
	public AudioSource doorClose;
	public GameObject interactableText;

	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			interactableText.SetActive(true);
			interactable = true;
		}
	}
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
					doorAnim.SetTrigger("open");
					doorOpen.Play ();
				}
				if (toggle == false)
				{
					doorAnim.SetTrigger("close");
					doorClose.Play ();
				}
				interactableText.SetActive(false);
				interactable = false;
			}
		}
	}
}
