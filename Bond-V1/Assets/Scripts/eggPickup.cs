﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggPickup : MonoBehaviour {
	public GameObject ObjectTracker;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerExit(Collider other) {
		Debug.Log ("Egg Picked Up!");
		ObjectTracker.GetComponent<Animation>().CrossFade("eggShake");
	}
}
