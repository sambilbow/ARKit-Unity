using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onTriggerEnter : MonoBehaviour {

	void OnTriggerEnter (Collider collidedGameObject){

		if(collidedGameObject.gameObject.tag == "boundaryCube")
		{
			Debug.Log("Boundary Collision Detected");
			Object.Destroy(gameObject);	
		}

	}
}
