using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class cubePlacement : MonoBehaviour {

	// Variables
	public cubeController cubePrefab;
	public GameObject mainCamera;
	
	Renderer rend;		

	
	
	// Use this for initialization
	void Start () {
	
	}
	
	
	
	// Update is called once per frame
	void Update () {

		if (Input.GetMouseButtonDown(0))	
		{
			if (!EventSystem.current.IsPointerOverGameObject() ){

			cubeMethod();
	

			}
		}
	}
	
	
	// Method to create cubePrefab in scene
	void cubeMethod(){

		//INSTANTIATION
        var cubePlacementPosition = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0.5f);
        transform.position = Camera.main.ScreenToWorldPoint(cubePlacementPosition);
        cubeController instantiatedCube = Instantiate(cubePrefab.gameObject).GetComponent<cubeController>();
        instantiatedCube.transform.position = transform.position;
		instantiatedCube.name = "CUBE!";

		//COLOR
        float r = Random.Range(0.0f, 1.0f);
        float g = Random.Range(0.0f, 1.0f);
        float b = Random.Range(0.0f, 1.0f);
        rend = instantiatedCube.GetComponent<Renderer>();
        rend.material.color = new Color(r, g, b);

    }


	

}
