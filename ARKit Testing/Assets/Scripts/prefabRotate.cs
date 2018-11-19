using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefabRotate : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = Vector3.zero;
	Vector3 spinAxis = new Vector3(0,1,0);
	

// Use this for initialization
	void Start () {
		
// Set argument of public function "setSize" as 2
		//setSize(2.0f);

// Defines random values of the "spinSpeed" vector
		spinSpeed = new Vector3(Random.value, Random.value, Random.value);

		spinAxis = Vector3.up;
// Define random value for x axis rotation
// Quick algorithm for setting random value bounds -1 to 1. Dampen by multiplying by .1
		spinAxis.x = (Random.value - Random.value) * .1f;
	}

// Function that sets the size of the cube as the "size" argument value.
	public void setSize(float size){
		
		this.transform.localScale = new Vector3(size,size,size);
	
	}
	
// Update is called once per frame
	void Update () {
		
// Sets rotational values based on variable "spinSpeed" 
		this.transform.Rotate(spinSpeed);
// Rotate around 0,0,0, with axis "spinAxis", speed 1.
		//this.transform.RotateAround(Vector3.zero, spinAxis, rotateSpeed);
	}
}
