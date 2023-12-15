using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destinationPoints : MonoBehaviour {
	public Collider collision;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("monster"))
		{
			//Call a Coroutine Function
			StartCoroutine(reEnable());
			collision.enabled = false;
		}
	}

	//making a Coroutine FUnction
	IEnumerator reEnable()
	{
		yield return new WaitForSeconds(6.0f);
		collision.enabled = true;
	}
}
