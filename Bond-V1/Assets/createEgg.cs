using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createEgg : MonoBehaviour {
    public Transform dragon;
    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("touching" + other.name);

        if (other.name == "audio3")
        {

            Debug.Log("It's a hit");
            //// Instantiate the projectile at the position and rotation of this transform
            //Rigidbody clone;
            //clone = Instantiate(dragon, transform.position, transform.rotation);

            Instantiate(dragon, new Vector3(0, 2, 0), Quaternion.identity);

        }
    }


}
