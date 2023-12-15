using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextScene : MonoBehaviour {

	//Script for StoryMode Scene in the Game 

	public Text line1;
	public Text line2;
	public Text line3;

	public Text goodLuckText;

	public Button nextButton;

	// Use this for initialization
	void Start () {
		StartCoroutine (TxtScene());
	}

	IEnumerator TxtScene(){
		yield return new WaitForSeconds (0.7f);
		line1.gameObject.SetActive (true);

		yield return new WaitForSeconds (2f);
		line2.gameObject.SetActive (true);

		yield return new WaitForSeconds (2.5f);
		line3.gameObject.SetActive (true);

		yield return new WaitForSeconds (3.5f);
		goodLuckText.gameObject.SetActive (true);

		yield return new WaitForSeconds (5f);
		nextButton.gameObject.SetActive (true);

		yield return new WaitForSeconds (6f);
		Cursor.visible = true;


	}

	//Navigate to MainMenu Level of the Game
	public void StartGameScene(){
		SceneManager.LoadScene("Ground Level");
	}
}
