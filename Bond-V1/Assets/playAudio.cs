using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playAudio : MonoBehaviour {

    public AudioClip egg2;

	// Use this for initialization
	void Start () {
        GetComponent<AudioSource>().playOnAwake = false;
        GetComponent<AudioSource>().clip = egg2;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("detected");
        GetComponent<AudioSource>().Play();
    }
}
