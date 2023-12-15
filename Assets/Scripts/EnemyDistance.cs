using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDistance : MonoBehaviour {

	/*
		Activate JumpscareSound  when player is Near to Enemy
	 */

	//Audio Component for JumpscareSound
	public AudioSource audioSource;
	public AudioClip detectionSound;
	public Transform player;

	public float detectionDistance;
	public float distanceToPlayer;

	private bool playerDetected = false;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void Update()
	{	
		//Calculate Distance between Player and Enemy
		distanceToPlayer = Vector3.Distance(transform.position, player.position);

		if (distanceToPlayer <= detectionDistance && !playerDetected)
		{
			playerDetected = true;
			audioSource.PlayOneShot(detectionSound);
		}
		else if (distanceToPlayer > detectionDistance && playerDetected)
		{
			playerDetected = false;
		}
	}
}
