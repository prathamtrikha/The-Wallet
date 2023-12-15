using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySight : MonoBehaviour {

	public float maxSightDistance = 20f; // Maximum distance the enemy can see the player
	public AudioClip alertSound; // Sound clip to play when the enemy sees the player

	private AudioSource audioSource; // Reference to the AudioSource component
	private Transform playerTransform; // Reference to the player's transform

	private void Start()
	{
		// Get the AudioSource component attached to this GameObject
		audioSource = GetComponent<AudioSource>();
		// Find the player object by tag (you can also assign it directly in the inspector)
		playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
	}

	private void Update()
	{
		// Create a ray from the enemy towards the player
		Ray ray = new Ray(transform.position, playerTransform.position - transform.position);
		RaycastHit hit;

		// Check if the ray hits something
		if (Physics.Raycast(ray, out hit, maxSightDistance))
		{
			// Check if the ray hit the player
			if (hit.transform.CompareTag("Player"))
			{
				// Check if the sound is not already playing
				if (!audioSource.isPlaying)
				{
					// Play the alert sound
					audioSource.PlayOneShot(alertSound);
				}
			}
		}
	}
}
