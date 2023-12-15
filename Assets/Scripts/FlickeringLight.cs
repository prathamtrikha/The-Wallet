using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlickeringLight : MonoBehaviour {

	public Light lightSource;

	public float MaxTime;
	public float MinTime;
	public float Timer;

	public AudioSource lightFlickerSound;

	// Use this for initialization
	void Start () {
		Timer = Random.Range (MinTime, MaxTime);
	}
	
	// Update is called once per frame
	void Update () {
		flickerLight ();
	}

	void flickerLight() {
		if (Timer > 0) {
			Timer -= Time.deltaTime; 
		}
		if (Timer <= 0) {
			lightSource.enabled = !lightSource.enabled;
			Timer = Random.Range (MinTime, MaxTime);
			lightFlickerSound.Play ();

		}

	}

}
