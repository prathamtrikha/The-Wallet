using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MysteryDoor : MonoBehaviour {


	public float distance = 3f;

	public bool toggle;

	public Animator doorAnim;

	public GameObject intText;

	public AudioSource lockSound;

	public Transform equipPos;

	public Text myText;

	void CheckDoor(){
		RaycastHit hitObject;
		if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hitObject, distance)) {
			if (hitObject.transform.gameObject.tag == "mysteryDoor") {
				intText.SetActive (true);
				if (hitObject.transform.gameObject.name == "Mystery Door") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPos.transform.Find ("Mystery Key")) {
							toggle = !toggle;
							if (toggle == true) {
								doorAnim.SetTrigger ("open");
							}
							if (toggle == false) {
								doorAnim.SetTrigger ("close");
							}
						} else {
							lockSound.Play ();
							myText.gameObject.SetActive (true);
							myText.text = "Need Mystery Key";
						}
					}
				}
			} 
		}else {
			intText.SetActive (false);
			myText.gameObject.SetActive (false);
		}
	}
	
	// Update is called once per frame
	void Update () {
		CheckDoor ();
	}
}
