using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eggTracker : MonoBehaviour {
	private Quaternion rotation = Quaternion.Euler(new Vector3(0, -90, 0)); 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.rotation = rotation; 
	}
}
