// This code was adapted from Adam B's solution on this thread : https://stackoverflow.com/questions/47375296/move-object-along-raycast

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour {

	Rigidbody rb;
	public float cubeForce;
	bool firstTime = false;
	Vector3 direction;

	// Use this for initialization
	void Start () {
	
		rb = GetComponent<Rigidbody> ();
	
	}
	
	public void SetDirection (Vector3 dir) {
        direction = dir;
        firstTime = true;
    }

    void OnCollisionEnter (Collision col) {
    		Debug.Log("Collision Detected");


	if(col.gameObject.name == "sphere") {

		Debug.Log("Collision Detected");

		//AUDIO
        AudioSource audioSource = GetComponent<AudioSource>();
        audioSource.pitch = 1;
		audioSource.Play();

	}
    }

    void FixedUpdate () {
        if (firstTime) {
            rb.AddForce (direction * cubeForce);
            firstTime = false;
        }
    } 
}
