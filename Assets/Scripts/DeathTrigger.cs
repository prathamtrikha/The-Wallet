using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathTrigger : MonoBehaviour {
	/*
		Script for Enemy Attack
	 */

	public PlayerMovement playerMovementScript;

	public Animator EnemyAnim;

	public AudioSource impactSound;
	public AudioSource enemyAudioSource;

	//GameObject for BlackScreen
	public GameObject blackImage;

	//When Player enters Enemy's Trigger
	void OnTriggerEnter (Collider other) {
		if (other.CompareTag ("Player")) {
			//When EnemyKills Player PlayerMoveScript is disabled
			playerMovementScript.enabled = false;
			blackImage.SetActive (true);
			enemyAudioSource.enabled = false;
			impactSound.Play ();

			//Calling a Coroutine
			StartCoroutine (MyAttack ());
		}
	}

	//making a Coroutine Function
	private IEnumerator MyAttack(){
		yield return new WaitForSeconds(0.5f);
		SceneManager.LoadScene ("DeathScene");
	}
}
