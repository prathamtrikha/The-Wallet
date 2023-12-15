using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SettingScene : MonoBehaviour {

	//When BackButton is clicked in Setting Menu
	public void goToMainMenu(){
		SceneManager.LoadScene ("StartMenu");
	}
}
