using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorKnock : MonoBehaviour {

	/*
		Script for KnockJumpScare on Door 
	 */

	//AudioSource for KNockSOund
	public AudioSource knockSound;

	//When Player Enters in JumpscareTrigger
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			//Play JumpscareSound and Destroy Trigger
			knockSound.Play();
			Destroy(this);
		}
	}
}
