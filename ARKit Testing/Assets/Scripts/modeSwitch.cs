using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class modeSwitch : MonoBehaviour {

	public GameObject cubePlace;
	public GameObject sphereShoot;

	private int appMode = 1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void EnableSphereShoot(bool enable)
	{
		cubePlace.SetActive (enable);
		sphereShoot.SetActive (!enable);
		
	}

	void OnGUI()
	{
		string modeString = appMode == 0 ? "Shoot Spheres!" : "Place Cubes!";
		if (GUI.Button(new Rect(Screen.width -150.0f, 0.0f, 150.0f, 100.0f), modeString))
		{
			appMode = (appMode + 1) % 2;
			EnableSphereShoot (appMode == 0);

			Debug.Log("GUI.Button.name");
		}

	}

}
