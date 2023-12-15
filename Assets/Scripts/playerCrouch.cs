using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerCrouch : MonoBehaviour {

	// Use this for initialization
	public CharacterController playerHeight;
	public float standingHeight, crouchHeight;
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.C)) {
			//reduce Player Height for Crouching
			playerHeight.height = crouchHeight;
		} 
		//When Key [C] is released back to NormalHeight
		if (Input.GetKeyUp (KeyCode.C)) {
			playerHeight.height = standingHeight;
		}
	}
}
	