using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOverText : MonoBehaviour {

	public Text gameOverText;
	public Text betterLuckText;

	public GameObject mainMenuButton;

	// Use this for initialization
	void Start () {
		StartCoroutine (GOText ());
	}

	IEnumerator GOText(){
		yield return new WaitForSeconds (0.7f);
		gameOverText.gameObject.SetActive (true);

		yield return new WaitForSeconds (2f);
		betterLuckText.gameObject.SetActive (true);

		yield return new WaitForSeconds (5f);
		mainMenuButton.SetActive (true);

		yield return new WaitForSeconds (6f);
		Cursor.visible = true;


	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
