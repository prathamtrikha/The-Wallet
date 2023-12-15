using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ouijaInteraction : MonoBehaviour {

	public Transform equipPos;

	public GameObject playerCam;
	public GameObject ouijaCam;
	public GameObject tableOuijaCircle;
	public GameObject intText;
	public GameObject intStart;
	public GameObject intExit;

	public Text myText;

	public Animator ouijaCircleAnim;

	void OnTriggerStay(Collider other){
		if (other.CompareTag ("Player")) {
			intText.SetActive (true);
			if (Input.GetKeyDown (KeyCode.E)) {
				if (equipPos.Find ("ouijaCircle")) {
					ouijaCam.SetActive (true);
				} else {
					myText.text = "Need Ouija Circle";
				}
			}
			if (Input.GetKeyDown (KeyCode.T)) {
				if (equipPos.Find ("ouijaCircle")) {
					ouijaCam.SetActive (false);
				}
			}
		}	
	}


	void OnTriggerExit(Collider other){
		if (other.CompareTag ("Player")) {
			intText.SetActive (false);
			ouijaCam.SetActive (false);
			playerCam.SetActive (true);
			intStart.SetActive (false);
			intExit.SetActive (false);
		}
	}


	// Use this for initialization
	void Start () {
		intStart.SetActive (false);
		intExit.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (ouijaCam.activeInHierarchy == true) {
			tableOuijaCircle.SetActive (true);
			intText.SetActive (false);
			intStart.SetActive (true);
			intExit.SetActive (true);
			if (Input.GetKeyDown (KeyCode.O)) {
				ouijaCircleAnim.SetTrigger ("start");
			}
		} else {
			tableOuijaCircle.SetActive (false);
		}
	}
}
