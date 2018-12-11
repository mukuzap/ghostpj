using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayersc : MonoBehaviour{
    AudioSource audioData;

    public void PlaySound() {
        GetComponent<AudioSource>().Play(0);
        Debug.Log("Audio play");
    }

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
