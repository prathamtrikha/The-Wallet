using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour {

	//for Pausing the Game
	public GameObject pauseMenuObject;

	public bool toggle;

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) {
			toggle = !toggle;
			if (toggle == true) {
				pauseMenuObject.SetActive (true);
				Time.timeScale = 0f;
				Cursor.visible = true;
				Cursor.lockState = CursorLockMode.None;
			}
			if (toggle == false) {
				Resume ();
			}
		}
	}

	void Resume(){
		pauseMenuObject.SetActive (false);
		Time.timeScale = 1f;
		Cursor.visible = false;	
	}

	public void ResumeGame(){
		Resume ();
	}

	public void ReturnMainMenu(){
		SceneManager.LoadScene ("StartMenu");
	}


}
