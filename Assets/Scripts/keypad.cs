using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class keypad : MonoBehaviour {
	/*
		Script for KeyPad Quest
	 */
	public GameObject player;
	public GameObject keypadObject;
	public GameObject intText;
	public Text myText;

	public GameObject animateOB;
	public Animator ANI;


	public Text textOB;

	//correct for opening the Box
	public string answer = "2597";

	public AudioSource button;
	public AudioSource correct;
	public AudioSource wrong;

	public bool animate;

	public void Number(int number)
	{	
		//Converting Text to String
		textOB.text += number.ToString();
		button.Play();
	}

	public void Execute()
	{	
		//if input is correct, play sound and Display Text RIGHT
		if (textOB.text == answer)
		{
			correct.Play();
			textOB.text = "Right";

		}
		//If input is not correct, Play WrongInputEnter SOund and Display Text WRONG
		else
		{
			wrong.Play();
			textOB.text = "Wrong";
		}


	}

	public void Clear()
	{
		{
			textOB.text = "";
			button.Play();
		}
	}

	public void Exit()
	{
		keypadObject.SetActive(false);

		player.GetComponent<PlayerMove>().enabled = true;
	}

	public void Update()
	{
		if (textOB.text == "Right")
		{
			ANI.SetTrigger ("open");
		}
		//When KeyPad UI is ON
		if (keypadObject.activeInHierarchy) {
			player.GetComponent<PlayerMove> ().enabled = false;
			Cursor.visible = true;
			Cursor.lockState = CursorLockMode.None;
			intText.SetActive(false);
			myText.gameObject.SetActive(false);
		}
		//When KeyPad UI is OFF
		if (keypadObject.activeInHierarchy == false){
			player.GetComponent<PlayerMove> ().enabled = true;
			Cursor.visible = false;
		}

	}
}
