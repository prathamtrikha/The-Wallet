using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DollChamber : MonoBehaviour {

	/*
		DollChamber Opening Quest
	 */


	//first BookObject
	public GameObject firstCursedBook;
	//second BookObject
	public GameObject secondCursedBook;

	//left and right DoorANimators
	public Animator leftDoorAnim;
	public Animator rightDoorAnim;
	
	// Update is called once per frame
	void Update () {
		//Both First and Second Active in Scene and Open DollChamber
		if (firstCursedBook.activeInHierarchy == true && secondCursedBook.activeInHierarchy == true) {
			leftDoorAnim.SetTrigger ("first");
			rightDoorAnim.SetTrigger ("second");
		}
	}
}
