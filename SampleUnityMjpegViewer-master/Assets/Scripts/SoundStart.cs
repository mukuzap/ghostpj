using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundStart : MonoBehaviour {

    public new GameObject gameObject;

    // sound start
    public void OnClick() {
        Debug.Log("onClick");
        gameObject.GetComponent<SoundPlayersc>().PlaySound();
    }
}