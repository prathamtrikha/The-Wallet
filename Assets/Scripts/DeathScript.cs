using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

	//EnemyAnimation Attack 
	public Animator EnemyAnim;

	//Player DeathCam Animation
	public Animator DeathCamAnim;

	// Use this for initialization
	void Start () {
		//Call A Coroutine
		StartCoroutine (MyAttack ());
	}

	//making Coroutine Function
	IEnumerator MyAttack(){
		yield return new WaitForSeconds (1f);
		DeathCamAnim.SetTrigger ("zoom");
		yield return new WaitForSeconds (2f);
		DeathCamAnim.SetTrigger ("die");
		EnemyAnim.enabled = true;
		yield return new WaitForSeconds (0.8f);
		EnemyAnim.SetTrigger("dance");

		//after DeathAnimation SwitchScene to GameOver Scene
		yield return new WaitForSeconds (30f);
		SceneManager.LoadScene("GameOver");
	
	}
}
