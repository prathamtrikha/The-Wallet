using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class candleInteraction : MonoBehaviour {

	/*
		Script for CandleInteraction Event
	 */
	public bool interactable, toggle;
	
	public GameObject candleFlame;
	public GameObject candleLight;
	public Animator candleFlameAnim;

	//When Player enters CandleTrigger
	void OnTriggerStay(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//intText.SetActive(true);
			interactable = true;
		}
	}

	//When Player Leaves CandleTrigger
	void OnTriggerExit(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//intText.SetActive(false);
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
					candleFlame.SetActive (true);
					candleLight.SetActive (true);
				}
				if (toggle == false)
				{
					candleFlame.SetActive (false);
					candleLight.SetActive (false);
				}
				//intText.SetActive(false);
				interactable = false;
			}
		}
	}
}
