using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour {
	//Script for Player Picking and Dropping Object in

	//Transform for Equiping Player Weapons
	public Transform equipPosition;
	public Transform objectPosition;
	private float distance = 4f;
	private GameObject currentWeapon;
	private GameObject wp;
	public GameObject planchettePS;
	public GameObject intText;

	[Tooltip("Particle System Main")]
	public GameObject fireParticleSystem;
	public GameObject smokeParticleSystem;


	[Tooltip("Particle System1")]
	public GameObject fireParticleSystem1;
	public GameObject smokeParticleSystem1;

	[Tooltip("Particle System2")]
	public GameObject fireParticleSystem2;
	public GameObject smokeParticleSystem2;

	[Tooltip("Particle System3")]
	public GameObject fireParticleSystem3;
	public GameObject smokeParticleSystem3;

	[Tooltip("Particle System4")]
	public GameObject fireParticleSystem4;
	public GameObject smokeParticleSystem4;

	[Tooltip("Particle System5")]
	public GameObject fireParticleSystem5;
	public GameObject smokeParticleSystem5;


	public GameObject voodooDollInHand;
	public GameObject voodooDollOnGround;

	public GameObject keypadOb;

	public Text myText;
	public Text itemNeedText;

	public bool canGrab;
	public bool allActivated;

	public bool firstPS;
	public bool secondPS;
	public bool thirdPS;
	public bool fourthPS;
	public bool fifthPS;
	public bool dollEnabled;
	public bool toggle;

	public GameObject mainCamera;
	public GameObject ouijaCamera;

	public Animator drawerAnim;



	void CheckWeapons() {
		RaycastHit hitObject;

		if (Physics.Raycast (Camera.main.transform.position, Camera.main.transform.forward, out hitObject, distance)) {
			if (hitObject.transform.tag == "pick") {
				myText.gameObject.SetActive(true);
				myText.text = hitObject.transform.gameObject.name;
				canGrab = true;
				wp = hitObject.transform.gameObject;
			} 
			if (hitObject.transform.tag == "interact") {
				myText.gameObject.SetActive (true);
				myText.text = hitObject.transform.gameObject.name;


				//KeyPad activate
				if (hitObject.transform.gameObject.name == "keypad") {
					intText.SetActive (true);
					if (Input.GetKeyDown (KeyCode.E)) {
						keypadOb.SetActive (true);
					}
				} else {
					intText.SetActive (false);
				}


				//OuijaCircle activate
				if (hitObject.transform.gameObject.name == "DollInteraction") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("Voodoo Doll")) {
							voodooDollInHand.SetActive (false);
							Destroy (voodooDollInHand);
							currentWeapon = null;
							voodooDollOnGround.SetActive (true);
							dollEnabled = true;

						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need Voodoo Doll";
						}
						if (voodooDollOnGround.activeInHierarchy == true && voodooDollInHand.activeInHierarchy == false) {
							itemNeedText.text = "";
						}
					}
				}


				//RoomScary firebowl activate
				if (hitObject.transform.gameObject.name == "FireBowl") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem.SetActive (true);
							smokeParticleSystem.SetActive (true);
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem1.activeInHierarchy == true && smokeParticleSystem1.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}


				//fireBowl activate
				if (hitObject.transform.gameObject.name == "FireBowl 1") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem1.SetActive (true);
							smokeParticleSystem1.SetActive (true);
							secondPS = true;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem1.activeInHierarchy == true && smokeParticleSystem1.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}


				//fireBowl activate
				if (hitObject.transform.gameObject.name == "FireBowl 2") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem2.SetActive (true);
							smokeParticleSystem2.SetActive (true);
							thirdPS = true;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem2.activeInHierarchy == true && smokeParticleSystem2.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}


				//fireBowl activate
				if (hitObject.transform.gameObject.name == "FireBowl 3") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem3.SetActive (true);
							smokeParticleSystem3.SetActive (true);
							fourthPS = true;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem3.activeInHierarchy == true && smokeParticleSystem3.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}



				//fireBowl activate
				if (hitObject.transform.gameObject.name == "FireBowl 4") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem4.SetActive (true);
							smokeParticleSystem4.SetActive (true);
							fifthPS = true;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem4.activeInHierarchy == true && smokeParticleSystem4.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}


				//fireBowl activate
				if (hitObject.transform.gameObject.name == "FireBowl 5") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("MatchBox")) {
							fireParticleSystem5.SetActive (true);
							smokeParticleSystem5.SetActive (true);
							firstPS = true;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need MatchBox";
						}
						if (fireParticleSystem5.activeInHierarchy == true && smokeParticleSystem5.activeInHierarchy == true) {
							itemNeedText.text = "";
						}
					}
				}


				//activate CabinetDrawer
				if (hitObject.transform.gameObject.name == "Drawer") {
					myText.text = "";
					if (Input.GetKeyDown (KeyCode.E)) {
						toggle = !toggle;
						if (toggle == true) {
							drawerAnim.SetTrigger ("open");
						}
						if (toggle == false) {
							drawerAnim.SetTrigger ("close");
						}
					}
				}

				if (hitObject.transform.gameObject.name == "Drawer1") {
					myText.text = "";
					if (Input.GetKeyDown (KeyCode.E)) {
						toggle = !toggle;
						if (toggle == true) {
							drawerAnim.SetTrigger ("open2");
						}
						if (toggle == false) {
							drawerAnim.SetTrigger ("close2");
						}
					}
				}


				//woodenPlanks removing
				if (hitObject.transform.gameObject.name == "Wooden Plank") {
					if (Input.GetKeyDown (KeyCode.E)) {
						if (equipPosition.Find ("Crowbar")) {
							hitObject.transform.gameObject.GetComponent<Rigidbody> ().isKinematic = false;
						} else {
							itemNeedText.gameObject.SetActive (true);
							itemNeedText.text = "Need Crowbar";
						}

					}
				}


			} 
		}
		else {
			canGrab = false;
			myText.text = "";
			itemNeedText.text = "";
			itemNeedText.gameObject.SetActive (false);
		}

		//check Planchette PS
		if(firstPS == true && secondPS == true && thirdPS == true && fourthPS == true && fifthPS == true && dollEnabled == true){
			planchettePS.SetActive (true);
		}

	}


	void ItemPick() {
		currentWeapon = wp;

		if (currentWeapon.gameObject.name == "Basement Key") {
			objectPosition.Find ("Basement Key").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "Wallet") {
			objectPosition.Find ("Wallet").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "MatchBox") {
			objectPosition.Find ("MatchBox").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "Mystery Key") {
			objectPosition.Find ("Mystery Key").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "Cursed Book") {
			objectPosition.Find ("Cursed Book").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "Voodoo Doll") {
			objectPosition.Find ("Voodoo Doll").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "ouijaCircle") {
			objectPosition.Find ("ouijaCircle").gameObject.SetActive (true);
		}
		if (currentWeapon.gameObject.name == "Crowbar") {
			objectPosition.Find ("Crowbar").gameObject.SetActive (true);
		}
		currentWeapon.transform.position = equipPosition.position;
		currentWeapon.transform.parent = equipPosition;
		currentWeapon.SetActive (false);
		currentWeapon.GetComponent<Rigidbody>().isKinematic = true;

	}

	void ItemDrop() {
		if (currentWeapon.gameObject.name == "Basement Key") {
			objectPosition.Find ("Basement Key").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "Wallet") {
			objectPosition.Find ("Wallet").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "Mystery Key") {
			objectPosition.Find ("Mystery Key").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "MatchBox") {
			objectPosition.Find ("MatchBox").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "Cursed Book") {
			objectPosition.Find ("Cursed Book").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "Voodoo Doll") {
			objectPosition.Find ("Voodoo Doll").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "ouijaCircle") {
			objectPosition.Find ("ouijaCircle").gameObject.SetActive (false);
		}
		if (currentWeapon.gameObject.name == "Crowbar") {
			objectPosition.Find ("Crowbar").gameObject.SetActive (false);
		}
		currentWeapon.SetActive (true);
		currentWeapon.transform.parent = null;
		currentWeapon.GetComponent<Rigidbody>().isKinematic = false;
		currentWeapon = null;


	}





	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		CheckWeapons ();

		if (canGrab) {
			if (Input.GetKeyDown (KeyCode.E)) {
				if (currentWeapon != null) {
					ItemDrop ();
				}
				ItemPick ();
			}
		}
		if (currentWeapon != null) {
			if (Input.GetKeyDown (KeyCode.Q)) {
				ItemDrop ();
			}
		}



	}



		
}
