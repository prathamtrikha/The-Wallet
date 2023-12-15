using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchInteraction : MonoBehaviour {

	//Switch on Wall Interaction Script
	public bool interactable, toggle;
	public Animator switchAnim;
	public GameObject interactableText;
	public GameObject roomLight;

	public AudioSource switchSound;

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
					switchAnim.SetTrigger ("open");
					roomLight.SetActive (true);
					switchSound.Play ();
				}
				if (toggle == false)
				{
					switchAnim.SetTrigger ("close");
					roomLight.SetActive (false);
					switchSound.Play ();
				}
				interactableText.SetActive(false);
				interactable = false;
			}
		}
	}
}
