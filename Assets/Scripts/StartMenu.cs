using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	//Navigate to StoryScene
	public void goToPlay(){
		SceneManager.LoadScene ("TextScene");
	}
	//Navigate to StartMenu Scene
	public void goToMainMenu(){
		SceneManager.LoadScene ("StartMenu");
	}
	//Navigate to SettingMenu Scene
	public void goToSettings(){
		SceneManager.LoadScene ("SettingScene");
	}
	//Quit the Game
	public void goToExit(){
		Application.Quit();
	}
}
