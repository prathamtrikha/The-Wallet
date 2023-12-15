using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerInteraction : MonoBehaviour {

	//public GameObject intText;
	public bool interactable, toggle;
	public Animator drawerAnim;
	private float distance = 2f;
	public GameObject interactableText;

	public void CheckWeapons() {
		RaycastHit hitObject;
		if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hitObject, distance)) {
			if (hitObject.transform.gameObject.name == "drawerHandle") {
				interactableText.SetActive (true);
				if (Input.GetKeyDown (KeyCode.E)) {
					toggle = !toggle;
					if (toggle == true) {
						drawerAnim.SetTrigger ("drawer1Open");
					}
					if (toggle == false) {
						drawerAnim.SetTrigger ("drawer1Close");
					} 

				}
			} else {
				interactableText.SetActive (false);
			}

		} 


	}


	//Update Function
	void Update()
	{
		CheckWeapons ();
	}
}
