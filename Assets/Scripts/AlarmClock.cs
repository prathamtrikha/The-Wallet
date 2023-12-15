using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlarmClock : MonoBehaviour {

	public AudioSource alarmSound;
	//public GameObject alarmTrigger;

	//player walks on trigger AlarmJumpscare Trigger
	void OnTriggerEnter(Collider other) {
		if (other.CompareTag("Player")) {
			//play AlarmSOundFX
			alarmSound.Play();
		}
			//Destroy when jumpscare is completed
			Destroy(this);
	}


}
