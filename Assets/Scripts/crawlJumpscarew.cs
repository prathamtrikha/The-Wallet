using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class crawlJumpscarew : MonoBehaviour {

	public GameObject bowlFire;
	public GameObject FirePS;
	public GameObject laughSoundHolder;

	public Animator crossAnim;
	public Animator zombieAnim;

	//making Corouting Function
	IEnumerator jumpscareSound(){
		yield return new WaitForSeconds (0.1f);
		FirePS.gameObject.SetActive (false);
	}

	// Update is called once per frame
	void Update () {
		//if candle is Active in scene start the Jumpscare
		if (bowlFire.activeInHierarchy == true) {
			//Call a Coroutine
			StartCoroutine (jumpscareSound ());

			//Trigger Jumpscare Animations
			crossAnim.SetTrigger ("invert");
			zombieAnim.SetTrigger ("crawl");
			laughSoundHolder.SetActive (false);

		}
	}
}
