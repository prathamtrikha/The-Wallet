using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour {

	public Transform equipPos;

	void OnTriggerEnter(Collider other){
		if (other.CompareTag ("Player")) {
			if (Input.GetKeyDown (KeyCode.T)) {
				if (equipPos.Find ("Wallet")) {
					SceneManager.LoadScene ("WinScene");
				}
			}
		}
	}
}
