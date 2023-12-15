using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinScene : MonoBehaviour {

	public Text winText;

	public Button mainMenuButton;


	// Use this for initialization
	void Start () {
		StartCoroutine (WinTxtScene ());
	}

	//making a Coroutine Function
	IEnumerator WinTxtScene (){
		yield return new WaitForSeconds (0.7f);
		winText.gameObject.SetActive (true);

		yield return new WaitForSeconds (1.2f);
		mainMenuButton.gameObject.SetActive (true);
	}

	//Navigate Back to StartMenu
	public void GoToMainMenu(){
		SceneManager.LoadScene ("StartMenu");
	}
}
